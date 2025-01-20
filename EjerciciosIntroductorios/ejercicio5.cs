// 5.    Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.



using System;

class Ejercicio5
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese un número entero de tres dígitos:");
        int numero = int.Parse(Console.ReadLine());

        int digito1 = Math.Abs(numero / 100);
        int digito2 = Math.Abs((numero / 10) % 10);
        int digito3 = Math.Abs(numero % 10);

        int mayor = Math.Max(digito1, Math.Max(digito2, digito3));

        if (mayor == digito1)
            Console.WriteLine("El mayor dígito está en la primera posición.");
        else if (mayor == digito2)
            Console.WriteLine("El mayor dígito está en la segunda posición.");
        else
            Console.WriteLine("El mayor dígito está en la tercera posición.");
    }
}
