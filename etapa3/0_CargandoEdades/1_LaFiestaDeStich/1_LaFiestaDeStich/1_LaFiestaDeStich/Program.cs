using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStich
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int total_comida = 0;
            int promedio_de_comida_por_invitado;
            int cantidad_de_invitados;
            int comida_por_invitado;

            Console.Write("Ingresa la cantidad de invitados para la fiesta de Stich (Minimo 1 invitado y Maximo 100 ) :");
            cantidad_de_invitados = int.Parse(Console.ReadLine());
            while (cantidad_de_invitados > 100 || cantidad_de_invitados < 1)
            {
                Console.WriteLine("Recuerda que el minimo es 1 invitado y el maximo son 100 ");
                Console.Write("Ingresa la cantidad de invitados para la fiesta de Stich (Minimo 1 invitado y Maximo 100 ) :");
                Console.ReadLine();
            }
            int[] cantidad_de_comida = new int[cantidad_de_invitados];
            for ( int i = 0; i<cantidad_de_invitados; i++) {
                Console.WriteLine("Ingresa la cantidad de comida para cada invitado ");
                Console.Write("Invitado " + numero + ": ");
                cantidad_de_comida[i] = int.Parse(Console.ReadLine()); 
            }
            if (cantidad_de_comida[i] > 100 || cantidad_de_comida[i] < 1)
            {
                Console.WriteLine("La cantidad de  comida debe ser como minimo 1 y maximo 100 para cada invitado ");
                Console.WriteLine("Ingresa la cantidad de comida para cada invitado ");
                Console.Write("Invitado " + numero + ": ");
                cantidad_de_comida[i] = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();




        }
    }
}
