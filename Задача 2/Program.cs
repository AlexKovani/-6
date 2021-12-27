using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ввести с клавиатуры предложение. 
              Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
              Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра 
              (пример палиндрома – «А роза упала на лапу Азора»). */

            Console.Write("Введите предложение: ");
            string stroka = Console.ReadLine();
            string[] array = stroka.Split(' ');
            string rez = string.Join("", array);
            rez = rez.ToUpper();
            char[] inputarray = rez.ToCharArray();
            Array.Reverse(inputarray);
            string output = new string(inputarray);
            output = output.ToUpper();
            Console.WriteLine();
            if (output==rez)
            {
                Console.WriteLine("Строка является палиндромом!");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом!");
            }
            
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
