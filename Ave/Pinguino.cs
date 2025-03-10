using System;

public class Pinguino : Ave
{
    public Pinguino(string nombre, string color) : base(nombre, color, false)
    { }
    public void Deslizarse()
    {
        Console.WriteLine($"{Nombre} puede deslizarse sobre hielo.");
    }
}