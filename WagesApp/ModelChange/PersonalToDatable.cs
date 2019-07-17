using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WagesApp.Model;
using WagesApp.Utils;
using WagesApp.View;

namespace WagesApp.ModelChange
{
    public static class PersonalToDatable
    {
        public static DataTable ToDataTable(this List<Person> data)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Department", typeof(string));

            dt.Columns.Add("JobTime", typeof(string));
            dt.Columns.Add("GrossPay", typeof(string));
            dt.Columns.Add("PosttaxWages", typeof(string));

            foreach (var item in data)
            {
                var dr = dt.NewRow();
                dr["id"] = item.Id == "" ? RandomNumber.GenerateRandomCode() : item.Id;
                dr["Name"] = item.Name;
                dr["Department"] = item.Department;
                dr["JobTime"] = item.JobTime;
                dr["GrossPay"] = item.GrossPay;
                dr["PosttaxWages"] = item.PosttaxWages;

                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
