using System;
using System.Collections.Generic;

public class Centralita
{
    private List<Llamada> llamadas;
    private int cont;
    private double acum;

    public Centralita()
    {
        llamadas = new List<Llamada>();
        cont = 0;
        acum = 0;
    }

    public void RegistrarLlamada(Llamada llamada)
    {
        llamadas.Add(llamada);
        cont++;
        acum += llamada.CalcularPrecio();
        Console.WriteLine("Llamada registrada: " + llamada);

    }

    public int GetTotalLlamada()
    {
        return cont;
    }

    public double GetTotalFacturado()
    {
        return acum;
    }
}