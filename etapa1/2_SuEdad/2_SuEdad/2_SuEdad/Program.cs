using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SuEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("su edad es: ");
            Console.WriteLine(edad);
            Console.ReadKey();
        }
    }
}
