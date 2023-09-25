using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using Tyuiu.ZairovAR.Sprint1.Task4.V21.Lib;


namespace Tyuiu.ZairovAR.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            double x = 1;
            double y = 2;
            double z = 0.667;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);

        }
    }
}
