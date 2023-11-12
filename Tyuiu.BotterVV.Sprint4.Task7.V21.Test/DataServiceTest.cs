using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint4.Task7.V21.Lib;

namespace Tyuiu.BotterVV.Sprint4.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int rows = 4;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "425963128528";
            int res = ds.Calculate(rows, columns, str);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}
