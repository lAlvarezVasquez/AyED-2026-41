using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main()
        {
      

            int[] pares = new int[4];
            for (int i = 0; i < 4; i++)
            { 
                Console.Write(" ingrese numeros : ");
            pares[i] = int.Parse(Console.ReadLine());
              }
                Console.Write("buscar el numero mayor y encontrar en que posicion esta");
              
                int mayor = pares[0];
                int posicion = 0;
                for (int i = 1; i < 4; i++)
            { 
                    if (pares[i] > mayor)
                { 
                mayor = pares[i];
                posicion = i;
                 }
             }
                Console.Write(" : mayor : "+ mayor );
                Console.Write(" : posicion : " + posicion );

            
    }
  }
}
