using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            double LongitudDeCuadrado;
            double perimetro;
            double superficie;
            Console.Write("Coloca la longitud de un cuadrado : ");
            LongitudDeCuadrado = double.Parse(Console.ReadLine());
            perimetro = LongitudDeCuadrado * 4;
            superficie = LongitudDeCuadrado * 2;
            Console.Write("La superficie es : " + superficie);
            Console.ReadLine();
            Console.Write("El perimetro es : " + perimetro);
            Console.ReadLine();
            Console.ReadKey();


        }
    }
}
