using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VdovinA.Sprint1.Task2.V24.Lib;

namespace Tyuiu.VdovinA.Sprint1.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 3;
            var res = ds.CalculateDiffSquare(x, y);
            Assert.AreEqual(9, res); // (6-3)^2 = 9
        }

        [TestMethod]
        public void ValidSqrOfDifference()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 1;
            var res = ds.SqrOfDifference(x, y);
            Assert.AreEqual(1, res); // (2-1)^2 = 1
        }
    }
}