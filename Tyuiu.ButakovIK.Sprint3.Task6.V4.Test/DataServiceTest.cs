using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint3.Task6.V4.Lib;

namespace Tyuiu.ButakovIK.Sprint3.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(8, ds.GetSumTheDivisors(14, 20));
        }
    }
}
