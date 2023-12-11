using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Moto : Vehiculo
    {
        private int cilindrada;

        public Moto():base() { }
        public int GetCilindrada() => cilindrada;
        public void SetCilindrada(int cilindrada) => this.cilindrada = cilindrada;
    }
}