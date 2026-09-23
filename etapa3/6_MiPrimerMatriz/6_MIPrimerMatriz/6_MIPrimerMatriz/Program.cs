using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MIPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas;
            int columnas;
            Console.Write("Pon la cantidad de filas : ");
            filas = int.Parse(Console.ReadLine());
            Console.Write("Pon la cantidad de  columnas : ");
            columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine(" ");





            }
            Console.ReadKey();
        }
    }
}
