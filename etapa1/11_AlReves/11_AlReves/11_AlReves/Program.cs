using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra1;
            string letra2;
         string letra3;
            string alreves;
            Console.Write("Indica una letra para ponerlas alreves : ");
             letra1 =(Console.ReadLine());
            Console.Write("Indique una letra : ");
             letra2 = (Console.ReadLine());
            Console.Write("Indique otra letra : ");
            letra3 = (Console.ReadLine());
             alreves = letra3 + letra2 + letra1;
            Console.Write("alreves es : " + alreves);
            Console.ReadKey();





        }
    }
}
