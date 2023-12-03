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
        public string Año { get; set; }
        public string Color { get; set; }
        public string Kilometros { get; set; }
        public string PrecioVenta { get; set; }
        public string PrecioAlquiler { get; set; }
        public bool Activo { get; set; }
        public string ImagenUno { get; set; }
        public string ImagenDos { get; set; }
        public string ImagenTres { get; set; }



        public Vehiculo() { }
        public Vehiculo(string matricula, string marca, string modelo, string año, string color, string kilometros, string precioVenta, string precioAlquiler, bool Activo, string ImagenUno, string ImagenDos, string ImagenTres)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
            Kilometros = kilometros;
            PrecioVenta = precioVenta;
            PrecioAlquiler = precioAlquiler;
            this.Activo = Activo;
            this.ImagenUno = ImagenUno;
            this.ImagenDos = ImagenDos;
            this.ImagenTres = ImagenTres;
        }


        public string GetMatricula() => Matricula;
        public string GetMarca() => Marca;
        public string GetModelo() => Modelo;
        public string GetColor() => Color;
        public string GetKilometros() => Kilometros;
        public string GetAño() => Año;
        public string GetPrecioVenta() => PrecioVenta;
        public string GetPrecioAlquiler() => PrecioAlquiler;
        public bool GetActivo() => Activo;
        public string GetImagenUno() => ImagenUno;
        public string GetImagenDos() => ImagenDos;
        public string GetImagenTres() => ImagenTres;


        public void SetMatricula(string matricula) { this.Matricula = matricula; }
        public void SetMarca(string marca) { this.Marca = marca; }
        public void SetModelo(string modelo) { this.Modelo = modelo; }
        public void SetColor(string color) { this.Color = color; }
        public void SetKilometros(string Kilometros) { this.Kilometros = Kilometros; }
        public void SetAño(string año) { this.Año = año; }
        public void SetPrecioVenta(string precioVenta) { this.PrecioVenta = precioVenta; }
        public void SetPrecioAlquiler(string precioAlquiler) { this.PrecioAlquiler = precioAlquiler; }
        public void SetActivo(bool Activo) => this.Activo = Activo;
        public void SetImagenUno(string ImagenUno) => this.ImagenUno = ImagenUno;
        public void SetImagenDos(string ImagenDos) => this.ImagenDos = ImagenDos;
        public void SetImagenTres(string ImagenTres) => this.ImagenTres = ImagenTres;

    }
}