using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1;
            float numero2;
            float numero3;
            float promedio;

            Console.Write("Ingrese un numero : ");
            numero1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero : ");
            numero2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero : ");
            numero3 = float.Parse(Console.ReadLine());
            promedio = (numero1 + numero2 + numero3) / 3;
            Console.Write("El promedio de los numeros es : " + promedio);
            Console.ReadKey();
        }
    }
}
