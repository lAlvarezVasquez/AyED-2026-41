using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MiDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1;
            float numero2;
            float resultado;
            Console.Write("Ingrese un numero entero para dividirlo con otro entero : ");
            numero1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero entero : ");
            numero2 = float.Parse(Console.ReadLine());
            resultado = numero1 / numero2;
            Console.Write("La division entre los dos numeros es : ");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
