using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoyos_Yrigoyn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bienvenido a entrada de datos
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("---CALCULADORA INTELIGENTE DE PROMEDIOS---");

            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            float nota1, nota2, nota3, promedio;

            Console.WriteLine("Ingrese la primera nota:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota:");
            nota3 = float.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("El promedio de " + nombre + " es: " + promedio);

            Console.ReadKey();

            //Parte 2: Estructuras Condicionales (Simple, Doble, Múltiple)_Evaluación condicional

            float promedio1;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("---Evaluación de notas---");

            Console.WriteLine("Ingrese su calificacion:");
            promedio1= float.Parse(Console.ReadLine());

            if (promedio1 >= 13)

            Console.WriteLine("Aprobado");

            else
                Console.WriteLine("Reprobado");

            Console.ReadKey();

            //# Selección múltiple con elif
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---Tercer apartado---");
            

            int calificacion;
            Console.WriteLine("---Evaluación de notas con selección múltiple---");

            Console.WriteLine("Ingrese su calificación:");

            calificacion = int.Parse(Console.ReadLine());

            if (calificacion >= 18)
                Console.WriteLine("Excelente");
            else if (calificacion >= 15)
                Console.WriteLine("Bueno");
            else if (calificacion >= 13)
                Console.WriteLine("Regular");
            else
                Console.WriteLine("Deficiente");

            Console.WriteLine($"Calificacion{calificacion}");

            Console.ReadKey();








        }
    }
}
