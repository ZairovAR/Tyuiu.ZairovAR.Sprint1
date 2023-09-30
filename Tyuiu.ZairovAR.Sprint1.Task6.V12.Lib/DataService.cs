using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.ZairovAR.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            string[] words = value.Split(' ');
            string lastWord = words[words.Length - 1];

            if (value.IndexOf(lastWord, 0, value.LastIndexOf(lastWord)) >= 0) 
            {
                Console.WriteLine("Последнее слово входит в текст еще раз");
                return true;
            }
            Console.WriteLine("Последнее слово не входит в текст еще раз");
            return false;
           
        }
    }  
}
