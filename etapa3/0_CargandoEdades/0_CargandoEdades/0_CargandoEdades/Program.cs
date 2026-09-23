using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int[] edades = new int[5];
            for (int i = 0; i < 5; i++, num++)
            {
                Console.Write("Alumno " + num + ":");
                edades[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine(edades[i] + ",");
            }


            Console.ReadKey();

        }
       
    }
}
