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
        public string Id { get; set; }
        /// <summary>
        /// 人员的姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 人员所在的部门
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// 工作时间
        /// </summary>
        public string JobTime { get; set; }
        /// <summary>
        /// 税前工资
        /// </summary>
        public string GrossPay { get; set; }
        /// <summary>
        /// 税后工资
        /// </summary>
        public string PosttaxWages { get; set; }

    }
}
