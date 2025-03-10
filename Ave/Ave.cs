using System;

public class Ave
{
    public string Nombre { get; set; }
    public string Color { get; set; }
    public bool PuedeVolar { get; set; }
    public Ave(string nombre, string color, bool puedeVolar)
    {
        Nombre = nombre;
        Color = color;
        PuedeVolar = puedeVolar;
    }

    public virtual void Volar()
    {
        if (PuedeVolar)
        {
            Console.WriteLine($"{Nombre} puede volar.");
        }
        else
        {
            Console.WriteLine($"{Nombre} no puede volar.");
        }
    }

}