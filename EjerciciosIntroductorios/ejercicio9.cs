// 9.    Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.


using System;

class Ejercicio9
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese un número entero de cuatro dígitos:");
        string numero = Console.ReadLine();

        bool esIgual = numero[1] == numero[2];

        Console.WriteLine($"¿El segundo dígito es igual al penúltimo? {esIgual}");
    }
}
