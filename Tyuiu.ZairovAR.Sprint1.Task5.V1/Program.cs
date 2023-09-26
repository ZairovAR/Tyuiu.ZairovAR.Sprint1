using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZairovAR.Sprint1.Task5.V1.Lib;


namespace Tyuiu.ZairovAR.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Заиров А. Р. | ACOиУБ 23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс ConvertФайл                          *");
            Console.WriteLine("* Задание #1.5                                                            *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Заиров Артур Ранисович | AСОиУБ 23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1;
            double y1;
            double x2;
            double y2;

            Console.WriteLine("Введите число X1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число Y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число X2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число Y2 = ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(("Ответ: " + ds.DistanceBetweenDots(x1, y1, x2, y2)));
            Console.ReadLine();
        }
    }
}
