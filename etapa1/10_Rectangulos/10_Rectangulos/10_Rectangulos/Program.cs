using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            double ancho;
            double altura;
            double perimetro;
            double area;
            double diagonal;
         
          
            Console.Write("Coloca un ancho de un rectangulo :");
            ancho = double.Parse(Console.ReadLine());
            Console.Write("Coloca la altura de un rectangulo : ");
            altura = double.Parse(Console.ReadLine());

            area = ancho * altura;
            perimetro = ancho * 2 + altura * 2;
            diagonal = Math.Sqrt(Math.Pow(ancho, 2) + Math.Pow(altura, 2));
            Console.WriteLine("El area es : " + area);
            Console.WriteLine("El perimetro es :" + perimetro);
            Console.Write("La diagonal es : " + diagonal);
            Console.ReadKey();




        }
    }
}
