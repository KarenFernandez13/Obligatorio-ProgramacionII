using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Alquiler
    {
        private int CantidadDias;
        private DateTime FechaRetiro;
        private Usuario usuario;
        private Cliente cliente;
        private List<Vehiculo> VehiculosAlquilados; 
        public Alquiler() { }
    }
}