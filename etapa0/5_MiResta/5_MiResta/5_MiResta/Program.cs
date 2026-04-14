using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MiResta
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            Console.Write("Ingrese un numero entero para restarlo con otro entero : ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero entero : ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 - numero2;
            Console.Write("La resta entre los dos numeros es : ");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
