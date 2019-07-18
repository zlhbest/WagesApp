using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WagesApp.Model;
using WagesApp.ModelChange;
using WagesApp.Utils;

namespace WageAppTest
{
    [TestClass]
    public class ExcelToolTest
    {
        [TestMethod]
        public void TestMethod1()
        {
          var a =  ExcelTool.Instance.ExcelToDataTable("resourcetest/test.xls","sheet1");
          var datas = a.DataTableToObject<List<Department>>();
        }
        [TestMethod]
        public void TestToWrite()
        {
            List<Department> departments = new List<Department>();//定义数据
            Department a = new Department();
            a.Id =RandomNumber.GenerateRandomCode();
            a.Name = "我是n";
            a.WagesOneDay = "200";
            departments.Add(a);
            string file = "resourcetest/test.xls";
            var count = ExcelTool.Instance.DataToExcel(file,departments.ToDataTable(), "sheet1",true);
        }
    }
}
