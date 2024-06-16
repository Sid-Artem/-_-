using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int N = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= N; i++)
            {
               Console.WriteLine(s += (2*i-1));

            }
            
            Console.ReadKey();

        }
    }
}
