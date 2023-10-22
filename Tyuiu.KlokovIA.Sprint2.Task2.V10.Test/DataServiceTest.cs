using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlokovIA.Sprint2.Task2.V10.Lib;

namespace Tyuiu.KlokovIA.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 5, y = 8;
            DataService ds = new DataService();
            Assert.AreEqual(ds.CheckDotInShadedArea(x, y), true);
        }
    }
}
