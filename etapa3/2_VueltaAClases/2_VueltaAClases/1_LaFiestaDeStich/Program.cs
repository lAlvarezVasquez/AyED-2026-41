using System;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la cantidad de TPs: ");
            int cant_tps = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la cantidad de examenes: ");
            int cant_examenes = Convert.ToInt32(Console.ReadLine());
            double promedio_examenes = 0;
            for (int i = 0; i < cant_examenes; i++)
            {

                Console.Write($"Introduzca la nota del examen numero {i + 1}: ");
                promedio_examenes = promedio_examenes + Convert.ToInt32(Console.ReadLine());
            }
            promedio_examenes = promedio_examenes / cant_examenes;
            int tps_aprobados = 0;
            for (int i = 0; i < cant_tps; i++)
            {
                Console.Write($"Introduzca la nota del TP numero {i + 1}: ");
                int notaTp = Convert.ToInt32(Console.ReadLine());
                if (notaTp >= 6)
                    tps_aprobados++;
            }
            if (tps_aprobados < (cant_tps * 0.75))
            {
                Console.WriteLine("Ustedes no pueden aprobar las materia");
            }
            else if (promedio_examenes <= 5)
                Console.WriteLine("Ustedes no pueden aprobar la materia");
            else
                Console.WriteLine("Ustedes aprobaron la materia");

            Console.ReadKey();
        }
    }
}
