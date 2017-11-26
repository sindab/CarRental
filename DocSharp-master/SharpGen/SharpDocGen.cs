using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using OpenXmlPowerTools;
using SharpGen.Interfaces;

namespace SharpGen
{
    public class SharpDocGen
    {
		//defines 
		readonly Regex _regex = new Regex("<!(.)*?!>", RegexOptions.Compiled);
	    private IDataWrapper _dataWrapper;


	    public bool GenerateDocument(string templatePath, string destDocxPath, IDataWrapper dataWrapper)
	    {
		    _dataWrapper = dataWrapper;
			File.Copy(templatePath, destDocxPath, overwrite: true);
			ReplaceTags(destDocxPath);
		    return false;
	    }

		private  void ReplaceTags(string filename)
		{


			using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filename, true))
			{
				//remove all markup properties that might separate tags into separate runs
				SimplifyMarkup(wordDocument);
				//grab the header parts and replace tags there
				foreach (HeaderPart headerPart in wordDocument.MainDocumentPart.HeaderParts)
				{
					ReplaceParagraphPartsEx(wordDocument, wordDocument.MainDocumentPart.Document);
				}
				//now do the document
				ReplaceParagraphPartsEx(wordDocument, wordDocument.MainDocumentPart.Document);
				//now replace the footer parts
				foreach (FooterPart footerPart in wordDocument.MainDocumentPart.FooterParts)
				{
					ReplaceParagraphPartsEx(wordDocument, wordDocument.MainDocumentPart.Document);
				}


			}
		}

		private static void SimplifyMarkup(WordprocessingDocument wordDocument)
		{
			SimplifyMarkupSettings settings = new SimplifyMarkupSettings
			{
				RemoveComments = true,
				RemoveContentControls = true,
				RemoveEndAndFootNotes = true,
				RemoveFieldCodes = false,
				RemoveLastRenderedPageBreak = true,
				RemovePermissions = true,
				RemoveProof = true,
				RemoveRsidInfo = true,
				RemoveSmartTags = true,
				RemoveSoftHyphens = true,
				ReplaceTabsWithSpaces = true,
			};
			MarkupSimplifier.SimplifyMarkup(wordDocument, settings);
			wordDocument.MainDocumentPart.Document.Save();
		}


		private  void ReplaceParagraphPartsEx(WordprocessingDocument doc, OpenXmlElement element)
		{
			foreach (var par in element.Descendants<Paragraph>())
			{
				string modifiedString = "";
				// get all runs under the paragraph and convert to be array
				Run[] runArr = par.Descendants<Run>().ToArray();
				// foreach each run
				foreach (Run run in runArr)
				{
					var matches = _regex.Matches(run.InnerText);
					foreach (Match match in matches)
					{
						modifiedString = run.InnerText.Replace(match.Value, GetDataString(match.Value));
						if (modifiedString != run.InnerText)
						{
							Text t = new Text(modifiedString);
							run.RemoveAllChildren<Text>();
							run.AppendChild<Text>(t);
						}
					}

					doc.MainDocumentPart.Document.Save();
					
				}
			}
		}

	    private string GetDataString(string value)
	    {
		    var str = value.Replace("<!", "").Replace("!>", "");
		    return _dataWrapper.GetDataString(str);
	    }

	}
}
