using System;

class Persona
{
    public string Nombre { get; set; }

    public void Saludar()
    {
        Console.WriteLine("Hola mi nombre es:" + Nombre);
    }
}

class Estudiante : Persona
{
    public void Estudiar()
    {
        Console.WriteLine(Nombre + " esta estudiando Matematicas.");
    }
}

class Estudiante_universitario : Estudiante
{
    public void Asistir_clase()
    {
        Console.WriteLine(Nombre + " esta asistiendo a clase.");
    }
}
