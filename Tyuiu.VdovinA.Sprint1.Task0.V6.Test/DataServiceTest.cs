using Tyuiu.VdovinA.Sprint1.Task0.V6.Lib;

namespace Tyuiu.VdovinA.Sprint1.Task0.V6.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(15, res);
        }
    }
}

