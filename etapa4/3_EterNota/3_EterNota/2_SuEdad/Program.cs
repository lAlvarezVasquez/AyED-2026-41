using System;

class Program
{
    const int MAX_REFUGIOS = 20;

    static void Main()
    {
        int[,] refugios = new int[MAX_REFUGIOS, 5];

        int cantidadRefugios = 0;
        int opcion;

        do
        {
            Console.Clear();

            MostrarMenu();

            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarRefugio(refugios, ref cantidadRefugios);
                    break;

                case 2:
                    MostrarTodos(refugios, cantidadRefugios);
                    break;

                case 3:
                    OcuparRefugio(refugios, cantidadRefugios);
                    break;

                case 4:
                    MostrarOcupados(refugios, cantidadRefugios);
                    break;

                case 5:
                    MostrarRefugiosConMasSuministros(refugios, cantidadRefugios);
                    break;

                case 6:
                    MostrarPromedioPorZona(refugios, cantidadRefugios);
                    break;

                case 7:
                    FiltrarPorZona(refugios, cantidadRefugios);
                    break;

                case 8:
                    Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            if (opcion != 8)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 8);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("MENÚ DEL ETERNOTA");
        Console.WriteLine("1. Agregar refugio");
        Console.WriteLine("2. Mostrar todos los refugios");
        Console.WriteLine("3. Ocupar refugio");
        Console.WriteLine("4. Mostrar ocupados");
        Console.WriteLine("5. Refugio con más suministros");
        Console.WriteLine("6. Promedio por zona");
        Console.WriteLine("7. Filtrar por zona");
        Console.WriteLine("8. Salir");
        Console.WriteLine();
    }

    static void AgregarRefugio(int[,] refugios, ref int cantidadRefugios)
    {
        if (cantidadRefugios >= MAX_REFUGIOS)
        {
            Console.WriteLine("No hay refugios... ¡Vamos a morir!");
            return;
        }

        int codigo;

        do
        {
            Console.Write("Ingrese el código del refugio: ");
            codigo = int.Parse(Console.ReadLine());

            if (CodigoExiste(refugios, cantidadRefugios, codigo))
            {
                Console.WriteLine("Ese código ya existe. Ingrese otro.");
            }

        } while (CodigoExiste(refugios, cantidadRefugios, codigo));

        int capacidad;

        do
        {
            Console.Write("Ingrese la capacidad máxima: ");
            capacidad = int.Parse(Console.ReadLine());

            if (capacidad <= 0)
            {
                Console.WriteLine("No se puede sobrevivir debiendo...");
            }

        } while (capacidad <= 0);

        int suministros;

        do
        {
            Console.Write("Ingrese los suministros disponibles: ");
            suministros = int.Parse(Console.ReadLine());

            if (suministros <= 0)
            {
                Console.WriteLine("No se puede sobrevivir debiendo...");
            }

        } while (suministros <= 0);

        int zona;

        do
        {
            Console.WriteLine("1 = NORTE (Congreso)");
            Console.WriteLine("2 = SUR (Constitución)");
            Console.WriteLine("3 = OESTE (Flores)");
            Console.WriteLine("4 = CENTRO (Microcentro)");

            Console.Write("Ingrese la zona: ");
            zona = int.Parse(Console.ReadLine());

            if (zona < 1 || zona > 4)
            {
                Console.WriteLine("Zona invàlida, esa parte ya està perdida");
            }

        } while (zona < 1 || zona > 4);

        refugios[cantidadRefugios, 0] = codigo;
        refugios[cantidadRefugios, 1] = capacidad;
        refugios[cantidadRefugios, 2] = suministros;
        refugios[cantidadRefugios, 3] = zona;
        refugios[cantidadRefugios, 4] = 0;

        cantidadRefugios++;

        Console.WriteLine("\nRefugio agregado correctamente.");
    }

    static bool CodigoExiste(int[,] refugios, int cantidadRefugios, int codigo)
    {
        for (int i = 0; i < cantidadRefugios; i++)
        {
            if (refugios[i, 0] == codigo)
            {
                return true;
            }
        }

        return false;
    }

    static void MostrarTodos(int[,] refugios, int cantidadRefugios)
    {
        if (cantidadRefugios == 0)
        {
            Console.WriteLine("No hay refugios registrados.");
            return;
        }

        Console.WriteLine("TODOS LOS REFUGIOS\n");

        for (int i = 0; i < cantidadRefugios; i++)
        {
            MostrarRefugio(refugios, i);
        }
    }

    static void MostrarRefugio(int[,] refugios, int fila)
    {
        Console.WriteLine("Código: " + refugios[fila, 0]);
        Console.WriteLine("Capacidad máxima: " + refugios[fila, 1]);
        Console.WriteLine("Suministros: " + refugios[fila, 2]);
        Console.WriteLine("Zona: " + NombreZona(refugios[fila, 3]));

        if (refugios[fila, 4] == 1)
        {
            Console.WriteLine("Ocupado: Sí");
        }
        else
        {
            Console.WriteLine("Ocupado: No");
        }

        Console.WriteLine("----------------------------");
    }

