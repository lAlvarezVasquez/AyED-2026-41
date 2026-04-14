using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
      
        
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubo;
            Console.Write("Coloca un numero para calcular su perimetro y su cubo : ");
            numero = Double.Parse(Console.ReadLine());
           cuadrado = Math.Pow(numero, 2);
            Console.Write("El cuadrado es : " + cuadrado);
            Console.ReadLine();
            cubo = Math.Pow(numero, 3);
            Console.Write("El cubo es :" + cubo);
            Console.ReadLine();
            Console.ReadKey();
            



        }
    }
}
