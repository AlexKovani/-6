using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ввести с клавиатуры предложение. 
                 Предложение представляет собой слова, разделенные пробелом.Знаки препинания не используются. 
                 Найти самое длинное слово в строке. */

            Console.Write("Введите предложение: ");
            string stroka = Console.ReadLine();
            string[] array = stroka.Split(' ');
            int length = array.Length;
            Console.WriteLine();
            int sMax = array[0].Length;
            string slovoMax = "";
            foreach (var a in array)
            {
                Console.WriteLine("{0,-15} - {1,5}", a, a.Length);
                if (a.Length > sMax)
                {
                    sMax = a.Length;
                    slovoMax = a;
                }
            }
            Console.WriteLine();
          
            Console.WriteLine("Самое длинное слово: {0} из {1} букв(ы)", slovoMax, sMax);
            Console.ReadKey();
        }
    }
}
