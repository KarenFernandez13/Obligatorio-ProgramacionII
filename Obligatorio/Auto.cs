using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Auto : Vehiculo
    {
        private int numeroPasajeros;
        public Auto():base() { }
        public int GetNumeroPasajeros() => numeroPasajeros;
        public void SetNumeroPasajeros(int numeroPasajeros) => this.numeroPasajeros = numeroPasajeros;
    }
}