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
        
        public Auto(string matricula, string marca, string modelo, int año, string color, int kilometros, 
            int precioVenta, int precioAlquiler, int numeroPasajeros, bool Activo):base(matricula, marca, modelo, año, 
                color, kilometros, precioVenta, precioAlquiler, Activo)
        {
            this.numeroPasajeros = numeroPasajeros;             
        }


        public int GetNumeroPasajeros() => numeroPasajeros;
        public void SetNumeroPasajeros(int numeroPasajeros) => this.numeroPasajeros = numeroPasajeros;
    }
    
}