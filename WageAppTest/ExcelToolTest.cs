using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WagesApp.Utils;

namespace WageAppTest
{
    [TestClass]
    public class ExcelToolTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           var a =  ExcelTool.Instance.toRead("");
        }
    }
}
