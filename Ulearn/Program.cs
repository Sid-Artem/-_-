using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                double number = 2;
                double result = 1;
                while (result <= number && number>0)
                    result = result*2;
               
                Console.WriteLine(result);

                Console.ReadLine(); 
            }
            
        }
    }
}
