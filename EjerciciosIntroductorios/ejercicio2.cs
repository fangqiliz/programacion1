// 2.    Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.

using System;

class Ejercicio2
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese un número entero de dos dígitos:");
        int numero = int.Parse(Console.ReadLine());

        bool esPrimo = EsPrimo(Math.Abs(numero));
        bool esNegativo = numero < 0;

        Console.WriteLine($"¿El número es primo? {esPrimo}");
        Console.WriteLine($"¿El número es negativo? {esNegativo}");
    }

    private static bool EsPrimo(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
