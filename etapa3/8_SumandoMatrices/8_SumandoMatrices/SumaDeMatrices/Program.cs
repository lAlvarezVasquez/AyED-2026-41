using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca aqui la cantidad de filas: ");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca aqui la cantidad de columnas: ");
            int columnas = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];
            int[,] matriz2 = new int[filas, columnas];
            int[,] resul_matriz = new int[filas, columnas];
            for (int colu = 0; columnas > colu; colu++)
            {
                for (int fil = 0; filas > fil; fil++)
                {
                    Console.Write($"Introduzca un numero (va a ir en la columna {colu}) en la primera matriz: ");
                    matriz[fil, colu] = Convert.ToInt32(Console.ReadLine());
                  
                }
            }
            for (int colu = 0; columnas > colu; colu++)
            {
                for (int fil = 0; filas > fil; fil++)
                {
                    Console.Write($"Introduzca un numero (va a ir en la columna {colu}) en la segunda matriz: ");
                    matriz2[fil, colu] = Convert.ToInt32(Console.ReadLine());
                   
                }
            }
            for (int colu = 0; columnas > colu; colu++)
            {
                for (int fil = 0; filas > fil; fil++)
                {
                    resul_matriz[fil, colu] = matriz[fil, colu] + matriz2[fil, colu];
                   
                }
            }
            for (int fil = 0; fil < filas; fil++)
            {
                for (int colu = 0; colu < columnas; colu++)
                {
                    Console.Write($"{resul_matriz[fil, colu]}  ");
                }

                Console.WriteLine();
            }









            Console.ReadKey();
        }
    }
}
