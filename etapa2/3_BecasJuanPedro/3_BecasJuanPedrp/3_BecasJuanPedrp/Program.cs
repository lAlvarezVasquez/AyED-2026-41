using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedrp
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int salario_mensual;
            Console.Write("Ingresa tu edad : ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Ingresa tu salario : ");
            salario_mensual = int.Parse(Console.ReadLine());
            if (edad > 19 && salario_mensual <= 100000)
            {
                Console.WriteLine("Cpnseguiste la beca");
            } 
            else if (edad < 19 && salario_mensual == 0)
            {
                Console.WriteLine(" conseguiste la beca ");

            }
            else if (edad == 19 && salario_mensual==50000)
            {
                Console.WriteLine("Conseguiste la beca ");
            }
            else
            {
                Console.WriteLine("No conseguiste la beca ");
            }
            Console.ReadKey();
        }
    }
}
