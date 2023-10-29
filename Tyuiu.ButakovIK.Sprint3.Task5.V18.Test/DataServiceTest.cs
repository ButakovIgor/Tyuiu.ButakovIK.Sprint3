using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint3.Task5.V18.Lib;

namespace Tyuiu.ButakovIK.Sprint3.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DataService = new DataService();

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;

            double res = DataService.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 768.361;

            Assert.AreEqual(wait, res);
        }
    }
}
