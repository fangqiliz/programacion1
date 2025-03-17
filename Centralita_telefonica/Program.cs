using System;
using System.Collections.Generic;

Centralita centralita = new Centralita();

centralita.RegistrarLlamada(new LlamadaLocal("809 475 9831", "829 438 8243", 100));
centralita.RegistrarLlamada(new LlamadaProvincial("432 727 3272", "632 748 7843", 120, 1));
centralita.RegistrarLlamada(new LlamadaProvincial("737 372 9859", "236 736 6477", 200, 3));

Console.WriteLine($"Total de llamadas: {centralita.GetTotalLlamada():C2}");
Console.WriteLine($"Total Facturado: {centralita.GetTotalFacturado():C2}");
