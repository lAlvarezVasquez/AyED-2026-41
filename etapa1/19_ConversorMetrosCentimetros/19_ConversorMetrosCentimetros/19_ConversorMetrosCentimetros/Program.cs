using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            int centimetros;
            int milimetros;
            int Metros;
            Console.Write("Indica metros : ");
            Metros = int.Parse(Console.ReadLine());
            centimetros = Metros * 100;
            milimetros = Metros * 1000;
            Console.Write("Los metros pasados a centimetros son : " + centimetros +  " " +  "Y en milimetros es : " + milimetros);
            Console.ReadLine();
            Console.ReadKey();


        }
    }
}
