using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WagesApp.Model;
using WagesApp.ModelChange;
using WagesApp.Utils;

namespace WagesApp.Control
{
    public static class adminControl
    {
        public static bool login(string name, string password)
        {
            try
            {
                var adminjson = ExcelTool.Instance.ExcelToDataTable("resource/admin.xls", "sheet1");
                var datas = adminjson.DataTableToObject<List<admin>>();
                foreach (var item in datas)
                {
                    if (item.name == name)
                    {
                        if (item.password == password)
                        {
                            return true;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            return false;
        }
    }
}
