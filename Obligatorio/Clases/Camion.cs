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

        public Camion() { }
        public Camion(string matricula, string marca, string modelo, int año, string color, int kilometros,
           int precioVenta, int precioAlquiler, int capacidadCarga, bool Activo) : base(matricula, marca, modelo, año,
               color, kilometros, precioVenta, precioAlquiler, Activo)
        {
            this.capacidadCarga=capacidadCarga;
        }


        public int GetCapacidadCarga() => capacidadCarga;
        public void SetCapacidadCarga(int capacidadCarga)=>this.capacidadCarga = capacidadCarga;
    }
}