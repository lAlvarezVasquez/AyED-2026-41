using System;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la cantidad de participantes: ");
            int cant_part = Convert.ToInt32(Console.ReadLine());
            int[] lista_participantes = new int[cant_part];
            for (int i = 0; i < cant_part; i++)
            {
                Console.Write($"Introduzca el puntaje del participante {i + 1}: ");
                lista_participantes[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int pasada = 0; pasada < lista_participantes.Length - 1; pasada++)
            {
                for (int posicion = 0; posicion < lista_participantes.Length - 1 - pasada; posicion++)
                {
                    if (lista_participantes[posicion] < lista_participantes[posicion + 1])
                    {
                        int temporal = lista_participantes[posicion];
                        lista_participantes[posicion] = lista_participantes[posicion + 1];
                        lista_participantes[posicion + 1] = temporal;
                    }
                }
            }
            for (int i = 0; i < cant_part; i++)
            {
                Console.WriteLine($"el participante numero {i + 1} tiene {lista_participantes[i]} puntos ");           
            }



            Console.ReadKey();
        }
    }
}
