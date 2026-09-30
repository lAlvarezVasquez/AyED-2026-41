using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_HolaNombre
{
    class Program
    {
        static string concatenar(string nombre)
        {
            return ("hola" + nombre);
        }
        
        
        static void Main(string[] args)
        {
            string algo = concatenar("pedro");
            Console.WriteLine(algo);
        }
    }
}
