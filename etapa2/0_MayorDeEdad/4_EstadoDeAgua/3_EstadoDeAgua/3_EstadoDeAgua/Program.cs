using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradocelcius;
            Console.Write("Ingrese grados celcius : ");
            gradocelcius = double.Parse(Console.ReadLine());
            if (gradocelcius<=0)
            {
                Console.Write("Se congela todo ");

            }
            if (gradocelcius>=100)
            {
                Console.Write("Se hierve ");
                Console.ReadLine();

            }
            if (gradocelcius >= 1 && gradocelcius <= 99)
            {
                Console.Write("Esta en estado liquido ");
                Console.ReadLine();
            }
            Console.ReadKey();


        }
        
    }
}
