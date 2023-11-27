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

        public Moto() { }
        public Moto(string matricula, string marca, string modelo, int año, string color, int kilometros,
           int precioVenta, int precioAlquiler, int cilindrada) : base(matricula, marca, modelo, año,
               color, kilometros, precioVenta, precioAlquiler)
        {
            this.cilindrada = cilindrada;
        }

        public int GetCilindrada() => cilindrada;
        public void SetCilindrada(int cilindrada) => this.cilindrada=cilindrada;    

    }
}