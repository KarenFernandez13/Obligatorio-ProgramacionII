using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Auto : Vehiculo
    {
        private string numeroPasajeros;
        public Auto() : base() { }

        public Auto(string matricula, string marca, string modelo, string año, string color, string kilometros,
            string precioVenta, string precioAlquiler, string numeroPasajeros, bool Activo, string ImagenUno, string ImagenDos, string ImagenTres) : base(matricula, marca, modelo, año,
                color, kilometros, precioVenta, precioAlquiler, Activo, ImagenUno, ImagenDos, ImagenTres)
        {
            this.numeroPasajeros = numeroPasajeros;
        }


        public string GetNumeroPasajeros() => numeroPasajeros;
        public void SetNumeroPasajeros(string numeroPasajeros) => this.numeroPasajeros = numeroPasajeros;
    }

}