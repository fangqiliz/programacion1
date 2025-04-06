using System;
using System.Collections.Generic;

public class HamburguesaSaludable : Hamburguesa
{
    private List<Ingrediente> IngredientesSaludables;
    public HamburguesaSaludable(string tipoCarne, double precioBase) : base("Pan Integral", tipoCarne, precioBase)
    {
        IngredientesSaludables = new List<Ingrediente>();

    }
    public override bool agregarIngrediente(Ingrediente ingrediente)
    {
        if (IngredientesAdicionales.Count + IngredientesSaludables.Count < 6)
        {
            IngredientesSaludables.Add(ingrediente);
            return true;
        }
        Console.WriteLine("No se puede agregar mas de 6 ingredientes en total. ");
        return false;
    }

    public override void MostrarDetalle()
    {
        Console.WriteLine($"Hamburguesa Saludable con pan {TipoPan}, carne {TipoCarne}");
        Console.WriteLine($"Precio base: RD${PrecioBase:F2}");

        double total = PrecioBase;
        foreach (var ing in IngredientesAdicionales)
        {
            Console.WriteLine($" + {ing.Nombre}: RD${ing.Precio:F2}");
            total += ing.Precio;
        }

        foreach (var ing in IngredientesSaludables)
        {
            Console.WriteLine($" + {ing.Nombre} (Saludable): RD${ing.Precio:F2}");
            total += ing.Precio;
        }

        Console.WriteLine($"Total: RD${total:F2}\n");
    }
}

