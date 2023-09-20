using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint1.Task2.V7.Lib;


namespace Tyuiu.ZairovAR.Sprint1.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3.14;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(12.56 , res);
        }
    }
}
