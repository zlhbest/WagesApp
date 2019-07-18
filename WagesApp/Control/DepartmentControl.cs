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
    public class DepartmentControl
    {
        public static List<Department> GetDepartmentFromExcel()
        {
            try
            {
                var temp = ExcelTool.Instance.ExcelToDataTable("resource/departmentaldailywage.xls", "sheet1");
                return temp.DataTableToObject<List<Department>>();
            }
            catch
            {
                return new List<Department>();
            }
        }

        public static bool UpdateDepartmentToExcel(Department department)
        {
            var temp = ExcelTool.Instance.ExcelToDataTable("resource/departmentaldailywage.xls", "sheet1");
            var departmentFormExcel = temp.DataTableToObject<List<Department>>();
            for (int i = 0; i < departmentFormExcel.Count; i++)
            {
                if (departmentFormExcel[i].Id == department.Id)
                {
                    departmentFormExcel[i] = department;
                }
            }
            int count = ExcelTool.Instance.DataToExcel("resource/departmentaldailywage.xls", departmentFormExcel.ToDataTable(), "sheet1");
            return count == -1 ? false : true;
        }
    }
}
