using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPokeRemedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 2;
            int lista = 0;

            int posicion = 0; 
            Console.WriteLine("------------------------------------");
            Console.WriteLine("C E N T R O  P O K É - R E M E D I O");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Elija una opcióbn: ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1- Registrar un nuevo pokemón");
            Console.WriteLine("2- Mostrar la vida de todos los pokemones");
            Console.WriteLine("3- Curar un pokemón");
            Console.WriteLine("4- Dañar un pokemon");
            Console.WriteLine("5- Curar a todos los pokemones");
            Console.WriteLine("6- Mostrar pokemones debilitados");
            Console.WriteLine("7- Mostrar el pokemon con mayor vida");
            Console.WriteLine("8- Mostrar el pokemon con menor vida");
            Console.WriteLine("9- Calcular promedio de vida del equipo");
            Console.WriteLine("10- Ordenar pokemones por vida de menor a mayor");
            Console.WriteLine("11- Ordenar pokemones por vida de mayor a menor");
            Console.WriteLine("12- Simular ataque enemigo a todo el equipo");
            Console.WriteLine("13- Salir");
            opcion = int.Parse(Console.ReadLine());
            int[] vidaDePokemon = new int[6];
            
            switch (opcion)
            {  
                case 1 :
                    if (lista < 6)
                    {
                        Console.Write("Ingresa la vida de tu pokemon : ");
                        Console.ReadLine();

                    }           
                    
                    break;
            }


        }
    }
}
