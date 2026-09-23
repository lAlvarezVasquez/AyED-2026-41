using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoDeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1;
            int lado2;
            int lado3;
            Console.Write("Ingresa el primer lado ; ");
            lado1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo lado : ");
            lado2 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el tercer lado ; ");
            lado3 = int.Parse(Console.ReadLine());
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("El triangulo es equilatero  ");

            }
            else if (lado1 == lado2 && lado1 != lado3 || lado1==lado3 && lado1!=lado2 || lado2==lado3 && lado2!= lado1)
            {
                Console.WriteLine("Es uun triangulo isoseles ");
            } 
            else if (lado1!=lado2 && lado1!=lado3 && lado2!=lado3)
            {
                Console.WriteLine("Es un triangulo escaleno ");

            }
            Console.ReadKey();
        }
    }
}
