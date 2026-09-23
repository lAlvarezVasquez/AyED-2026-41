using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            int num2;
            int num1;
            string persona;
            int sum;
            int mult1;
            int mult2;
            int multRE;
            Console.Write("Bienvenido al menu, escoge una opcion del menu\n1: sumar numeros:\n2: Mandar un saludo a alguien :\n3: multiplicar:\n4 Salir de las opciones:\n elegir opciones:  ");
            opc = int.Parse(Console.ReadLine());
            while(opc != 4)
            {
                Console.Clear();
                Console.Write("Bienvenido al menu, escoge una opcion del menu\n1: sumar numeros:\n2: Mandar un saludo a alguien :\n3: multiplicar:\n4 Salir de las opciones:\n elegir opciones:  ");
                opc = int.Parse(Console.ReadLine());                
                    switch (opc)
                {
                    case 1:
                        Console.Write("Ingrese el primer numero  para calcular : ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero  para calcular : ");
                        num2 = int.Parse(Console.ReadLine());
                        sum = num1 + num2;
                        Console.WriteLine(sum);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Write("Ingrese el nombre de alguien para saludarlo : ");

                        persona = Console.ReadLine();
                        Console.Write("Hola " + persona + " espero tengas un buen dia ");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Write("Ingresa un numoero para multiplicar : ");
                        mult1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingresa otro numoero para multiplicar : ");
                        mult2 = int.Parse(Console.ReadLine());
                        multRE = mult1 * mult2;
                        Console.WriteLine(multRE);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Write("Te saliste de las opciones  ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                }
            Console.ReadKey();
            
             

            }
        }
    }

