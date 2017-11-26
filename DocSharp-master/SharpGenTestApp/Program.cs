using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SharpGen;
using SharpGen.DataWrappers;

namespace SharpGenTestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var sourceTemplateDocx = @"..\..\TestTemplate\TestTemplate1.docx";
			var destDocx = @"..\..\TestTemplate\\NewTestTemplate1.docx";
			var docGen = new SharpDocGen();

			//Can run using an ObjectDataWrapper for Entity Framework
			docGen.GenerateDocument(sourceTemplateDocx, destDocx, new ObjectDataWrapper(GetObjectWtihValues()));

			//Can run using an ADO.NET wrapper for a DataTable
			//docGen.GenerateDocument(sourceTemplateDocx, destDocx, new ADONETDataWrapper(GetDataTable()));

			System.Diagnostics.Process.Start(destDocx);
		}

		private static object GetObjectWtihValues()
		{
			return new TestObject();
		}

		public static DataTable GetDataTable()
		{
			var table = new DataTable();
			table.Columns.Add("FullName", typeof(string));
			table.Columns.Add("FormalEffectiveDate", typeof(string));
			table.Columns.Add("Chapter", typeof(string));
			table.Columns.Add("OrderName", typeof(string));
			table.Columns.Add("PositionTitle", typeof(string));
			table.Columns.Add("Chairman", typeof(string));
			table.Columns.Add("Director", typeof(string));
            table.Columns.Add("Test", typeof(string));


            var row = table.NewRow();
			var obj = new TestObject();

			row["Fullname"] = obj.FullName;
			row["FormalEffectiveDate"] = obj.FormalEffectiveDate;
			row["Chapter"] = obj.Chapter;
			row["OrderName"] = obj.OrderName;
			row["PositionTitle"] = obj.PositionTitle;
			row["Chairman"] = obj.Chairman;
			row["Director"] = obj.Director;
            row["Test"] = obj.Test;

            table.Rows.Add(row);

			return table;
		}



	}

	public class TestObject
	{
		public string FullName { get; set; } = "Jim Jones";
		public string FormalEffectiveDate { get; set; } = "Tenth day of November, Two Thousand and Ten";
		public string Chapter { get; set; } = "Fourth Amazing";
		public string OrderName { get; set; } = "The Reptilian Peacocks";
		public string PositionTitle { get; set; } = "Class 1 Rookie";
		public string Chairman { get; set; } = "Farly McFarlain";
		public string Director { get; set; } = "Chadwick (the wolf) Smith";
        public string Test { get; set; } = "Dabic Sinisa";


    }

}
