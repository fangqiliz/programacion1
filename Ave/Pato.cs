using System;

public class Pato : Ave
{
    public Pato(string nombre, string color) : base(nombre, color, true)
    { }

    public void Nadar()
    {
        Console.WriteLine($"{Nombre} puede Nadar.");
    }
}