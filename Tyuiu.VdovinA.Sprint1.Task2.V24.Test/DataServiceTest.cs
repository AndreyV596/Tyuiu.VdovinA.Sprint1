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
            int x = 2;
            var res = ds.SqrOfDifference(x);
            Assert.AreEqual(4, res);
        }
    }
}
