using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagesApp.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Department
    {
        /// <summary>
        /// 部门姓名
        /// </summary>
        private string Name;
        /// <summary>
        /// 部门每日工资
        /// </summary>
        private string WagesOneDay;
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetWagesOneDay(string wagesOneDay)
        {
            WagesOneDay = wagesOneDay;
        }
        public string GetWagesOneDay()
        {
            return WagesOneDay;
        }
    }
}
