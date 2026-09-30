using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Sumando2Numeros
{
    class Program
    {
        static int concatenar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        
        static void Main(string[] args)
        {
            int algo = concatenar(7, 6);
            Console.WriteLine(algo);
            Console.ReadKey();
        }
    }
}
