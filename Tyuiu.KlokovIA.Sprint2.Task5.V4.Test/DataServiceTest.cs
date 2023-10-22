using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlokovIA.Sprint2.Task5.V4.Lib;

namespace Tyuiu.KlokovIA.Sprint2.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 2;
            string res = ds.FindCardSuit(value);
            string wait = "трефы";

            Assert.AreEqual(res, wait);
        }
    }
}
