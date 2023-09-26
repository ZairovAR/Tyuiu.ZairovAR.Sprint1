using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint1.Task5.V1.Lib;


namespace Tyuiu.ZairovAR.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x1 = 1;
            double y1 = 2;
            double x2 = 1;
            double y2 = 2;
            double z = 0;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(z, res);
        }
    }
}
