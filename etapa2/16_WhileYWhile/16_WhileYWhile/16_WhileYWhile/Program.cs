using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            int numerosimpares;
            Console.WriteLine("Numeros impares : ");

            while (contador <= 100)
            {

                if (contador % 2 == 1)
                {
                    Console.WriteLine(contador);
                    contador++;

                }
                else
                {
                    contador++;
                }

            }
            Console.WriteLine("Numeros pares : ");
            contador = contador - 100;
            while (contador <= 100)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                    contador++;
                }
                else
                {
                    contador++;
                }
            }
            Console.WriteLine("Numeros del 0 al 100 : ");
            contador = contador - 101;
          
            while ( contador <=100)
            {

                Console.WriteLine(contador);
                contador++;

            }
            Console.WriteLine("Numeros multiplos de 3 : ");
            contador = contador - 101;
            while ( contador <= 100)
            {
                Console.WriteLine(contador);
                contador = contador + 3;
            }
            Console.WriteLine("Numeros multiplos de 3 y de 2 : ");
            contador = contador - 101;
            while (contador <= 100)
            {

                if (contador % 2 == 0 && contador % 3 == 0)
                {
                    Console.WriteLine(contador);
                    contador++;
                }

                else
                {

                    contador++;
                }
            }
                Console.ReadKey();
        }
    }
}
