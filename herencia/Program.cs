using System;

Coche MiCoche = new Coche();
MiCoche.Marca = "Toyota";
MiCoche.Num_Puertas = 4;
Console.WriteLine("Marca:" + MiCoche.Marca);
Console.WriteLine("numero de puertas:" + MiCoche.Num_Puertas);
MiCoche.Arrancar();
MiCoche.TocarBocina();
Console.WriteLine("");

Animal miPerro = new Perro();
miPerro.HacerSonido();

Console.WriteLine("");
Television MiTelevision = new Television();
MiTelevision.Encender();
MiTelevision.conectar_Internet();

Console.WriteLine("");
Estudiante_universitario estudiante = new Estudiante_universitario();
estudiante.Nombre = "Juan";
estudiante.Saludar();
estudiante.Estudiar();
estudiante.Asistir_clase();

Console.WriteLine("");
Circulo Micirculo = new Circulo(5.0);
Console.WriteLine("El area del circulo es: " + Micirculo.CalcularArea());