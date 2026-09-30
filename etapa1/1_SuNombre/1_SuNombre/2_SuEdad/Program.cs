using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SuNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("su nombre es: ");
            Console.WriteLine(nombre);
            Console.ReadKey();
        }
    }
}
