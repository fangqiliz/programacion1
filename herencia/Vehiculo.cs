using System;

class Vehiculo
{
    public string Marca { get; set; }
    public void Arrancar()
    {
        Console.WriteLine("EL vehiculo ha arrancado.");
    }
}

class Coche : Vehiculo
{
    public int Num_Puertas { get; set; }

    public void TocarBocina()
    {
        Console.WriteLine("Bocina activado");
    }
}
