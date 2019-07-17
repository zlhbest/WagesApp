using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagesApp.ModelChange
{
    public static class ExcelToObject
    {
        /// <summary>
        /// excel反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static T DataTableToObject<T>(this DataTable dt)
        {
            var json = JsonConvert.SerializeObject(dt);

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
