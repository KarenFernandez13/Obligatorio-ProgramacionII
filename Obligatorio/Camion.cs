using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Camion : Vehiculo
    {
        private int capacidadCarga;

        public Camion():base() { }
        public int GetCapacidadCarga() => capacidadCarga;
        public void SetCapacidadCarga(int capacidadCarga) => this.capacidadCarga = capacidadCarga;
    }
}