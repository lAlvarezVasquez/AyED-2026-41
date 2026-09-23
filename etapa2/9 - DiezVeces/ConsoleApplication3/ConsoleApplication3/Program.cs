using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {

            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                int suma = numeros[i] + numeros[9 - i];
                Console.WriteLine("La suma es " + suma);
            }
            Console.ReadKey();

        }
           
        }
     }


