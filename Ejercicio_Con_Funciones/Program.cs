// See https://aka.ms/new-console-template for more information

//  determinar si un año es bisiesto.

using System;

class Program
{

    static void Main()
    {

        Console.WriteLine("Introduce el año: ");
        int year = int.Parse(Console.ReadLine());

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine("El año es bisiesto.", year);
        }
        else
        {
            Console.WriteLine("El año no es bisiesto.", year);
        }
        Console.ReadKey();


    }
}


