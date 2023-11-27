using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Venta
    {
        private DateTime FechaVenta { get; set; }
        public string Documento { get; set; }
        public string Matricula { get; set; }
        public string DocumentoEmpleado { get; set; }
        public int Precio { get; set; }
       
        public Venta() { }
        public Venta(DateTime FechaVenta, string Documento, string Matricula, string DocumentoEmpleado, int Precio)
        {
            this.FechaVenta = FechaVenta;
            this.Documento = Documento;
            this.Matricula = Matricula;
            this.DocumentoEmpleado = DocumentoEmpleado;
            this.Precio = Precio;
        }

        public DateTime GetFechaVenta() => FechaVenta;
        public string GetMatricula() => Matricula;
        public string GetDocumento() => Documento;
        public string GetDocumentoEmpleado() => DocumentoEmpleado;
        public int GetPrecio() => Precio;     

        public void SetFechaRetiro(DateTime FechaRetiro) { this.FechaVenta = FechaVenta; }
        public void SetMatricula(string Matricula) { this.Matricula = Matricula; }
        public void SetDocumento(string Documento) { this.Documento = Documento; }
        public void SetDocumentoEmpleado(string DocumentoEmpleado) { this.DocumentoEmpleado = DocumentoEmpleado; }
        public void SetPrecio(int Precio) { this.Precio = Precio; }     

    }

}