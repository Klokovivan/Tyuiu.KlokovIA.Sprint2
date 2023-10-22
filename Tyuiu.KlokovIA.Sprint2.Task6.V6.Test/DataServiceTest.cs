using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlokovIA.Sprint2.Task6.V6.Lib;

namespace Tyuiu.KlokovIA.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int m = 2, k = 9;
            string res = dataService.FindCardNameAndValue(m, k), wait = "Девятка треф";
            Assert.AreEqual(wait, res);
        }
    }
}
