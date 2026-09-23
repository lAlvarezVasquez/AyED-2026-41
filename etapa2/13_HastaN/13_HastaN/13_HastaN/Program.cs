using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.Write("Ingrese un numero : ");
            int numero = int.Parse(Console.ReadLine());
            while(contador < numero)
            {
                contador++;
                if(contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
            }
            Console.ReadKey();

        }
    }
}
