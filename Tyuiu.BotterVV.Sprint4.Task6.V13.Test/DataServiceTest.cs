using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint4.Task6.V13.Lib;

namespace Tyuiu.BotterVV.Sprint4.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var cars = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            int res = ds.Calculate(cars);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
