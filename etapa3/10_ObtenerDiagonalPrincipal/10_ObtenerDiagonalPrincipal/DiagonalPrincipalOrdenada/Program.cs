using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un numero entero: ");
            int num_ent = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[num_ent, num_ent];
            Random random = new Random();
            Console.WriteLine("Los elementos de la diagonal son: ");
            for (int colu = 0; num_ent > colu; colu++)
            {
                for (int fil = 0; num_ent > fil; fil++)
                {
                    matriz[fil, colu] = random.Next(0, 150);
                    if (fil == colu)
                        Console.WriteLine(matriz[fil, colu]);
                }
            }

            Console.ReadKey();
        }
    }
}