    static string NombreZona(int zona)
    {
        switch (zona)
        {
            case 1:
                return "NORTE (Congreso)";

            case 2:
                return "SUR (Constitución)";

            case 3:
                return "OESTE (Flores)";

            case 4:
                return "CENTRO (Microcentro)";

            default:
                return "Desconocida";
        }
    }

    static void OcuparRefugio(int[,] refugios, int cantidadRefugios)
    {
        if (cantidadRefugios == 0)
        {
            Console.WriteLine("No hay refugios registrados.");
            return;
        }

        Console.WriteLine("REFUGIOS DISPONIBLES\n");

        bool hayDisponibles = false;

        for (int i = 0; i < cantidadRefugios; i++)
        {
            if (refugios[i, 4] == 0)
            {
                Console.WriteLine(
                    "Código: " + refugios[i, 0] +
                    " | Capacidad: " + refugios[i, 1] +
                    " | Zona: " + NombreZona(refugios[i, 3])
                );

                hayDisponibles = true;
            }
        }

        if (!hayDisponibles)
        {
            Console.WriteLine("No hay refugios disponibles.");
            return;
        }

        int codigo;

        Console.Write("\nIngrese el código del refugio que desea ocupar: ");
        codigo = int.Parse(Console.ReadLine());

        int posicion = BuscarRefugio(refugios, cantidadRefugios, codigo);

        if (posicion == -1)
        {
            Console.WriteLine("No existe un refugio con ese código.");
            return;
        }

        if (refugios[posicion, 4] == 1)
        {
            Console.WriteLine("No somos Okupas, esto ya està ocupado");
            return;
        }

        refugios[posicion, 4] = 1;

        Console.WriteLine("Refugio ocupado correctamente.");
    }

    static int BuscarRefugio(int[,] refugios, int cantidadRefugios, int codigo)
    {
        for (int i = 0; i < cantidadRefugios; i++)
        {
            if (refugios[i, 0] == codigo)
            {
                return i;
            }
        }

        return -1;
    }

    static void MostrarOcupados(int[,] refugios, int cantidadRefugios)
    {
        bool hayOcupados = false;

        Console.WriteLine("REFUGIOS OCUPADOS\n");

        for (int i = 0; i < cantidadRefugios; i++)
        {
            if (refugios[i, 4] == 1)
            {
                MostrarRefugio(refugios, i);
                hayOcupados = true;
            }
        }

        if (!hayOcupados)
        {
            Console.WriteLine("No hay refugios ocupados.");
        }
    }

    static void MostrarRefugiosConMasSuministros(
        int[,] refugios,
        int cantidadRefugios)
    {
        if (cantidadRefugios == 0)
        {
            Console.WriteLine("No hay refugios registrados.");
            return;
        }

        int maxSuministros = refugios[0, 2];

        for (int i = 1; i < cantidadRefugios; i++)
        {
            if (refugios[i, 2] > maxSuministros)
            {
                maxSuministros = refugios[i, 2];
            }
        }

        int cantidadMaximos = 0;

        Console.WriteLine("REFUGIO(S) CON MÁS SUMINISTROS\n");

        for (int i = 0; i < cantidadRefugios; i++)
        {
            if (refugios[i, 2] == maxSuministros)
            {
                MostrarRefugio(refugios, i);
                cantidadMaximos++;
            }
        }

        if (cantidadMaximos > 1)
        {
            Console.WriteLine(
                "Hay varios refugios con la misma cantidad máxima de suministros."
            );
        }
    }

    static void MostrarPromedioPorZona(
        int[,] refugios,
        int cantidadRefugios)
    {
        Console.WriteLine("PROMEDIO DE CAPACIDAD POR ZONA\n");

        for (int zona = 1; zona <= 4; zona++)
        {
            int suma = 0;
            int cantidad = 0;

            for (int i = 0; i < cantidadRefugios; i++)
            {
                if (refugios[i, 3] == zona)
                {
                    suma += refugios[i, 1];
                    cantidad++;
                }
            }

            if (cantidad > 0)
            {
                double promedio = (double)suma / cantidad;

                Console.WriteLine(
                    NombreZona(zona) +
                    ": " +
                    promedio
                );
            }
            else
            {
                Console.WriteLine(
                    NombreZona(zona) +
                    ": No hay refugios registrados."
                );
            }
        }
    }

    static void FiltrarPorZona(
        int[,] refugios,
        int cantidadRefugios)
    {
        int zona;

        do
        {
            Console.Write("Ingrese una zona (1 a 4): ");
            zona = int.Parse(Console.ReadLine());

            if (zona < 1 || zona > 4)
            {
                Console.WriteLine(
                    "Zona invàlida, esa parte ya està perdida"
                );
            }

        } while (zona < 1 || zona > 4);

        bool encontrado = false;

        Console.WriteLine(
            "\nREFUGIOS DE " +
            NombreZona(zona) +
            "\n"
        );

        for (int i = 0; i < cantidadRefugios; i++)
        {
            if (refugios[i, 3] == zona)
            {
                MostrarRefugio(refugios, i);
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No hay refugios registrados en esta zona.");
        }
    }
}