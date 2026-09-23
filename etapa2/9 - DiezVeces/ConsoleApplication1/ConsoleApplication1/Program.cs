using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int CONTAODR = 0;
            Console.Write("Escribe una palabra : ");
          palabra=  Console.ReadLine();
            while (CONTAODR <10)
            {
                Console.WriteLine(palabra);
                CONTAODR++;
            }
            Console.ReadKey();
        }
    }
}
