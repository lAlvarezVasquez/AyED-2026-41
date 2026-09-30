using System;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la cantidad de productos vendidos durante el Hot Sale: ");
            int cant_hot_sale = Convert.ToInt16(Console.ReadLine());
            double precio_alto = 0;
            double precio_bajo = double.MaxValue;
            double precio_actual = 0;
            for (int i = 0; i < cant_hot_sale; i++)
            {
                Console.Write("Introduzca el precio de algun producto: ");
                precio_actual = Convert.ToDouble(Console.ReadLine());
                if (precio_actual > precio_alto)
                    precio_alto = precio_actual;
                if (precio_actual < precio_bajo)
                    precio_bajo = precio_actual;
            
            }
            Console.WriteLine($"Precio mas bajo: {precio_bajo}");
            Console.Write($"Precio mas alto: {precio_alto}");


            Console.ReadKey();
        }
    }
}
