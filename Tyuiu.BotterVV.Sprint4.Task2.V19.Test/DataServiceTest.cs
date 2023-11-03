using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint4.Task2.V19.Lib;

namespace Tyuiu.BotterVV.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 4, 5, 6, 7, 7, 8, 9, 4, 6, 9, 7, 5, 6 };
            int res = ds.Calculate(numsArray);
            int wait = 49;
            Assert.AreEqual(wait, res);
        }
    }
}
