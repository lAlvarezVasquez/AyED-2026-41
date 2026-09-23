using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double Gineco;
            double dinero;
            double traumato;
            double pediatria;
            Console.Write("Indica la cantidad de dinero : ");
            dinero = double.Parse(Console.ReadLine());
            Gineco = (dinero * 40) / 100;
            traumato = (dinero * 30 / 100);
            pediatria = dinero * 30 / 100;
            Console.WriteLine("Gineco recibe : " + Gineco);
            Console.WriteLine("Traumato recibe : " + traumato);
            Console.Write("Pediatria recibe : " + pediatria);
            Console.ReadKey();

        }
    }
}
