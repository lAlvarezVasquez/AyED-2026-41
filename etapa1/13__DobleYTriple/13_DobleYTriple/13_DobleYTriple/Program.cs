using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DobleYTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int doble;

            int triple;
            Console.Write("Indique un numero entero : ");
            numero = int.Parse(Console.ReadLine());
            doble = numero * 2;
            triple = numero * 3;
            Console.WriteLine("el doble es : " + doble);
            Console.Write("el triple es : " + triple);
            Console.ReadKey();
        }
    }
}
