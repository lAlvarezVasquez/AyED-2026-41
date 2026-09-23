using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cmplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int contador = 0;
            Console.Write("Ingrese su edad : ");
            edad = int.Parse(Console.ReadLine());
            while (contador < edad)
            {
                contador++;
                Console.WriteLine (contador);
                

            
            }
            Console.ReadKey();
        }
    }
}
