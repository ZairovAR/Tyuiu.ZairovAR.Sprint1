using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint1.Task7.V26.Lib;


namespace Tyuiu.ZairovAR.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            double x = 2;
            double y = 3;
            double z = 0.719;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);

        }
    }
}
