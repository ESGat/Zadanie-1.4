using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк, которые хотите ввести: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] strs = new string[n];
            string t;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите строку №{0}:\r\n    ", i + 1);
                strs[i] = Console.ReadLine();
            }
            Console.WriteLine("Вы ввели следующие строки:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(strs[i]);
            }
            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                t = strs[i];
                strs[i] = strs[j];
                strs[j] = t;
            }
            Console.WriteLine("В обратном порядке: ");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(strs[j]);
            }
            Console.WriteLine("Нажмите любую клавишу, если хотите выйти. ");
            Console.ReadLine();
        }
    }
}
