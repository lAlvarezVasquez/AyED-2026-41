using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AñoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.Write("Colocar un año cualquiera : ");
            año = int.Parse(Console.ReadLine());
            if (año % 4== 0 && año % 400 ==0 )
            {
                Console.WriteLine("Es año bisiesto ");
            }
            else
            {
                Console.WriteLine("No es año bisiesto ");
            }
            Console.ReadKey();
             

        }
    }
}
