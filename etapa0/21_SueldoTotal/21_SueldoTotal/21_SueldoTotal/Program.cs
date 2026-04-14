using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            int HoraLaboral;
            int SalarioporHora;
            int SalarioTotal;
            Console.Write("Indica las horas de laburo : ");
            HoraLaboral = int.Parse(Console.ReadLine());
            Console.Write("Indica el salario por hora : ");
            SalarioporHora = int.Parse(Console.ReadLine());
            SalarioTotal = HoraLaboral * SalarioporHora;
            Console.Write("El salario total es : " + SalarioTotal);
            Console.ReadKey();


        }
    }
}
