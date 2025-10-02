using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VdovinA.Sprint1.Task0.V6.Lib;



namespace Tyuiu.VdovinA.Sprint1.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
