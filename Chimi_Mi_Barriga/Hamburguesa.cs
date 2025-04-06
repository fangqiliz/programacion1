using System;
using System.Collections.Generic;

public class Ingrediente
{
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Ingrediente(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

public class Hamburguesa
{
    protected string TipoPan;
    protected string TipoCarne;
    protected double PrecioBase;
    protected List<Ingrediente> IngredientesAdicionales;

    public Hamburguesa(string tipoPan, string tipoCarne, double precioBase)
    {
        TipoPan = tipoPan;
        TipoCarne = tipoCarne;
        PrecioBase = precioBase;
        IngredientesAdicionales = new List<Ingrediente>();
    }

    public virtual bool agregarIngrediente(Ingrediente ingrediente)
    {
        if (IngredientesAdicionales.Count < 4)
        {
            IngredientesAdicionales.Add(ingrediente);
            return true;
        }
        Console.WriteLine("No se puede agregar mas de 4 ingredientes adicionales.");
        return false;

    }

    public virtual void MostrarDetalle()
    {
        Console.WriteLine($"Hamburguesa Clasica con {TipoPan}, Carne {TipoCarne}");
        Console.WriteLine($"Precio Base: RD$ {PrecioBase}");

        double total = PrecioBase;
        foreach (var ing in IngredientesAdicionales)
        {
            Console.WriteLine($" + {ing.Nombre}: RD$ {ing.Precio:F2}");
            total += ing.Precio;
        }
        Console.WriteLine($"Total: RD${total:F2}\n");
    }
}
