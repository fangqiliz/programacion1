using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[6];
        int opcion;

        Console.WriteLine("Ingrese 6 numeros enteros: ");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        do
        {
            Console.WriteLine("\nseleccione una opcion: ");
            Console.WriteLine("1. Determinar la posicion del mayor numero leido. ");
            Console.WriteLine("2. Determinar la posicion del mayor numero par leido. ");
            Console.WriteLine("3. Determinar la posicion del mayor numero primo leido. ");
            Console.WriteLine("4. Determinar las posiciones de los numeros con mas de 3 digitos. ");
            Console.WriteLine("5. Calcular el promedio entero de los datos del arreglo. ");
            Console.WriteLine("6. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    PosicionMayorNumero(numeros);
                    break;
                case 2:
                    PosicionMayorPar(numeros);
                    break;
                case 3:
                    PosicionMayorPrimo(numeros);
                    break;
                case 4:
                    posicionTresDigitos(numeros);
                    break;
                case 5:
                    PromedioEntero(numeros);
                    break;

                case 6:
                    Console.WriteLine("Saliendo...");
                    break;

            }
        } while (opcion != 6);
    }

    static void PosicionMayorNumero(int[] arr)
    {
        int mayor = arr.Max();
        int posicion = Array.IndexOf(arr, mayor);
        Console.WriteLine($"EL mayor numero es {mayor} y esta en la posicion {posicion}");

    }
    static void PosicionMayorPar(int[] arr)
    {
        int[] pares = arr.Where(n => n % 2 == 0).ToArray();
        if (pares.Length == 0)
        {
            Console.WriteLine("No hay numeros pares");
            return;
        }
        int mayorPar = pares.Max();
        int posicion = Array.IndexOf(arr, mayorPar);
        Console.WriteLine($"El mayor numero par es {mayorPar} y esta en la posicion {posicion}");
    }

    static void PosicionMayorPrimo(int[] arr)
    {
        int[] primos = arr.Where(n => EsPrimo(n)).ToArray();
        if (primos.Length == 0)
        {
            Console.WriteLine("No hay números primos.");
            return;
        }
        int mayorPrimo = primos.Max();
        int posicion = Array.IndexOf(arr, mayorPrimo);
        Console.WriteLine($"El mayor número primo es {mayorPrimo} y está en la posición {posicion}.");
    }

    static void posicionTresDigitos(int[] arr)
    {
        Console.WriteLine("Posiciones de los números con más de 3 dígitos:");
        for (int i = 0; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > 999)
            {
                Console.WriteLine($"numero: {arr[i]}, posicion: {i}");
            }
        }
    }
    static void PromedioEntero(int[] arr)
    {
        int promedio = (int)arr.Average();
        Console.WriteLine($"El promedio entero de los datos es {promedio}.");
    }


    static bool EsPrimo(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

}

