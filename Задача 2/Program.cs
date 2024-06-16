using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Введите последовательность чисел");
            int N = 0;
            int plus = 0;
            int minus = 0;

            do
            {
                N = int.Parse(Console.ReadLine());
                if (N > 0) plus++;
                if (N < 0) minus++;
            }

            while (N != 0);

            if (plus>minus) 
                Console.WriteLine ("Количество положительных больше");
            if (plus < minus)
                Console.WriteLine("Количество отрицательных больше");

            Console.ReadKey();

        }
    }
}
       