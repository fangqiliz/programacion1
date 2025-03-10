using System;

Gallina gallina = new Gallina("Gallina", "Marron");
Pinguino pinguino = new Pinguino("Pinguino", "Blanco");
Loro loro = new Loro("Loro", "Verde");
Pato pato = new Pato("Pato", "Negro");
Aguila aguila = new Aguila("Aguila", "Marron");


gallina.Volar();
gallina.PonerHuevo();

pinguino.Volar();
pinguino.Deslizarse();

loro.Volar();

pato.Volar();
pato.Nadar();

aguila.Volar();
aguila.Cazar();