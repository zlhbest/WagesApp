using System;
using System.Collections.Generic;
using System.Data;
using WagesApp.Model;
using WagesApp.Utils;

namespace WagesApp.ModelChange
{
    public static class DepartmentToDataTable
    {
        /// <summary>
        /// 对list<Department>的扩展方法，将其转为datatable
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable ToDataTable(this List<Department> data)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("WagesOneDay", typeof(string));

            foreach (var item in data)
            {
                var dr = dt.NewRow();
                dr["id"] = item.Id == "" ? RandomNumber.GenerateRandomCode() : item.Id;
                dr["Name"] = item.Name;
                dr["WagesOneDay"] = item.WagesOneDay;

                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
