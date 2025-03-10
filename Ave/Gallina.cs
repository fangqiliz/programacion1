using System;

public class Gallina : Ave
{
    public Gallina(string nombre, string color) : base(nombre, color, true)
    { }

    public void PonerHuevo()
    {
        Console.WriteLine($"{Nombre} puede poner huevo.");
    }
}