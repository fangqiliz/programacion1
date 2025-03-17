using System;
using System.Collections.Generic;

Centralita centralita = new Centralita();

centralita.RegistrarLlamada(new LlamadaLocal("63426847", "56238", 100));
centralita.RegistrarLlamada(new LlamadaProvincial("6857367", "56238", 120, 1));
centralita.RegistrarLlamada(new LlamadaProvincial("8847923", "532874", 200, 3));

Console.WriteLine($"Total de llamadas: {centralita.GetTotalLlamada():C2}");
Console.WriteLine($"Total Facturado: {centralita.GetTotalFacturado():C2}");
