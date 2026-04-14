using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
       
           
            Console.Write("Indique su nombre : ");
            nombre = Console.ReadLine();
            Console.Write("Indique su apellido : ");
             apellido = Console.ReadLine();
    
            Console.WriteLine("Su nombre y apellido es : " + nombre + " " + apellido);
            Console.ReadKey();

         
        }
    }
}
