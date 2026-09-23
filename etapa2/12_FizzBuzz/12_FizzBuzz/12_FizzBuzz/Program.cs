using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 100;
            int contador = 1;
            while (contador <= numero )
            {
                if (contador % 3 == 0 && contador % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    contador++;

                }
                if (contador % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    contador++;
                    
                }
                else if (contador % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    contador++;
                }
                else
                {
                    Console.WriteLine(contador);
                    contador++;

                }
            }
            Console.ReadKey();
        }
    }
}
