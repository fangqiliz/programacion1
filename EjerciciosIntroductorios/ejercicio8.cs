// 8.    Leer un número entero de cinco dígitos y determinar si es un número Capicúa. 

//     Ej. 15651, 59895. 



using System;

class Ejercicio8
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese un número entero de cinco dígitos:");
        int numero = int.Parse(Console.ReadLine());

        string strNumero = numero.ToString();
        string strReverso = new string(strNumero.Reverse().ToArray());

        Console.WriteLine($"¿El número es capicúa? {strNumero == strReverso}");
    }
}
