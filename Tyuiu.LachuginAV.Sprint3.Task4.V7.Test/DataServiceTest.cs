using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.LachuginAV.Sprint3.Task4.V7.Lib;

namespace Tyuiu.LachuginAV.Sprint3.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            Assert.AreEqual(0, ds.Calculate(start, stop));
        }
    }
}