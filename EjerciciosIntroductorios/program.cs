// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("Seleccione un ejercicio (1-10) o 0 para salir:");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Ejercicio1.Ejecutar();
                    break;
                case 2:
                    Ejercicio2.Ejecutar();
                    break;
                case 3:
                    Ejercicio3.Ejecutar();
                    break;
                case 4:
                    Ejercicio4.Ejecutar();
                    break;
                case 5:
                    Ejercicio5.Ejecutar();
                    break;
                case 6:
                    Ejercicio6.Ejecutar();
                    break;
                case 7:
                    Ejercicio7.Ejecutar();
                    break;
                case 8:
                    Ejercicio8.Ejecutar();
                    break;
                case 9:
                    Ejercicio9.Ejecutar();
                    break;
                case 10:
                    Ejercicio10.Ejecutar();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine();
        }
    }
