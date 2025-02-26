using System;

public class Motor
{
    private int litro_aceite;
    private int potencia;

    public Motor(int potencia)
    {
        this.potencia = potencia;
        this.litro_aceite = 0;
    }
    public int Litro_Aceite
    {
        get { return litro_aceite; }
        set { litro_aceite = value; }
    }
    public int Potencia
    {
        get { return potencia; }
        set { potencia = value; }
    }
}

public class Coche
{
    private Motor motor;
    private string marca;
    private string modelo;
    private double precioAverias;

    public Coche(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.precioAverias = 0;
        this.motor = new Motor(100);
    }

    public Motor Motor
    {
        get { return motor; }
    }
    public string Marca
    {
        get { return marca; }
    }
    public string Modelo
    {
        get { return modelo; }
    }
    public double PrecioAverias
    {
        get { return precioAverias; }
    }
    public void AcumularAveria(double importe)
    {
        precioAverias += importe;
    }

}

public class Garaje
{
    private Coche cocheAtendiendo;
    private string averiaAsociada;
    private int cocheAtendido;

    public Garaje()
    {
        cocheAtendiendo = null;
        averiaAsociada = string.Empty;
        cocheAtendido = 0;
    }
    public bool AceptarCoche(Coche coche, string averia)
    {
        if (cocheAtendiendo == null)
        {
            cocheAtendiendo = coche;
            averiaAsociada = averia;
            cocheAtendido++;
            return true;
        }
        return false;
    }
    public void DevolverCoche()
    {
        if (cocheAtendiendo != null)
        {
            Random rand = new Random();
            double importe = rand.Next(1, 100);
            cocheAtendiendo.AcumularAveria(importe);

            if (averiaAsociada == "aceite")
            {
                cocheAtendiendo.Motor.Litro_Aceite += 10;
            }

            cocheAtendiendo = null;
            averiaAsociada = string.Empty;
        }
    }
    public int CocheAtendido
    {
        get { return cocheAtendido; }
    }
}

public class PracticaPOO
{
    public static void Main(string[] args)
    {
        Garaje garaje = new Garaje();
        Coche coche1 = new Coche("Toyota", "Corolla");
        Coche coche2 = new Coche("Honda", "CRV");

        for (int i = 0; i < 2; i++)
        {
            if (garaje.AceptarCoche(coche1, "aceite"))
            {
                Console.WriteLine($"Coche {coche1.Marca} {coche1.Modelo} atendido.");
                garaje.DevolverCoche();
                Console.WriteLine($"Coche {coche1.Marca} {coche1.Modelo} devuelto.");
            }

            if (garaje.AceptarCoche(coche2, "frenos"))
            {
                Console.WriteLine($"Coche {coche2.Marca} {coche2.Modelo} atendido.");
                garaje.DevolverCoche();
                Console.WriteLine($"Coche {coche2.Marca} {coche2.Modelo} devuelto.");
            }
        }
        Console.WriteLine($"Coche 1: {coche1.Marca} {coche1.Modelo}, Precio de averias: {coche1.PrecioAverias}, Litros de aceite: {coche1.Motor.Litro_Aceite}");
        Console.WriteLine($"Coche 2: {coche2.Marca} {coche2.Modelo}, Precio de averías: {coche2.PrecioAverias}, Litros de aceite: {coche2.Motor.Litro_Aceite}");
        Console.WriteLine($"Total de coches atendidos en el garaje: {garaje.CocheAtendido}");

    }
}

