using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пробелы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text= "  two spaces";

            while (char.IsWhiteSpace(text[0])  )
            {
                

                
                    text=text.Substring(1);
                   

            }
            
            Console.WriteLine(text);
            Console.ReadLine();


           


        }
    }
}
