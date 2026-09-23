using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_MayorDeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.Write("Indique su edad : ");
            edad= int.Parse(Console.ReadLine());
            if (edad > 17)
            {
                Console.Write("Eres mayor de edad");
                Console.ReadLine();
            }
            else   
            {
                Console.Write("Eres menor de edad");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
