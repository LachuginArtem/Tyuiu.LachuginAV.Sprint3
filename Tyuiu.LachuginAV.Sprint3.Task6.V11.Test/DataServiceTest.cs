using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.LachuginAV.Sprint3.Task6.V11.Lib;

namespace Tyuiu.LachuginAV.Sprint3.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int start = 10;
            int end = 19;

            Assert.AreEqual(9, ds.GetSumTheDivisors(start, end));
        }
    }
}