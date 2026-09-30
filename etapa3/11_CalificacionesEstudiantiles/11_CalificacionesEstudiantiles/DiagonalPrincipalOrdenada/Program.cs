using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un numero entero: ");
            int filas = Convert.ToInt32(Console.ReadLine());
            int columnas = 3;
            string[,] matriz = new string[filas, columnas];
            for (int fil = 0; filas > fil; fil++)
            {
                for (int colu = 0; columnas > colu; colu++)
                {
                    if (colu == 0)
                        Console.Write("Introduzca el nombre del estudiante: ");
                    if (colu == 1)
                        Console.Write("Introduzca la edad del estudiante: ");
                    if (colu == 2)
                        Console.Write("Introduzca la nota del estudiante: ");
                    matriz[fil, colu] = Console.ReadLine();
                    
                }
                if (fil != filas - 1)
                Console.WriteLine("Apartir de ahora, introduzca datos de otro alumno");
            }

            Console.ReadKey();

        }
    }
}
