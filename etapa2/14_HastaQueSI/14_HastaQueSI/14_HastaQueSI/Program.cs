using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Quieres terminar el programa? (poner SI): ");
            string respuesta = Console.ReadLine();
            if (respuesta != "SI")
            {
                while (respuesta != "SI")
                {
                    Console.Write("¿Quieres terminar el programa? : ");
                    respuesta = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}
