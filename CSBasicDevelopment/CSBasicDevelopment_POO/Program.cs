﻿// See https://aka.ms/new-console-template for more information
using CSBasicDevelopment_POO;

Moto aprilia = new Moto("Aprilia", "RX");
Moto motoSinMarca = new Moto(210, 2);

aprilia.VelocidadMaxima = 320;
aprilia.NumeroRuedas = 2;
aprilia.Acelerar();

aprilia.Piloto.Nacionalidad = "ESP";
