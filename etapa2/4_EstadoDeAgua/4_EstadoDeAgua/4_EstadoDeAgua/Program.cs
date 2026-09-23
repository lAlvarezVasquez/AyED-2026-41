using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura;
            Console.Write("Ingresa una temperatura :");
            temperatura = int.Parse(Console.ReadLine());
            if (temperatura <=0)
            {
                Console.WriteLine("Se congela");
            }
            else if (temperatura >=1 && temperatura <=99)
            {
                Console.WriteLine("Esta en estado liquido ");
            }
            else
            {
                Console.WriteLine("Hierve");
            }
            Console.ReadKey();
        }
    }
}
