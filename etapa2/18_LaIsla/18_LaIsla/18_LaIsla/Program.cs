using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_LaIsla
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int vida = 10;
            int hambre = 10;
            int dias = 1;
            int comida_cruda = 0;
            int comida_cocinada = 0;
            bool refugio = false;
            bool fogata = false;
            bool materiales = false;
            bool exploro = false;

            Console.WriteLine("Despiertas en una isla desconocida luego de un accidente. No tienes nada, deberas conseguir comida y explorar la isla para sobrevivir...");
            Console.WriteLine("\nElije una opción del menu para avanzar con el progreso\nPor cada dia que pase se te restará 2 de hambre y 1 de vida, pero sí el hambre llega a 0 la vida se irá reduciendo en 2.\nCada opción tiene consecuencias asi que no será facíl\n\nGanas si llegas a los 10 dias con minimo 1 de vida. Pierdes si ya no te queda vida.\n \ndatos principales:");
            Console.WriteLine("Datos del dia");
            Console.WriteLine("Dia : " + dias + "        Comida cruda : " + comida_cruda + "     Fogata : " + fogata);
            Console.WriteLine("Vida : " + vida + "      Comida cocida : " + comida_cocinada + "  Materiales : " + materiales);
            Console.WriteLine("Hambre : " + hambre + "   Refugio : " + refugio);
            Console.WriteLine("\nEn esta Isla el clima es muy extraño, puede ir en tu contra.");
            Console.Write("\nPresiona cualquier tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            while (opcion != 8)
            {
                Random rnd = new Random();
                int comida = rnd.Next(1, 100);

                Random rand = new Random();
                int explorar = rnd.Next(1, 100);

                Random i = new Random();
                double clima = rnd.Next(1, 100);

                Console.WriteLine("Datos del dia :\n");
                Console.WriteLine("Dia : " + dias + "        Comida cruda : " + comida_cruda + "     Fogata : " + fogata);
                Console.WriteLine("Vida : " + vida + "      Comida cocida : " + comida_cocinada + "  Materiales : " + materiales);
                Console.WriteLine("Hambre : " + hambre + "   Refugio : " + refugio);

                Console.Write("\nEstas pensando en...\n1. Buscar comida\n2. Explorar la isla\n3. Construir un refugio\n4. Encender una fogata\n5. Cocinar comida\n6. Comer comida cocida\n7. Descansar\n8. Salir\n¿Qué haras?(Ingresar el numero que quieras hacer) : ");
                opcion = int.Parse(Console.ReadLine());

                //Decisiones
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("ERROR, ingrese un numero del menú de opciones.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 1:
                        Console.WriteLine("\nSales a buscar comida por la isla y...");
                        if (comida >= 1 && comida <= 60)
                        {
                            Console.ReadKey();
                            Console.WriteLine("\nHas encontrado pedazos de comida cruda. Pero te cansaste");
                            dias++;
                            comida_cruda = comida_cruda + 2;
                            vida--;
                            hambre = hambre - 2;
                        }
                        else
                        {
                            Console.ReadKey();
                            Console.WriteLine("\nNo has podido encontrar nada de comida. Y te cansaste");
                            dias++;
                            vida--;
                            hambre = hambre - 2;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("\nCaminas por la isla en busca de recursos o información util. Y...");
                        Console.ReadKey();
                        if (explorar >= 1 && explorar <= 50)
                        {
                            Console.WriteLine("\nHas encontrado materiales utiles.");
                            dias++;
                            hambre = hambre - 2;
                            materiales = true;
                        }
                        else if (explorar >= 51 && explorar <= 80)
                        {
                            Console.WriteLine("\nNo has encontrado nada util.");
                            dias++;
                            hambre = hambre - 2;
                        }
                        else
                        {
                            Console.WriteLine("\nBuscando materiales utiles has tenido un accidente.");
                            dias++;
                            vida = vida - 2;
                            hambre = hambre - 2;
                        }
                        exploro = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("\nHaz intentado construir un refugio para protegerte.");
                        Console.ReadKey();
                        if (refugio == false)
                        {
                            Console.WriteLine("\nConstruyes un refugio");
                            refugio = true;
                            dias++;
                            hambre = hambre - 2;
                        }
                        else
                        {
                            Console.WriteLine("\nYa tienes un refugio, por lo que te quedas sin hacer nada");
                            dias++;
                            hambre = hambre - 2;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("\nVas a intentar encender una fogata. Y...");
                        Console.ReadKey();
                        if (refugio == true)
                        {
                            Console.WriteLine("\ncomo tienes un refugio haces una fogata.");
                            fogata = true;
                            dias++;
                            hambre = hambre - 2;
                        }
                        else if (exploro == true && materiales == true)
                        {
                            Console.WriteLine("\ndespués de haber explorado la isla y haber conseguido materiales decides hacer una fogata.");
                            dias++;
                            hambre = hambre - 2;
                            materiales = false;
                            fogata = true;
                        }
                        else
                        {
                            Console.WriteLine("\ncomo te faltan cosas para poder hacer una fogata no puedes.");
                            dias++;
                            hambre = hambre - 2;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("\nDecides cocinar la carne cruda. Y...");
                        if (comida_cruda >= 1 && fogata == true)
                        {
                            Console.WriteLine("\nlo has hecho y obtuviste una carne cocida");
                            comida_cocinada++;
                            comida_cruda--;
                            dias++;
                            hambre = hambre - 2;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nTe faltran cosas para cocinar la carne cruda");
                            dias++;
                            hambre = hambre - 2;
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("\nDecides comer comida cocinada");
                        Console.ReadKey();
                        if (comida_cocinada > 0)
                        {
                            Console.WriteLine("\nComes la carne que hayas cocinado.");
                            comida_cocinada--;
                            hambre = hambre + 4;
                            dias++;
                        }
                        else
                        {
                            Console.WriteLine("\nNo tienes comida cocida.");
                            dias++;
                            hambre = hambre - 2;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("\nDecides dormir para recuperar vida");
                        Console.ReadKey();
                        if (refugio == true)
                        {
                            Console.WriteLine("\nTe duermes");
                            vida = vida + 3;
                            dias++;
                            hambre = hambre - 2;
                            Console.ReadKey();
                        }
                        else if (refugio == false)
                        {
                            Console.WriteLine("\nTe duermes");
                            vida++;
                            dias++;
                            hambre = hambre - 2;
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine("\nTe sales del juego. Hasta luego.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("ERROR, ingrese un numero del menú de opciones.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                if (hambre < 0)
                {
                    vida = vida - 2;
                    hambre = 0;
                }
                if (vida > 10)
                {
                    vida = 10;
                }
                else if (vida < 0)
                {
                    vida = 0;
                }

                if (vida < 1)
                {
                    Console.WriteLine("PERDISTE");
                    Console.ReadKey();
                    Console.Clear();
                    opcion = 8;
                }
                else if (dias == 20 && vida > 0)
                {
                    Console.WriteLine("GANASTE");
                    Console.ReadKey();
                    Console.Clear();
                    opcion = 8;
                }

                //CLIMA
                if (clima >= 71 && clima <= 80)
                {
                    Console.WriteLine("Haz visto el cielo, está nublado. Después de unos minutos gotas empiezan a caer sobre tu cara\n");
                    if (fogata == true)
                    {
                        Console.WriteLine("La lluvia provocó que tu fogata se apague. La fogata ya no sirve");
                        fogata = false;
                    }
                    Console.ReadKey();
                }
                else if (clima >= 81 && clima <= 89.9)
                {
                    Console.WriteLine("Las nubes se juntaron mucho, parece que va a haber una tormenta. Cuidado puede que te parta un rayo.\n");
                    if (refugio == true || fogata == true)
                    {
                        Console.WriteLine("Por suerte no pasó nada. Pero la tormenta provocó la destrucción de tus cosas");
                        fogata = false;
                        refugio = false;
                    }
                    Console.ReadKey();
                }
                else if (clima == 90)
                {
                    Console.WriteLine("Las nubes se juntaron mucho, parece que va a haber una tormenta. Cuidado puede que te parta un rayo.\n");
                    Console.ReadKey();
                    Console.WriteLine("Que mala suerte, te partió un rayo. Perdiste\n");
                    Console.ReadKey();
                    opcion = 8;
                }
                else if (clima >= 91 && clima <= 95)
                {
                    Console.WriteLine("Hace mucho calor. Puede que la carne se te ponga mal\n");
                    vida--;
                    Console.ReadKey();
                    if (clima >= 96 && clima <= 100 && comida_cruda > 0)
                    {
                        Console.WriteLine("Se te descompuso toda la carne...\n");
                        comida_cocinada = comida_cocinada - 10;
                    }
                    else
                    {
                        Console.WriteLine("Por suerte no pasó nada\n");
                    }
                }
            }

        }
    }
}
