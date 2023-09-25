using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZairovAR.Sprint1.Task3.V4.Lib;


namespace Tyuiu.ZairovAR.Sprint1.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Заиров А. Р. | ACOиУБ 23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #1.3                                                            *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Заиров Артур Ранисович | AСОиУБ 23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости покупки, состоящей из нескольких*");
            Console.WriteLine("* тетрадей и такого же количества обложек к ним.                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double priceNotebook;
            double priceCover;
            int quantity;
           

            Console.WriteLine("Цена тетради (руб.) -> ");
            priceNotebook = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Цена обложки (руб.) -> ");
            priceCover = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Количество комплектов (шт.) -> ");
            quantity = Convert.ToInt32(Console.ReadLine());

    

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Стоимость покупки:" + Math.Round(ds.PurchaseAmount(priceNotebook, priceCover, quantity), 3) + "руб.");
            Console.ReadLine();

        }
    }
}
