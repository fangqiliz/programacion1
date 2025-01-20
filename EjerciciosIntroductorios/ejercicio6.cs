// 6.    Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.


using System;

class Ejercicio6
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese un número entero de tres dígitos:");
        int numero = int.Parse(Console.ReadLine());

        int digito1 = Math.Abs(numero / 100);
        int digito2 = Math.Abs((numero / 10) % 10);
        int digito3 = Math.Abs(numero % 10);

        bool multiplo = digito1 % digito2 == 0 || digito2 % digito3 == 0 || digito3 % digito1 == 0;

        Console.WriteLine($"¿Algún dígito es múltiplo de los otros? {multiplo}");
    }
}
