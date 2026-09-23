using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor10000 = 0;
            int valor2000 = 0;
            int valor1000 = 0;
            int valor500 = 0;
            int valor200 = 0;
            int valor100 = 0;
            int valor50 = 0;
            int valor20 = 0;
            int valor10 = 0;

            int montototal;
            int dineroentregado;
            int vuelto;

            Console.Write("Monto total de la compra : ");
            montototal = int.Parse(Console.ReadLine());
            Console.Write("Dinero entregado : ");
            dineroentregado = int.Parse(Console.ReadLine());
            vuelto = dineroentregado - montototal;
   
            while (vuelto >= 10000)
            {
                valor10000 = valor10000 + 1;
                vuelto = vuelto - 10000;

            }
            while (vuelto >= 2000)
            {
                valor2000 = valor2000 + 1;
                vuelto = vuelto - 2000;

            }
            while (vuelto >= 1000)
            {
                valor1000 = valor1000 + 1;
                vuelto = vuelto - 1000;

            }
            while (vuelto >= 500)
            {
                valor500 = valor500 + 1;
                vuelto = vuelto - 500;
            }
            while (vuelto >= 200)
            {
                valor200 = valor200 + 1;
                vuelto = vuelto - 200;

            }
            while (vuelto >= 100)
            {
                valor100 = valor100 + 1;
                vuelto = vuelto - 100;
            }
            while (vuelto >= 50)
            {
                valor50 = valor50 + 1;
                vuelto = vuelto - 50;
            }
            while (vuelto >= 20)
            {
                valor20 += 1;
                vuelto -= 20;

            }
            while (vuelto >= 10)

            {
                valor10 += 1;
                vuelto -= 10;
            }
            Console.WriteLine("Billetes de 10000 : " + valor10000);
            Console.WriteLine("Billetes de 2000 : " + valor2000);
            Console.WriteLine("Billetes de 1000 : " + valor1000);
            Console.WriteLine("Billetes de 500 : " + valor500);
            Console.WriteLine("Billetes de 200 : " + valor200);
            Console.WriteLine("Billetes de 100 : " + valor100);
            Console.WriteLine("Billetes de 50 : " + valor50);
            Console.WriteLine("Billetes de 20 : " + valor20);
            Console.WriteLine("Billetes de 10 : " + valor10);
            Console.ReadKey();

        }
    }
}
