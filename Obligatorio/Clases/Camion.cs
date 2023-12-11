using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Camion : Vehiculo
    {
        private string capacidadCarga;

        public Camion() { }
        public Camion(string matricula, string marca, string modelo, string año, string color, string kilometros,
           string precioVenta, string precioAlquiler, string capacidadCarga, bool Activo, string ImagenUno, string ImagenDos, string ImagenTres) : base(matricula, marca, modelo, año,
               color, kilometros, precioVenta, precioAlquiler, Activo, ImagenUno, ImagenDos, ImagenTres)
        {
            this.capacidadCarga = capacidadCarga;
        }


        public string GetCapacidadCarga() => capacidadCarga;
        public void SetCapacidadCarga(string capacidadCarga) => this.capacidadCarga = capacidadCarga;
    }
}