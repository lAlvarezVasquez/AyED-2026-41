using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDeNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int monedasDorada = 10;
            int puntajetotal;
            int monedasplateadas = 2;
            int monedaDorada;
            int MonedaDePlata;
            Console.Write("Ingresa cuantas monedas de doradas conseguiste : ");
            monedaDorada = int.Parse(Console.ReadLine());
            Console.Write("Ingresa cuantas monedas plateadas conseguiste : ");
            MonedaDePlata = int.Parse(Console.ReadLine());
            puntajetotal = monedaDorada * monedasDorada + MonedaDePlata * monedasplateadas;
            if (puntajetotal < 50)
            {
                Console.WriteLine("Nivel insuficiente ");

            }
            else if (puntajetotal >=50 && puntajetotal <= 99)
            {
                Console.WriteLine("Nivel superado ");
            }
            else
            {
                Console.WriteLine("Nivel superado con bonus ");
            }
            Console.ReadKey();
        }
    }
}
