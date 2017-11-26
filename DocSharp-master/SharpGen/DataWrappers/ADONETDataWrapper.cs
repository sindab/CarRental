using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGen.Interfaces;
using System.Data.SqlClient;

namespace SharpGen.DataWrappers
{
	public class ADONETDataWrapper: IDataWrapper
	{
		private System.Data.DataTable _data;

		public ADONETDataWrapper(System.Data.DataTable table)
		{
			_data = table;
		}

		public string GetDataString(string propertyName)
		{
			if (_data.Rows.Count > 0 && _data.Rows[0][propertyName] != null)
			{
				return _data.Rows[0][propertyName].ToString();
			}
			else return "";
		}
	}
}
