using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main()
        {
            int[] numeros = new int[6];
            int suma = 0;

            Console.Write("ingrese 6 numeros : ");
            for (int i = 0; i < 6; i++)
            { 
             
   
                 Console.Write("ingrese el numero : ");
                numeros[i] = int.Parse(Console.ReadLine());
                 }

            Console.Write("calcular el promedio: ");
            for (int i = 0; i < 6; i++)
            
                suma += numeros[i];

            double promedio = (double)suma / 6 ;
            Console.Write("el promedio es " + promedio);

            Console.Write("     La  suma de los numeros es ");
            for (int i = 0; i < 6; i++)
            {
                suma += numeros[i];
            }
         
            Console.Write("  :  " + suma);
            Console.ReadKey();

        }
       
    }
  
}

