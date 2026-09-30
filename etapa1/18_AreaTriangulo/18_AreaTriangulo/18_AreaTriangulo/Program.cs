using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base;
            int Altura;
            int area;
            Console.Write("indica la base de un triangulo : ");
            Base = int.Parse(Console.ReadLine());
            Console.Write("Indica la altura de un triangulo : ");
            Altura = int.Parse(Console.ReadLine());
            area = Base * Altura/2;
            Console.Write("El area del triangulo es : " + area);
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
