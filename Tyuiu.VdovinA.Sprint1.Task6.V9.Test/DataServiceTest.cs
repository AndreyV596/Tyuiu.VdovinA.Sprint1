using Tyuiu.VdovinA.Sprint1.Task6.V9.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.VdovinA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "привет мир программирование";
            DataService ds = new DataService();
            string res = ds.MoveLastLetterToStart(strTest);
            string wait = "тприве рим епрограммированн";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void EmptyString()
        {
            string strTest = "";
            DataService ds = new DataService();
            string res = ds.MoveLastLetterToStart(strTest);
            string wait = "";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void SingleCharacterWords()
        {
            string strTest = "a b c";
            DataService ds = new DataService();
            string res = ds.MoveLastLetterToStart(strTest);
            string wait = "a b c";
            Assert.AreEqual(wait, res);
        }
    }
}