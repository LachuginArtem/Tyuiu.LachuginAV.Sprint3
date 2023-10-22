using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint3.Task1.V7.Lib;

namespace Tyuiu.LachuginAV.Sprint3.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double value = 0.25;
            int startValue = 1, stopValue = 9;
            double res = dataService.GetMultiplySeries(value, startValue, stopValue), wait = -0.930;
            Assert.AreEqual(wait, res);
        }
    }
}