using System;

namespace _1_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de invitados: ");
            int invitados = int.Parse(Console.ReadLine());

            int totalComida = 0;

            for (int i = 0; i < invitados; i++)
            {
                Console.Write($"Ingrese la cantidad de comida del invitado {i + 1}: ");
                int comida = int.Parse(Console.ReadLine());

                while (comida < 1 || comida > 100)
                {
                    Console.Write("Valor inválido. Ingrese una cantidad entre 1 y 100: ");
                    comida = int.Parse(Console.ReadLine());
                }
                totalComida += comida;
            }
            double promedio = (double)totalComida / invitados;
            Console.WriteLine($"El promedio de comida por invitado es: {promedio}");
            Console.ReadKey();
        }
    }
}