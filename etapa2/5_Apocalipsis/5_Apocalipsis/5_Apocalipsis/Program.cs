using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Responder con Si o NO.");
            Console.Write("¿Tiene comida? : ");
            string comida = Console.ReadLine();
            comida = comida.ToUpper();
            Console.Write("¿Tiene un refugio? : ");
            string refugio = Console.ReadLine();
            refugio = refugio.ToUpper();
            Console.Write("¿Tiene un bate? : ");
            string bate = Console.ReadLine();
            bate = bate.ToUpper();

            if (comida == "SI" && refugio == "SI" && bate == "SI")
            {
                Console.Write("Usted sobrevive al apocalipsis");
            }
            else if (comida == "SI" && refugio == "SI" && bate == "NO")
            {
                Console.WriteLine("Muere por no tener protección");
            }
            else if (comida == "SI" && refugio == "NO" && bate == "NO")
            {
                Console.WriteLine("Muere por no tener protección");
                Console.WriteLine("Muere por no tener un lugar seguro");
            }
            else if (comida == "NO" && refugio == "NO" && bate == "SI")
            {
                Console.WriteLine("Muere por no tener alimento");
                Console.WriteLine("Muere por no tener un lugar seguro");
            }
            else if (comida == "SI" && refugio == "NO" && bate == "SI")
            {
                Console.WriteLine("Muere por no tener un lugar seguro");
            }
            else if (comida == "NO" && refugio == "SI" && bate == "SI")
            {
                Console.WriteLine("Muere por no tener comida");
            }
            else if (comida == "NO" && refugio == "NO" && bate == "NO")
            {
                Console.WriteLine("Muere por no tener nada");
            }
            else if (comida == "SI" && refugio == "NO" && bate == "SI")
            {
                Console.WriteLine("Muere por no tener un lugar para refugiarse");
            }
            else
            {
                Console.WriteLine("Ingrese las respuestas como estan pedidas");
            }
            Console.ReadKey();
        }
    }
}