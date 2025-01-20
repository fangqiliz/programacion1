// 10. Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 
//entonces mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números leídos.


using System;

class Ejercicio10
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese el primer número:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        int diferencia = Math.Abs(numero1 - numero2);

        if (diferencia <= 10)
        {
            int menor = Math.Min(numero1, numero2);
            int mayor = Math.Max(numero1, numero2);

            Console.WriteLine("Los números entre los dos ingresados son:");
            for (int i = menor; i <= mayor; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("La diferencia es mayor que 10.");
        }
    }
}
