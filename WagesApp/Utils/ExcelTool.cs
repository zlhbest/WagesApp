using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WagesApp.Utils
{
    public class ExcelTool
    {
        public static ExcelTool Instance = null;
        static ExcelTool()
        {
            if(Instance==null)
            {
                Instance = new ExcelTool();
            }
        }
        //将构造方法私有，保证外部不会自己进行实例化
        private ExcelTool(){}
        public Dictionary<string, string> toRead(string Path)
        {
            DataSet ds = new DataSet();
            string  strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Path + ";" + "Extended Properties='Excel 12.0;HDR=YES;IMEX=1;'";
            Dictionary<string, string> idcards = new Dictionary<string, string>();
            OleDbConnection conn = new OleDbConnection(strConn);
            try
            {
                conn.Open();
                System.Data.DataTable dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });
                string[] strTableNames = new string[dtSheetName.Rows.Count];
                for (int k = 0; k < dtSheetName.Rows.Count; k++)
                {
                    strTableNames[k] = dtSheetName.Rows[k]["TABLE_NAME"].ToString();
                }
                OleDbDataAdapter myCommand = null;
                string strExcel = "select * from [" + strTableNames[1] + "]";
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                myCommand.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (!row.ItemArray[1].ToString().Equals(""))
                    {
                        idcards.Add(row.ItemArray[1].ToString(), row.ItemArray[0].ToString());
                    }
                }
                return idcards;
            }
            catch(Exception ex)
            {
                conn.Close();
                throw ex;
            }
           
        }
    }
}
