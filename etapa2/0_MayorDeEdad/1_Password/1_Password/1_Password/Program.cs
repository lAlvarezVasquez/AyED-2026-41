using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña;
            string contraseña2;
            string contraseña3;
            Console.Write("Ponga una contraseña : ");
            contraseña = Console.ReadLine();
            contraseña2 = contraseña.ToUpper();
            Console.Write("Verificar contraseña : ");
            contraseña3 = Console.ReadLine();
            contraseña3 = contraseña3.ToUpper();
            if (contraseña2==contraseña3)
            {
                Console.Write("La contraseña es correcta ");
                Console.ReadLine();

            }
            else
            {
                Console.Write("Contraseña incorrecta ");
                Console.ReadLine();

            }
            Console.ReadKey();
        }
    }
}
