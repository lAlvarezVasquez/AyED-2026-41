using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            double cilindro;
            double pistaporcilindro;
            double sectorporpista;
            double bytes;
            double kilobytes;
            double megabytes;
            double gigabytes;
            Console.Write("Coloca una cantidad de cilindro : ");
            cilindro = double.Parse(Console.ReadLine());
            Console.Write("Colocar pistaporcilindro : ");
           pistaporcilindro = double.Parse(Console.ReadLine());
            Console.Write("Colocar sector por pista : ");
            sectorporpista  = double.Parse(Console.ReadLine());
            bytes = 512;
            kilobytes = (cilindro * pistaporcilindro * sectorporpista * bytes) / 1000;
            megabytes= (cilindro * pistaporcilindro * sectorporpista * bytes) / 1000000;
            gigabytes = (cilindro * pistaporcilindro * sectorporpista * bytes) / 1000000000;
            Console.WriteLine("Cantidad de kilobytes : " + kilobytes);
            Console.ReadLine();
            Console.WriteLine("Cantidad de megabytes : " + megabytes);
            Console.ReadLine();
            Console.WriteLine("Cantidad de gigabytes : " + gigabytes);
            Console.ReadKey();




        }
    }
}
