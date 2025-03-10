using System;

public class Aguila : Ave
{
    public Aguila(string nombre, string color) : base(nombre, color, true)
    { }

    public void Cazar()
    {
        Console.WriteLine($"{Nombre} puede cazar.");
    }
}