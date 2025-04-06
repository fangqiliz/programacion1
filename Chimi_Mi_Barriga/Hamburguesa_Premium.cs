using System;
using System.Collections.Generic;


public class HamburguesaPremium : Hamburguesa
{
    public HamburguesaPremium(string tipoPan, string tipoCarne, double precioBase)
        : base(tipoPan, tipoCarne, precioBase)
    {

        IngredientesAdicionales.Add(new Ingrediente("Papas fritas", 80));
        IngredientesAdicionales.Add(new Ingrediente("Bebida", 50));
    }

    public override bool agregarIngrediente(Ingrediente ingrediente)
    {
        Console.WriteLine("No se pueden agregar ingredientes adicionales a la hamburguesa premium.");
        return false;
    }

    public override void MostrarDetalle()
    {
        Console.WriteLine($"Hamburguesa Premium con pan {TipoPan}, carne {TipoCarne}");
        Console.WriteLine($"Precio base: RD${PrecioBase:F2}");

        double total = PrecioBase;
        foreach (var ing in IngredientesAdicionales)
        {
            Console.WriteLine($" + {ing.Nombre}: RD${ing.Precio:F2}");
            total += ing.Precio;
        }

        Console.WriteLine($"Total: RD${total:F2}\n");
    }
}