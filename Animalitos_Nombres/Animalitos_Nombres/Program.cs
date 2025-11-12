using Bilbioteca_oficial_animalitos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalitos_Nombres
{

        class Program

        {

            static void Main(string[] args)

            {

                Mascotas misMascotas = new Mascotas();

                int opcion;



                do

                {
                Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("_________MENÚ DE MASCOTAS_______");
                Console.ResetColor();

                    Console.WriteLine("[1] Insertar mascota");

                    Console.WriteLine("[2] Mostrar mascotas");

                    Console.WriteLine("[3] Ordenar (burbuja)");

                    Console.WriteLine("[4] Salir");

                 Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Elija una opción: ");
                Console.ResetColor();


                    int.TryParse(Console.ReadLine(), out opcion);

                    Console.WriteLine();
                Console.Clear();
              
                    switch (opcion)

                    {

                        case 1:

                            misMascotas.InsertarMascota();

                            break;

                        case 2:

                            misMascotas.MostrarMascotas();

                            break;

                        case 3:

                            misMascotas.OrdenarMascotas();

                            break;

                        case 4:

                            Console.WriteLine("Saliendo...");

                            break;

                        default:

                            Console.WriteLine("Opción no válida.");

                            break;

                    }





                } while (opcion != 0);

            }

        }

    }
    

