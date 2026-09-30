using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        int[,] misiones = new int[30, 5];

        int cantidadMisiones = 0;
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("MENÚ DEL P.E.R.O.");
            Console.WriteLine("1. Registrar nueva misión");
            Console.WriteLine("2. Ver todas las misiones");
            Console.WriteLine("3. Cambiar estado de una misión");
            Console.WriteLine("4. Listar misiones en curso");
            Console.WriteLine("5. Misión con más objetos a extraer");
            Console.WriteLine("6. Promedio de peligro por mapa");
            Console.WriteLine("7. Filtrar por mapa");
            Console.WriteLine("8. Salir");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    if (cantidadMisiones >= 30)
                    {
                        Console.WriteLine("¡Demasiadas misiones!");
                    }
                    else
                    {
                        bool datoValido = false;
                        int mapa = 0;
                        int peligro = 0;

                        while (!datoValido)
                        {
                            Console.Write("Ingrese el mapa (1-3): ");
                            mapa = int.Parse(Console.ReadLine());

                            if (mapa >= 1 && mapa <= 3)
                            {
                                datoValido = true;
                            }
                            else
                            {
                                Console.WriteLine("Ese mapa no es de este juegazo.");
                            }
                        }

                        datoValido = false;

                        while (!datoValido)
                        {
                            Console.Write("Ingrese el nivel de peligro (1-5): ");
                            peligro = int.Parse(Console.ReadLine());

                            if (peligro >= 1 && peligro <= 5)
                            {
                                datoValido = true;
                            }
                            else
                            {
                                Console.WriteLine("Este nivel es demasiado PEGRILOSO...");
                            }
                        }

                        misiones[cantidadMisiones, 0] = cantidadMisiones + 1;
                        misiones[cantidadMisiones, 1] = mapa;
                        misiones[cantidadMisiones, 2] = rand.Next(1, 71);
                        misiones[cantidadMisiones, 3] = peligro;
                        misiones[cantidadMisiones, 4] = 0;

                        cantidadMisiones++;

                        Console.WriteLine("Misión registrada correctamente.");
                    }

                    break;

                case 2:

                    if (cantidadMisiones == 0)
                    {
                        Console.WriteLine("No hay misiones cargadas.");
                    }
                    else
                    {
                        Console.WriteLine("TODAS LAS MISIONES");

                        for (int i = 0; i < cantidadMisiones; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine("ID: " + misiones[i, 0]);

                            Console.Write("Mapa: ");

                            if (misiones[i, 1] == 1)
                            {
                                Console.WriteLine("Hagwarts");
                            }
                            else if (misiones[i, 1] == 2)
                            {
                                Console.WriteLine("La Casa del Viejo");
                            }
                            else
                            {
                                Console.WriteLine("El Laboratorio");
                            }

                            Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                            Console.WriteLine("Nivel de peligro: " + misiones[i, 3]);

                            Console.Write("Estado: ");

                            if (misiones[i, 4] == 0)
                            {
                                Console.WriteLine("Pendiente");
                            }
                            else if (misiones[i, 4] == 1)
                            {
                                Console.WriteLine("En Curso");
                            }
                            else
                            {
                                Console.WriteLine("Finalizado");
                            }
                        }
                    }

                    break;

                case 3:

                    if (cantidadMisiones == 0)
                    {
                        Console.WriteLine("No hay misiones cargadas.");
                    }
                    else
                    {
                        int idBuscado;
                        int posicion = -1;

                        Console.Write("Ingrese el ID de la misión: ");
                        idBuscado = int.Parse(Console.ReadLine());

                        for (int i = 0; i < cantidadMisiones; i++)
                        {
                            if (misiones[i, 0] == idBuscado)
                            {
                                posicion = i;
                            }
                        }

                        if (posicion == -1)
                        {
                            Console.WriteLine("No existe una misión con ese ID.");
                        }
                        else
                        {
                            if (misiones[posicion, 4] == 0)
                            {
                                misiones[posicion, 4] = 1;
                                Console.WriteLine("La misión ahora está En Curso.");
                            }
                            else if (misiones[posicion, 4] == 1)
                            {
                                misiones[posicion, 4] = 2;
                                Console.WriteLine("La misión ahora está Finalizada.");
                            }
                            else
                            {
                                Console.WriteLine("La misión ya está Finalizada.");
                            }
                        }
                    }

                    break;

                case 4:

                    bool hayEnCurso = false;

                    Console.WriteLine("MISIONES EN CURSO");

                    for (int i = 0; i < cantidadMisiones; i++)
                    {
                        if (misiones[i, 4] == 1)
                        {
                            hayEnCurso = true;

                            Console.WriteLine();
                            Console.WriteLine("ID: " + misiones[i, 0]);

                            Console.Write("Mapa: ");

                            if (misiones[i, 1] == 1)
                            {
                                Console.WriteLine("Hagwarts");
                            }
                            else if (misiones[i, 1] == 2)
                            {
                                Console.WriteLine("La Casa del Viejo");
                            }
                            else
                            {
                                Console.WriteLine("El Laboratorio");
                            }

                            Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                            Console.WriteLine("Nivel de peligro: " + misiones[i, 3]);
                            Console.WriteLine("Estado: En Curso");
                        }
                    }

                    if (!hayEnCurso)
                    {
                        Console.WriteLine("No hay misiones en curso.");
                    }

                    break;

                case 5:

                    if (cantidadMisiones == 0)
                    {
                        Console.WriteLine("No hay misiones cargadas.");
                    }
                    else
                    {
                        int mayorCantidad = misiones[0, 2];

                        for (int i = 1; i < cantidadMisiones; i++)
                        {
                            if (misiones[i, 2] > mayorCantidad)
                            {
                                mayorCantidad = misiones[i, 2];
                            }
                        }

                        Console.WriteLine("MISIONES CON MÁS OBJETOS");
                        Console.WriteLine("Cantidad máxima de objetos: " + mayorCantidad);

                        for (int i = 0; i < cantidadMisiones; i++)
                        {
                            if (misiones[i, 2] == mayorCantidad)
                            {
                                Console.WriteLine();
                                Console.WriteLine("ID: " + misiones[i, 0]);

                                Console.Write("Mapa: ");

                                if (misiones[i, 1] == 1)
                                {
                                    Console.WriteLine("Hagwarts");
                                }
                                else if (misiones[i, 1] == 2)
                                {
                                    Console.WriteLine("La Casa del Viejo");
                                }
                                else
                                {
                                    Console.WriteLine("El Laboratorio");
                                }

                                Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                                Console.WriteLine("Nivel de peligro: " + misiones[i, 3]);

                                Console.Write("Estado: ");

                                if (misiones[i, 4] == 0)
                                {
                                    Console.WriteLine("Pendiente");
                                }
                                else if (misiones[i, 4] == 1)
                                {
                                    Console.WriteLine("En Curso");
                                }
                                else
                                {
                                    Console.WriteLine("Finalizado");
                                }
                            }
                        }
                    }

                    break;

                case 6:

                    int sumaMapa1 = 0;
                    int sumaMapa2 = 0;
                    int sumaMapa3 = 0;

                    int cantidadMapa1 = 0;
                    int cantidadMapa2 = 0;
                    int cantidadMapa3 = 0;

                    for (int i = 0; i < cantidadMisiones; i++)
                    {
                        if (misiones[i, 1] == 1)
                        {
                            sumaMapa1 += misiones[i, 3];
                            cantidadMapa1++;
                        }
                        else if (misiones[i, 1] == 2)
                        {
                            sumaMapa2 += misiones[i, 3];
                            cantidadMapa2++;
                        }
                        else if (misiones[i, 1] == 3)
                        {
                            sumaMapa3 += misiones[i, 3];
                            cantidadMapa3++;
                        }
                    }

                    Console.WriteLine("PROMEDIO DE PELIGRO POR MAPA");

                    if (cantidadMapa1 > 0)
                    {
                        Console.WriteLine(
                            "Hagwarts: " +
                            ((double)sumaMapa1 / cantidadMapa1)
                        );
                    }
                    else
                    {
                        Console.WriteLine("Hagwarts: No hay misiones.");
                    }

                    if (cantidadMapa2 > 0)
                    {
                        Console.WriteLine(
                            "La Casa del Viejo: " +
                            ((double)sumaMapa2 / cantidadMapa2)
                        );
                    }
                    else
                    {
                        Console.WriteLine("La Casa del Viejo: No hay misiones.");
                    }

                    if (cantidadMapa3 > 0)
                    {
                        Console.WriteLine(
                            "El Laboratorio: " +
                            ((double)sumaMapa3 / cantidadMapa3)
                        );
                    }
                    else
                    {
                        Console.WriteLine("El Laboratorio: No hay misiones.");
                    }

                    break;

                case 7:

                    bool mapaValido = false;
                    int mapaFiltro = 0;

                    while (!mapaValido)
                    {
                        Console.Write("Ingrese el mapa que desea consultar (1-3): ");
                        mapaFiltro = int.Parse(Console.ReadLine());

                        if (mapaFiltro >= 1 && mapaFiltro <= 3)
                        {
                            mapaValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Ese mapa no es de este juegazo.");
                        }
                    }

                    bool hayMisiones = false;

                    Console.WriteLine("MISIONES DEL MAPA " + mapaFiltro);

                    for (int i = 0; i < cantidadMisiones; i++)
                    {
                        if (misiones[i, 1] == mapaFiltro)
                        {
                            hayMisiones = true;

                            Console.WriteLine();
                            Console.WriteLine("ID: " + misiones[i, 0]);
                            Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                            Console.WriteLine("Nivel de peligro: " + misiones[i, 3]);

                            Console.Write("Estado: ");

                            if (misiones[i, 4] == 0)
                            {
                                Console.WriteLine("Pendiente");
                            }
                            else if (misiones[i, 4] == 1)
                            {
                                Console.WriteLine("En Curso");
                            }
                            else
                            {
                                Console.WriteLine("Finalizado");
                            }
                        }
                    }

                    if (!hayMisiones)
                    {
                        Console.WriteLine("No hay misiones registradas en este mapa.");
                    }

                    break;

                case 8:

                    Console.WriteLine(
                        "Saliendo del sistema... ¡Esperemos que el PERO no sea letal!"
                    );

                    break;

                default:

                    Console.WriteLine("Opción no válida. Intente de nuevo.");

                    break;
            }

            if (opcion != 8)
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 8);
    }
}