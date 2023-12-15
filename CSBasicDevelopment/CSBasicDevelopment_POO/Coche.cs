using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasicDevelopment_POO
{
    internal class Coche : Vehiculo
    {
        public string Traccion { get; set; }

        public Coche(string marca, string modelo) : base(marca, modelo) { }

        public void CerrarPuertas()
        {
            // codigo
        }
    }
}
