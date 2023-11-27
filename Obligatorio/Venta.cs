using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Venta
    {
        private DateTime FechaVenta;
        private int NumeroVenta;
        private Usuario usuario;
        private Cliente cliente;
        private List<Vehiculo> VehiculosVendidos; 
        public Venta() { }
         
    }
}