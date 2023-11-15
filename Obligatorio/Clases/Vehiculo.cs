using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio.Clases
{
    public class Vehiculo
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio {  get; set; }  
        public string Color { get; set; }   
        public int Kilometros {  get; set; }    
        public double PrecioVenta { get; set; }
        public double PrecioAlquiler {  get; set; } 


        public Vehiculo() { }

        public string GetMatricula() => Matricula; 
        public string GetMarca() => Marca;
        public string GetModelo() => Modelo;
        public string GetColor() => Color;
        public int GetKilometros() => Kilometros;
        public double GetPrecioVenta() => PrecioVenta;
        public double GetPrecioAlquiler() => PrecioAlquiler;

    }
}