// 3.    Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.

using System;

class Ejercicio3
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese un número entero de dos dígitos:");
        int numero = int.Parse(Console.ReadLine());

        int digito1 = Math.Abs(numero / 10);
        int digito2 = Math.Abs(numero % 10);

        bool digito1Primo = EsPrimo(digito1);
        bool digito2Primo = EsPrimo(digito2);

        Console.WriteLine($"¿Ambos dígitos son primos? {digito1Primo && digito2Primo}");
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
