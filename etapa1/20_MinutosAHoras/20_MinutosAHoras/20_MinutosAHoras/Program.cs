using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        { int horas;
            int minutos;
            int minutosRestantes;
            Console.Write("Indica minutos : ");
            minutos= int.Parse(Console.ReadLine());
            horas = minutos / 60;
            minutosRestantes = minutos % 60;
            Console.Write("Los minutos equivalen a " + horas + "hrs" + " " + "y los minutos restantes son " + minutosRestantes);
            Console.ReadKey(); 
        }
    }
}
