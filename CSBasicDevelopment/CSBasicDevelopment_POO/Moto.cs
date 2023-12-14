using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasicDevelopment_POO
{
    internal class Moto
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public Motorista Piloto { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Moto(decimal velocidadMaxima, int numeroRuedas)
        {
            VelocidadMaxima = velocidadMaxima;
            NumeroRuedas = numeroRuedas;
        }

        public Moto(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public Moto()
        {
            VelocidadMaxima = 320;
            NumeroRuedas = 2;
        }

        public void Acelerar()
        {
            // Codigo aquí
        }

        public void Arrancar()
        {
            // Codigo aquí
        }
    }
}
