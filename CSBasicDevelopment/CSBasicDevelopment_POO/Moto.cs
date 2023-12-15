using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasicDevelopment_POO
{
    internal class Moto : Vehiculo
    {
        public decimal Cilindrada { get; set; }
        private Motorista piloto;
        public Motorista Piloto 
        { 
            get
            {
                if (piloto == null)
                    piloto = new Motorista();
                return piloto;
            }
            set { }
        }

        public Moto(decimal velocidadMaxima, int numeroRuedas, decimal cilindrada) : base(velocidadMaxima, numeroRuedas)
        {
            Cilindrada = cilindrada;
        }

        public Moto(string marca, string modelo, decimal cilindrada) : base(marca, modelo)
        {
            Cilindrada = cilindrada;
        }

        public void HacerCaballito()
        {
            // codigo
        }


    }
}
