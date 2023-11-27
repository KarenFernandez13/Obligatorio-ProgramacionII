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
        public int Año {  get; set; }  
        public string Color { get; set; }   
        public int Kilometros {  get; set; }    
        public int PrecioVenta { get; set; }
        public int PrecioAlquiler {  get; set; }

        public bool Activo { get; set; }
        

        public Vehiculo() { }
        public Vehiculo(string matricula, string marca, string modelo, int año, string color, int kilometros, int precioVenta, int precioAlquiler)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
            Kilometros = kilometros;
            PrecioVenta = precioVenta;
            PrecioAlquiler = precioAlquiler;
        }


        public string GetMatricula() => Matricula; 
        public string GetMarca() => Marca;
        public string GetModelo() => Modelo;
        public string GetColor() => Color;
        public int GetKilometros() => Kilometros;
        public int GetAño() => Año;
        public int GetPrecioVenta() => PrecioVenta;
        public int GetPrecioAlquiler() => PrecioAlquiler;

        public void SetMatricula(string matricula) { this.Matricula = matricula;}
        public void SetMarca(string marca) { this.Marca = marca; }
        public void SetModelo(string modelo) {  this.Modelo = modelo;}
        public void SetColor(string color) {  this.Color = color;}
        public void SetKilometros(int Kilometros) { this.Kilometros = Kilometros; }
        public void SetAño(int año) {this.Año = año;}
        public void SetPrecioVenta(int precioVenta) { this.PrecioVenta = precioVenta;} 
        public void SetPrecioAlquiler(int precioAlquiler) { this.PrecioAlquiler = precioAlquiler;}
            
    }
}