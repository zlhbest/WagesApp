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
        public static bool UpdatePersonalToExcel(Person persons)
        {
            var temp = ExcelTool.Instance.ExcelToDataTable("resource/personinf.xls", "sheet1");
            var personalFormExcel = temp.DataTableToObject<List<Person>>();
            for(int i = 0;i< personalFormExcel.Count;i++)
            {
                if(personalFormExcel[i].Id == persons.Id)
                {
                    personalFormExcel[i] = persons;
                }
            }
            int count = ExcelTool.Instance.DataToExcel("resource/personinf.xls", personalFormExcel.ToDataTable(), "sheet1");
            return count == -1 ? false : true;
        }
    }
}
