using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasicDevelopment_POO
{
    internal class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Vehiculo(decimal velocidadMaxima, int numeroRuedas)
        {
            VelocidadMaxima = velocidadMaxima;
            NumeroRuedas = numeroRuedas;
        }
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
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
