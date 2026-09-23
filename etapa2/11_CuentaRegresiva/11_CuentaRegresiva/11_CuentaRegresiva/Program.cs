using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeropositivo;
            int contador = 0;
            Console.Write("iNGRESA UN NUMERO POSITIVO : ");
            numeropositivo = int.Parse(Console.ReadLine());
            while (contador <= numeropositivo)
            {
                Console.WriteLine(numeropositivo);
                numeropositivo--;

                
            }
            Console.ReadKey();
        }
    }
}
