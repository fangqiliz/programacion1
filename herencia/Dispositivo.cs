using System;

interface IDispositivo
{
    void Encender();
}

interface IConectar
{
    void conectar_Internet();
}
class Television : IDispositivo, IConectar
{
    public void Encender()
    {
        Console.WriteLine("la television esta encendido.");
    }
    public void conectar_Internet()
    {
        Console.WriteLine("La television se conecto a Internet.");
    }
}