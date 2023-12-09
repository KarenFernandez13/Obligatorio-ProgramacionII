using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Alquiler
    {
        private static int contador = 1;
        public int CantidadDias {  get; set; }
        public DateTime FechaRetiro { get; set; }    
        public string DocumentoCliente { get; set; }
        public string Matricula { get; set; }   
        public string DocumentoUsuario { get; set; }
        public int Precio { get; set; }
        public bool Devuelto {  get; set; }
        public int NumeroAlquiler { get; set; }

        public Alquiler() { this.NumeroAlquiler = contador++; }  
        public Alquiler(int CantidadDias, DateTime FechaRetiro, string DocumentoCliente, string Matricula, 
            string DocumentoUsuario, int Precio, bool Devuelto)
        {
            this.CantidadDias = CantidadDias;
            this.FechaRetiro = FechaRetiro;
            this.DocumentoCliente = DocumentoCliente;
            this.Matricula = Matricula;
            this.DocumentoUsuario = DocumentoUsuario;
            this.Precio = Precio;
            this.Devuelto = Devuelto;
            this.NumeroAlquiler = contador++;
        }


        public int GetCantidadDias()=>CantidadDias;
        public DateTime GetFechaRetiro() => FechaRetiro;
        public string GetMatricula() => Matricula;
        public string GetDocumentoCliente() => DocumentoCliente;
        public string GetDocumentoUsuario() => DocumentoUsuario;
        public int GetPrecio() => Precio;
        public bool GetDevuelto() => Devuelto;
        public string Estado
        {
            get
            {
                if (!Devuelto && DateTime.Now > FechaRetiro.AddDays(CantidadDias))
                {
                    return "Atrasado";
                }
                else if (!Devuelto)
                {
                    return "Al día";
                }
                else
                {
                    return "Vehículo devuelto";
                }
            }
        }

        public void SetCantidadDias(int cantidadDias) { this.CantidadDias = cantidadDias; }
        public void SetFechaRetiro(DateTime FechaRetiro) { this.FechaRetiro = FechaRetiro; }
        public void SetMatricula(string Matricula) { this.Matricula = Matricula;}
        public void SetDocumentoCliente(string DocumentoCliente) {  this.DocumentoCliente = DocumentoCliente;}
        public void SetDocumentoUsuario(string DocumentoUsuario) { this.DocumentoUsuario = DocumentoUsuario; }   
        public void SetPrecio(int Precio) { this.Precio = Precio; } 
        public void SetDevuelto(bool Devuelto) { this.Devuelto = Devuelto;} 



    }
}