// 7.    Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.


using System;

class Ejercicio7
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese el primer número:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        int c = int.Parse(Console.ReadLine());

        a = Math.Max(a, b);
        a = Math.Max(a, c);

        Console.WriteLine($"El mayor de los tres números es: {a}");
    }
}
