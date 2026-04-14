using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio ;
            double pi ;
            double volumen ;
            double superficie;
            pi = 3.14159265;
            Console.Write("Coloque un radio para una esfera : ");
            radio = double.Parse(Console.ReadLine());
            superficie = 4 * pi * Math.Pow(radio , 2);
            volumen =  4/3 * pi *  Math.Pow(radio, 3);
            Console.WriteLine("La superficie es : " + superficie);
            Console.Write("El volumen es :" + volumen);
            Console.ReadKey();



      
        }
    }
}
