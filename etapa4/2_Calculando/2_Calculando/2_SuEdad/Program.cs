using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Calculando
{
    class operaciones
    {
        public int dat1 = 0;
        public int dat2 = 0;
        public void suma()
        {
            Console.Write($"{dat1} + {dat2} = {dat1 + dat2}");
        }
        public void resta()
        {
            Console.Write($"{dat1} - {dat2} = {dat1 - dat2}");

        }
        public void multiplicacion()
        {
            Console.Write($"{dat1} * {dat2} = {dat1 * dat2}");
        }
        public void division()
        {
            Console.Write($"{dat1} / {dat2} = {dat1 / dat2}");
        }
    }


    class menu
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un valor: ");
            operaciones op = new operaciones();
            op.dat1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca un valor otra vez: ");
            op.dat2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Que operaciones queres realizar?");
            Console.WriteLine("0: suma");
            Console.WriteLine("1: resta");
            Console.WriteLine("2: multplicacion");
            Console.WriteLine("3: division ");
            int ope = Convert.ToInt32(Console.ReadLine());
            switch (ope)
            {
                default:
                    Console.WriteLine("El valor introducido no es valido. Reinicie el programa y vuelva a intentar");
                    break;
                case 0:
                    op.suma();
                    break;
                case 1:
                    op.resta();
                    break;
                case 2:
                    op.multiplicacion();
                    break;
                case 3:
                    op.division();
                    break;

            }


            Console.ReadKey();
        }
    }





}