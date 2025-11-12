using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilbioteca_oficial_animalitos
{

    public class Mascotas

    {

        private List<string> listaMascotas = new List<string>();



        public void InsertarMascota()

        {
            Console.WriteLine("Ingrese la cantidad de mascotas que va a ingresar");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
              

            for (int i = 0; i< cantidad; i++)
            {
                Console.Write("Ingrese el nombre de la mascota: ");

                string nombre = Console.ReadLine();

                listaMascotas.Add(nombre);
            }


            

            Console.WriteLine("Mascota agregada correctamente.");

        }


        public void MostrarMascotas()

        {

            if (listaMascotas.Count == 0)

            {

                Console.WriteLine("No hay mascotas registradas.");

                return;

            }



            Console.WriteLine("Lista de mascotas:");

            for (int i = 0; i < listaMascotas.Count; i++)

            {

                Console.WriteLine("- " + listaMascotas[i]);

            }

            Console.WriteLine();

        }

        public void OrdenarMascotas()

        {

            int n = listaMascotas.Count;

            if (n <= 1)

            {

                Console.WriteLine("No hay suficientes mascotas para ordenar");

                return;

            }



            for (int i = 0; i < n - 1; i++)

            {

                for (int j = 0; j < n - i - 1; j++)

                {

                    if (string.Compare(listaMascotas[j], listaMascotas[j + 1]) > 0)

                    {

                        string temp = listaMascotas[j];

                        listaMascotas[j] = listaMascotas[j + 1];

                        listaMascotas[j + 1] = temp;

                    }

                }

            }



            Console.WriteLine("Lista de mascotas ordenada correctamente.");
        }
    }
}




