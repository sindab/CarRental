using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGen.Interfaces;

namespace SharpGen.DataWrappers
{
	public class ObjectDataWrapper: IDataWrapper
	{
		private readonly object _dataObject;

		public ObjectDataWrapper(object data)
		{
			_dataObject = data;
		}

		string IDataWrapper.GetDataString(string propertyName)
		{
			var prop = _dataObject.GetType().GetProperty(propertyName);
			if (prop != null)
			{
				return prop.GetValue(_dataObject, null).ToString();
			}
			else return "";
		}

	}
}
