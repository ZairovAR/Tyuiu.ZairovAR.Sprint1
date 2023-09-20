using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.ZairovAR.Sprint1.Task2.V7.Lib
{
    public class DataService : ISprint1Task1V7
    {
        public double Calculate(double x, double y)
        {
            return x * x * y;
        }
    }
}
