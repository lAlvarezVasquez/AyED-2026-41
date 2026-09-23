using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuaPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int salario;
            Console.Write("Ingresa tu edad : ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su salario mensual (Sino tienes salario mensual pon 0): ");
            salario = int.Parse(Console.ReadLine());

            if (edad >= 19 && salario <= 100000)
            {
                Console.Write("TENES LA BECA");
                Console.ReadLine();
            }
            else
            {
                Console.Write("No tenes la beca ");
                Console.ReadLine();
            }
            if (edad < 19 && salario == 0)
            {
                Console.Write("TENES LA BECA");
                Console.ReadLine();
            }
            else
            {
                Console.Write("No tenes la beca ");
                Console.ReadLine();
            }
            if (edad == 19 && salario == 50000)
            {
                Console.Write("TENES LA BECA");
                Console.ReadLine();
            }
            else
            {
                Console.Write("No tenes la beca ");
                Console.ReadLine();

            }

            Console.ReadKey();
        }
    }
}
    
