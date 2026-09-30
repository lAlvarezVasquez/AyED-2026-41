using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelsiusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double centigrados ;
            double kelvin ;
            double farenheit ;
            Console.Write("Coloca un grado centigrado para pasarlo a kelvins y farenheits : ");
            centigrados = double.Parse(Console.ReadLine());
            kelvin = centigrados + 273.15;
            farenheit = (centigrados * 1.8) + 32;
            Console.WriteLine("Los centigrados pasados a kelvin son : " + kelvin);
            Console.Write("Los centigrados pasados a farenheit son :" + farenheit);
            Console.ReadKey() ; 
        }
    }
}
