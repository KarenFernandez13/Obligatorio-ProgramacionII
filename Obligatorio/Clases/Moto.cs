using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Moto : Vehiculo
    {
        private string cilindrada;

        public Moto() { }
        public Moto(string matricula, string marca, string modelo, string año, string color, string kilometros,
           string precioVenta, string precioAlquiler, string cilindrada, bool Activo, string ImagenUno, string ImagenDos, string ImagenTres) : base(matricula, marca, modelo, año,
               color, kilometros, precioVenta, precioAlquiler, Activo, ImagenUno, ImagenDos, ImagenTres)
        {
            this.cilindrada = cilindrada;
        }

        public string GetCilindrada() => cilindrada;
        public void SetCilindrada(string cilindrada) => this.cilindrada = cilindrada;

    }
}