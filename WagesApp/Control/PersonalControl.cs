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
    public static class PersonalControl
    {
        public static List<Person> GetPeopleFromExcel()
        {
            try
            {
                var temp = ExcelTool.Instance.ExcelToDataTable("resource/personinf.xls", "sheet1");
                return temp.DataTableToObject<List<Person>>();
            }
            catch
            {
                return new List<Person>();
            }
        }
    }
}
