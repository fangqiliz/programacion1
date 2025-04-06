using System;
using System.Collections.Generic;

var clasica = new Hamburguesa("Pan Blanco", "Res", 150);
clasica.agregarIngrediente(new Ingrediente("lechuga", 15));
clasica.agregarIngrediente(new Ingrediente("queso", 80));
clasica.agregarIngrediente(new Ingrediente("tomate", 30));
clasica.MostrarDetalle();


var saludable = new HamburguesaSaludable("pollo", 180);
saludable.agregarIngrediente(new Ingrediente("lechuga", 15));
saludable.agregarIngrediente(new Ingrediente("aguacate", 55));
saludable.agregarIngrediente(new Ingrediente("tomate", 30));
saludable.MostrarDetalle();

var premium = new HamburguesaPremium("pan Blanco", "Angus", 180);
premium.agregarIngrediente(new Ingrediente("tocino", 30));
premium.MostrarDetalle();
