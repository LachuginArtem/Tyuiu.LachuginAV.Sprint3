using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint3.Task3.V24.Lib;

namespace Tyuiu.LachuginAV.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            string a = "****** ";
            var res = ds.ReplaceCharInString(a, '*', 'c');
            Assert.AreEqual(res, "cccccc ");


        }
    }
}