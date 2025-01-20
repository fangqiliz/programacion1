// 4.    Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.

using System;

class Ejercicio4
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese el primer número de dos dígitos:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número de dos dígitos:");
        int numero2 = int.Parse(Console.ReadLine());

        int suma = numero1 + numero2;

        Console.WriteLine($"La suma de {numero1} y {numero2} es par: {suma % 2 == 0}");
    }
}
