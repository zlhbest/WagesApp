using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagesApp.Model
{
    /// <summary>
    /// 人员类型model
    /// </summary>
    public class Person
    {
        /// <summary>
        /// 人员的唯一标识符
        /// </summary>
        private string Id;
        /// <summary>
        /// 人员的姓名
        /// </summary>
        private string Name;
        /// <summary>
        /// 人员所在的部门
        /// </summary>
        private string Department;
        /// <summary>
        /// 工作时间
        /// </summary>
        private string JobTime;
        /// <summary>
        /// 税前工资
        /// </summary>
        private string GrossPay;
        /// <summary>
        /// 税后工资
        /// </summary>
        private string PosttaxWages;
        public void SetId(string id)
        {
            Id = id;
        }
        public string GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetDepartment()
        {
            return Department;
        }
        public void SetDepartment(string department)
        {
            Department = department;
        }
        public  void SetJobTime(string jobTime)
        {
            JobTime = jobTime;
        }
        public string GetJobTime()
        {
            return JobTime;
        }
        public void SetGrossPay(string grossPay)
        {
            GrossPay = grossPay;
        }
        public string GetGrossPay()
        {
            return GrossPay;
        }
        public void SetPosttaxWages(string posttaxWages)
        {
            PosttaxWages = posttaxWages;
        }
        public string GetPosttaxWages()
        {
            return PosttaxWages;
        }
    }
}
