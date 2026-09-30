using System;

namespace _12_AvengersAir
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] asientos = new bool[80];

            for (int i = 0; i < asientos.Length; i++)
            {
                asientos[i] = true;
                //true = libre
                //false = ocupado
            }

            string[] asientos_nombre = new string[80];
            int[] asientos_edad = new int[80];
            int[] asientos_DNI = new int[80];
            string[] asientos_nacionalidad = new string[80];
            string[] asientos_estadoocupacion = new string[80];

            bool salir = false;

            while (salir == false)
            {
                Console.Clear();

                Console.WriteLine("0: Vender Asiento");
                Console.WriteLine("1: Devolver Asiento");
                Console.WriteLine("2: Modificar asiento");
                Console.WriteLine("3: Calcular ventas");
                Console.WriteLine("4: Buscar pasajeros por edad");
                Console.WriteLine("5: Obtener asientos con DNI par");
                Console.WriteLine("6: Salir");
                Console.Write("Introduzca una opción: ");

                int opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        Console.Clear();

                        for (int i = 0; i < asientos.Length; i++)
                        {
                            if (asientos[i])
                            {
                                Console.Write($"El asiento {i + 1} ");

                                if (i <= 19)
                                {
                                    Console.WriteLine("es de clase premium.");
                                }
                                else if (i >= 40 && i <= 44)
                                {
                                    Console.WriteLine("es un asiento de clase económica, de emergencia.");
                                }
                                else if (i >= 19)
                                {
                                    Console.WriteLine("es un asiento de clase regular.");
                                }
                            }
                        }

                        bool probar = true;

                        while (probar)
                        {
                            Console.Write("\n¿Qué asiento va a solicitar? ");
                            int asiento_solicitar = Convert.ToInt16(Console.ReadLine());

                            if (asiento_solicitar >= 1 && asiento_solicitar <= 80)
                            {
                                int posicion = asiento_solicitar - 1;

                                if (asientos[posicion] == false)
                                {
                                    Console.WriteLine("Asiento ya ocupado.");
                                }
                                else
                                {
                                    asientos[posicion] = false;

                                    Console.Write("Introduzca el nombre del usuario: ");
                                    asientos_nombre[posicion] = Console.ReadLine();

                                    Console.Write("Introduzca la edad del usuario: ");
                                    asientos_edad[posicion] = Convert.ToInt16(Console.ReadLine());

                                    Console.Write("Introduzca el DNI del usuario: ");
                                    asientos_DNI[posicion] = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Introduzca la nacionalidad del usuario: ");
                                    asientos_nacionalidad[posicion] = Console.ReadLine();

                                    Console.Write("Introduzca la ocupación del usuario: ");
                                    asientos_estadoocupacion[posicion] = Console.ReadLine();

                                    Console.WriteLine("Datos rellenados correctamente.");
                                    Console.WriteLine("Presione cualquier tecla para continuar.");
                                    Console.ReadKey();

                                    probar = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Número introducido inválido. Vuelva a intentarlo.");
                            }
                        }

                        break;

                    case 1:
                        probar = true;

                        while (probar)
                        {
                            Console.WriteLine("¿Qué asiento desea devolver?");
                            Console.WriteLine("(Si desea volver al menú, introduzca cero, ochenta o cualquier número negativo)");

                            int devolver = Convert.ToInt16(Console.ReadLine());

                            if (devolver >= 1 && devolver <= 80)
                            {
                                int posicion = devolver - 1;

                                if (asientos[posicion] == true)
                                {
                                    Console.WriteLine("El asiento seleccionado está libre, por ende, no se puede devolver.");
                                }
                                else
                                {
                                    Console.WriteLine("El asiento se ha vaciado.");

                                    asientos[posicion] = true;
                                    asientos_nombre[posicion] = "";
                                    asientos_edad[posicion] = 0;
                                    asientos_DNI[posicion] = 0;
                                    asientos_nacionalidad[posicion] = "";
                                    asientos_estadoocupacion[posicion] = "";
                                }
                            }
                            else
                            {
                                probar = false;
                            }
                        }

                        break;

                    case 2:
                        probar = true;

                        while (probar)
                        {
                            Console.Write("Introduzca el asiento a modificar su información (0, mayor a 80 o negativo para salir): ");
                            int eleccion = Convert.ToInt16(Console.ReadLine());

                            if (eleccion <= 0 || eleccion > 80)
                            {
                                probar = false;
                            }
                            else
                            {
                                int posicion = eleccion - 1;

                                if (asientos[posicion] == true)
                                {
                                    Console.WriteLine("El asiento introducido no está ocupado.");
                                }
                                else
                                {
                                    bool algo = true;

                                    while (algo)
                                    {
                                        Console.Clear();

                                        Console.WriteLine($"Nombre: {asientos_nombre[posicion]}");
                                        Console.WriteLine($"Edad: {asientos_edad[posicion]}");
                                        Console.WriteLine($"DNI: {asientos_DNI[posicion]}");
                                        Console.WriteLine($"Nacionalidad: {asientos_nacionalidad[posicion]}");
                                        Console.WriteLine($"Estado de ocupación: {asientos_estadoocupacion[posicion]}");

                                        Console.WriteLine();
                                        Console.WriteLine("0: Cambiar nombre");
                                        Console.WriteLine("1: Cambiar edad");
                                        Console.WriteLine("2: Cambiar DNI");
                                        Console.WriteLine("3: Cambiar nacionalidad");
                                        Console.WriteLine("4: Cambiar estado de ocupación");
                                        Console.WriteLine("5: Salir");

                                        Console.Write("Introduzca la opción: ");
                                        int cambiorealizar = Convert.ToInt16(Console.ReadLine());

                                        switch (cambiorealizar)
                                        {
                                            case 0:
                                                Console.Write("Introduzca el nuevo nombre: ");
                                                asientos_nombre[posicion] = Console.ReadLine();
                                                algo = false;
                                                break;

                                            case 1:
                                                Console.Write("Introduzca la nueva edad: ");
                                                asientos_edad[posicion] = Convert.ToInt16(Console.ReadLine());
                                                algo = false;
                                                break;

                                            case 2:
                                                Console.Write("Introduzca el nuevo DNI: ");
                                                asientos_DNI[posicion] = Convert.ToInt32(Console.ReadLine());
                                                algo = false;
                                                break;

                                            case 3:
                                                Console.Write("Introduzca la nueva nacionalidad: ");
                                                asientos_nacionalidad[posicion] = Console.ReadLine();
                                                algo = false;
                                                break;

                                            case 4:
                                                Console.Write("Introduzca el nuevo estado de ocupación: ");
                                                asientos_estadoocupacion[posicion] = Console.ReadLine();
                                                algo = false;
                                                break;

                                            case 5:
                                                algo = false;
                                                break;

                                            default:
                                                Console.WriteLine("Opción inválida.");
                                                Console.ReadKey();
                                                break;
                                        }
                                    }
                                }
                            }
                        }

                        break;

                    case 3:
                        int recaudacion = 0;

                        for (int i = 0; i < asientos.Length; i++)
                        {
                            if (asientos[i] == false)
                            {
                                if (i <= 19)
                                {
                                    recaudacion += 200;
                                }
                                else if (i >= 40 && i <= 44)
                                {
                                    recaudacion += 100;
                                }
                                else
                                {
                                    recaudacion += 80;
                                }
                            }
                        }

                        if (recaudacion > 0)
                        {
                            Console.WriteLine($"Se han recaudado ${recaudacion}.");
                        }
                        else
                        {
                            Console.WriteLine("No se ha recaudado nada.");
                        }

                        Console.WriteLine("Presione cualquier tecla para continuar.");
                        Console.ReadKey();

                        break;

                    case 4:
                        probar = true;

                        while (probar)
                        {
                            Console.Write("Introduzca una edad (introduzca un número negativo para salir): ");
                            int busqueda_edad = Convert.ToInt16(Console.ReadLine());

                            if (busqueda_edad < 0)
                            {
                                probar = false;
                            }
                            else
                            {
                                bool encontrado = false;

                                for (int i = 0; i < asientos.Length; i++)
                                {
                                    if (asientos[i] == false && asientos_edad[i] == busqueda_edad)
                                    {
                                        Console.WriteLine($"En el asiento {i + 1} hay una persona de {busqueda_edad} años.");
                                        encontrado = true;
                                    }
                                }

                                if (encontrado == false)
                                {
                                    Console.WriteLine("No se ha encontrado ningún sujeto con esa edad.");
                                }
                            }
                        }

                        break;

                    case 5:
                        bool dniparuno = false;

                        for (int i = 0; i < asientos.Length; i++)
                        {
                            int DNI_actual = asientos_DNI[i];

                            if (asientos[i] == false && DNI_actual != 0 && DNI_actual % 2 == 0)
                            {
                                Console.WriteLine($"En el asiento {i + 1} hay un sujeto con DNI par.");
                                dniparuno = true;
                            }
                        }

                        if (dniparuno == false)
                        {
                            Console.WriteLine("No se ha encontrado ningún sujeto con DNI par.");
                        }

                        Console.WriteLine("Presione cualquier tecla para continuar.");
                        Console.ReadKey();

                        break;

                    case 6:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción introducida no válida.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
