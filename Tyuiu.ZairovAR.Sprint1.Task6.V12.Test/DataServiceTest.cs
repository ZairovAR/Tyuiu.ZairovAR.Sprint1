using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection.Emit;
using System.Security.AccessControl;
using Tyuiu.ZairovAR.Sprint1.Task6.V12.Lib;


namespace Tyuiu.ZairovAR.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string text = "mama mam";

            bool lastWordCheck = ds.CheckLastWordRepetiton(text);




        }
    }
}
