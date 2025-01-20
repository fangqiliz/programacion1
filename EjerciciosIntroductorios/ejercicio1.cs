using System;
// 1.    Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.
class Ejercicio1
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese un número entero de dos dígitos:");
        int numero = int.Parse(Console.ReadLine());

        int digito1 = numero / 10;
        int digito2 = numero % 10;
        int suma = digito1 + digito2;

        Console.WriteLine($"La suma de los dígitos de {numero} es: {suma}");
    }
}
