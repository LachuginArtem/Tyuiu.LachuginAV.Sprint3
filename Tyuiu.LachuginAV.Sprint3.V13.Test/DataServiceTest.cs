using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint3.Task0.V13.Lib;

namespace Tyuiu.LachuginAV.Sprint3.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double value = 1.5;
            int startValue = 1, stopValue = 10;
            double res = dataService.GetSumSeries(value, startValue, stopValue), wait = 8.105;
            Assert.AreEqual(wait, res);
        }
    }
}