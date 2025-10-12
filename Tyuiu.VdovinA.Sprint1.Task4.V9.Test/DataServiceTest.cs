using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VdovinA.Sprint1.Task4.V9.Lib;

namespace Tyuiu.VdovinA.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            // Расчет: ln(2*2) / (2 - √(1 + 2²)) = ln(4) / (2 - √5) ≈ 1.3863 / (2 - 2.2361) ≈ 1.3863 / (-0.2361) ≈ -5.870
            double wait = -5.870;
            double res = ds.Calculate(x, y);
            double roundedRes = Math.Round(res, 3);
            Assert.AreEqual(wait, roundedRes);
        }
    }
}