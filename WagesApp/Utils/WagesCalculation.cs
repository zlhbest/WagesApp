using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WagesApp.Control;
using WagesApp.Model;

namespace WagesApp.Utils
{
    public static class WagesCalculation
    {
        public static double GetGrossPay(Person person)
        {
            double GrossPay = 0;
            var departments = DepartmentControl.GetDepartmentFromExcel();
            Department dm = null;
            foreach(var item in departments)
            {
                if(person.Department == item.Name)
                {
                    dm = item;
                }
            }
            if(dm!=null)
            {
                
                GrossPay = double.Parse(dm.WagesOneDay) * double.Parse(person.JobTime);
            }
            return GrossPay;
        }
        public static double GetPosttaxWages(Person person)
        {
            double PosttaxWages = 0;//税后
            double GrossPay = float.Parse(person.GrossPay);//税前
            double GrossPay5000 = GrossPay - 5000;
            //税务计算方法
            if (GrossPay != 0)
            {
                if( (GrossPay5000 < 0) || (GrossPay5000 == 0))
                {
                    PosttaxWages = GrossPay;
                }
                else if(GrossPay5000<3000 || GrossPay5000==3000)
                {
                    PosttaxWages = GrossPay - GrossPay5000 * 0.03;
                }
                else if(GrossPay5000<12000 || GrossPay5000==12000)
                {
                    PosttaxWages = GrossPay - (GrossPay5000 * 0.1-210);
                }
                else if (GrossPay5000 < 25000 || GrossPay5000 == 25000)
                {
                    PosttaxWages = GrossPay - (GrossPay5000 * 0.2 - 1410);
                }
                else if (GrossPay5000 < 35000 || GrossPay5000 == 35000)
                {
                    PosttaxWages = GrossPay - (GrossPay5000 * 0.25 - 2660);
                }
                else if (GrossPay5000 < 55000 || GrossPay5000 == 55000)
                {
                    PosttaxWages = GrossPay - (GrossPay5000 * 0.3 - 4410);
                }
                else if (GrossPay5000 < 80000 || GrossPay5000 == 80000)
                {
                    PosttaxWages = GrossPay - (GrossPay5000 * 0.35 - 7160);
                }
                else if (GrossPay5000 > 80000)
                {
                    PosttaxWages = GrossPay - (GrossPay5000 * 0.45 - 15160);
                }

            }
            return PosttaxWages;
        }
    }
}
