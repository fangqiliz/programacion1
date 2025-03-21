using System;
using System.Collections.Generic;

public class Autobus
{
    public string Nombre { get; set; }
    public int Capacidad { get; set; }
    public int PasajerosActuales { get; set; }
    public decimal PrecioPasaje { get; set; }
    public decimal VentasTotales { get; set; }

    public Autobus(string nombre, int capacidad, int precioPasaje)
    {
        Nombre = nombre;
        Capacidad = capacidad;
        PasajerosActuales = 0;
        PrecioPasaje = precioPasaje;
        VentasTotales = 0;

    }


    public void CobrarPasaje(int CantidadPasajeros)
    {
        if (PasajerosActuales + CantidadPasajeros <= Capacidad)
        {
            PasajerosActuales += CantidadPasajeros;
            VentasTotales += CantidadPasajeros * PrecioPasaje;
            Console.WriteLine($"{CantidadPasajeros} pasajeros subieron al {Nombre}. Ventas {VentasTotales}, quedan {Capacidad - PasajerosActuales}. ");
        }
        else
        {
            Console.WriteLine($"No hay suficientes asientos en el {Nombre}. Solo hay {Capacidad - PasajerosActuales} asientos disponibles.");
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {

        Autobus autobusPlatinum = new Autobus("Autobús Platinum", 22, 1000);
        Autobus autobusGold = new Autobus("Autobús Gold", 15, 1500);


        autobusPlatinum.CobrarPasaje(5);
        autobusGold.CobrarPasaje(3);


        Console.WriteLine($"Auto Bus {autobusPlatinum.Nombre} {autobusPlatinum.PasajerosActuales} Pasajeros Ventas {autobusPlatinum.VentasTotales} quedan {autobusPlatinum.Capacidad - autobusPlatinum.PasajerosActuales} asientos disponibles.");
        Console.WriteLine($"Auto Bus {autobusGold.Nombre} {autobusGold.PasajerosActuales} Pasajeros Ventas {autobusGold.VentasTotales} quedan {autobusGold.Capacidad - autobusGold.PasajerosActuales} asientos disponibles.");
    }
}
