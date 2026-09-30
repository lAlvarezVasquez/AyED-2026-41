using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string ciudad;
            int edad;
            Console.Write("Indique su Nombre : ");
            nombre = Console.ReadLine();
            Console.Write("Indique su edad : ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Indique su ciudad : ");
            ciudad = Console.ReadLine();
            Console.Write("Tu nombre es " + nombre + ", Tenes la edad de" + " "  + edad +  " "  + " años "+ " " +  "y vives en la ciudad de " + ciudad);
            Console.ReadKey();



        }
    }
}
