using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZairovAR.Sprint1.Task7.V26.Lib;


namespace Tyuiu.ZairovAR.Sprint1.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Заиров А. Р. | ACOиУБ 23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решеию итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #1.7                                                            *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Заиров Артур Ранисович | AСОиУБ 23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                                                                           ");
            Console.WriteLine("     sinx^2 + y     xy - 12                                                ");
            Console.WriteLine(" z = ---------- - ------------                                             ");
            Console.WriteLine("       y + 1        34 + x^2                                               ");
            Console.WriteLine("                                                                           ");


            double x;
            double y;

            Console.WriteLine("Введите число X = ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число Y = ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine((ds.Calculate(x, y)));
            Console.ReadLine();

        }
    }
}
