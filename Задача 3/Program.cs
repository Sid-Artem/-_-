using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число А");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int c = int.Parse(Console.ReadLine());
            int shetshik = 0;
            int vrem = 0;
            while ((a - c) >= 0)
            {
                a -= c;
                vrem = b;

                while ((vrem - c) >= 0)
                {
                    vrem -= c;
                    shetshik++;

                }
            }
            Console.WriteLine(shetshik);
            Console.ReadKey();
        }
    }
}
