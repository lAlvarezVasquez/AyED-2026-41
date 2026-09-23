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
            int numeroentero;
            Console.Write("Indique un numero entero : ");
            numeroentero=  int.Parse(Console.ReadLine());
            if (numeroentero%2==0 )
            {
                Console.Write("El numero es par");
                Console.ReadLine();

            }
              else
            {
                Console.Write("El numero es impar : ");
                Console.ReadLine();
             
            }
            Console.ReadKey();
            // Si el numero ingresado es 0 da como resultado que es par
        }
    }
}
