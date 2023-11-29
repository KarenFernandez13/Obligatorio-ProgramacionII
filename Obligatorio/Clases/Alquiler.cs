using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Alquiler
    {
        private int CantidadDias {  get; set; }
        private DateTime FechaRetiro { get; set; }    
        public string Cedula { get; set; }
        public string Matricula { get; set; }   
        public string NombreUsuario { get; set; }
        public int Precio { get; set; }
        public bool Devuelto {  get; set; }


        public Alquiler() { }  
        public Alquiler(int CantidadDias, DateTime FechaRetiro, string Cedula, string Matricula, string NombreUsuario, int Precio, bool AutoDevuelto)
        {
            this.CantidadDias = CantidadDias;
            this.FechaRetiro = FechaRetiro;
            this.Cedula = Cedula;
            this.Matricula = Matricula;
            this.NombreUsuario = NombreUsuario;
            this.Precio = Precio;
            this.Devuelto = Devuelto;            
        }


        public int GetCantidadDias()=>CantidadDias;
        public DateTime GetFechaRetiro() => FechaRetiro;
        public string GetMatricula() => Matricula;
        public string GetCedula() => Cedula;
        public string GetNombreUsuario() => NombreUsuario;
        public int GetPrecio() => Precio;
        public bool GetDevuelto() => Devuelto;

        public void SetCantidadDias(int cantidadDias) { this.CantidadDias = cantidadDias; }
        public void SetFechaRetiro(DateTime FechaRetiro) { this.FechaRetiro = FechaRetiro; }
        public void SetMatricula(string Matricula) { this.Matricula = Matricula;}
        public void SetCedula(string Cedula) {  this.Cedula = Cedula;}
        public void SetNombreUsuario(string NombreUsuario) { this.NombreUsuario = NombreUsuario;}   
        public void SetPrecio(int Precio) { this.Precio = Precio; } 
        public void SetDevuelto(bool Devuelto) { this.Devuelto = Devuelto;} 



    }
}