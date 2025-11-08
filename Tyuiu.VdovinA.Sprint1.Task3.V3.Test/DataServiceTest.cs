using Microsoft.VisualStudio.TestTools.UnitTesting;


using Tyuiu.VdovinA.Sprint1.Task3.V3.Lib;

namespace Tyuiu.VdovinA.Sprint1.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 7.5;
            double z = 5;
            double wait = 6;
            var res = ds.Calculate(
                x, y, z);
            Assert.AreEqual(wait, res);
        }
    }
}