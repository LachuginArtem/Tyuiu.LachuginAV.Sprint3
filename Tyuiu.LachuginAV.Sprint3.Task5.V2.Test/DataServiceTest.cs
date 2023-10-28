using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.LachuginAV.Sprint3.Task5.V2.Lib;

namespace Tyuiu.LachuginAV.Sprint3.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int start1 = 1; int stop1 = 3;
            int start2 = 1; int stop2 = 12;

            Assert.AreEqual(35.658, ds.GetSumSumSeries(x, start1, start2, stop1, stop2));
        }
    }
}