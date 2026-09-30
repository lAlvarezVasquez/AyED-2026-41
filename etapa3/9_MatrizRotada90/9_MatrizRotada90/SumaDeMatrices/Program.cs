using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_MatrizRotada90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca el tamaño de la matriz: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[tamaño, tamaño];
            int[,] matriz_rotada = new int[tamaño, tamaño];

     
            for (int fil = 0; fil < tamaño; fil++)
            {
                for (int colu = 0; colu < tamaño; colu++)
                {
                    Console.Write($"Introduzca un numero para [{fil},{colu}]: ");
                    matriz[fil, colu] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int fil = 0; fil < tamaño; fil++)
            {
                for (int colu = 0; colu < tamaño; colu++)
                {
                    matriz_rotada[colu, tamaño - 1 - fil] = matriz[fil, colu];
                }
            }

            Console.WriteLine("Matriz rotada:");

            for (int fil = 0; fil < tamaño; fil++)
            {
                for (int colu = 0; colu < tamaño; colu++)
                {
                    Console.Write(matriz_rotada[fil, colu] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Matriz original:");

            for (int fil = 0; fil < tamaño; fil++)
            {
                for (int colu = 0; colu < tamaño; colu++)
                {
                    Console.Write(matriz[fil, colu] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
