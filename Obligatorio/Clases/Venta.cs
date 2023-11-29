using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Venta
    {
        public DateTime FechaVenta { get; set; }
        public string DocumentoCliente { get; set; }
        public string Matricula { get; set; }
        public string DocumentoEmpleado { get; set; }
        public int Precio { get; set; }
       
        public Venta() { }
        public Venta(DateTime FechaVenta, string DocumentoCliente, string Matricula, string DocumentoEmpleado, int Precio)
        {
            this.FechaVenta = FechaVenta;
            this.DocumentoCliente = DocumentoCliente;
            this.Matricula = Matricula;
            this.DocumentoEmpleado = DocumentoEmpleado;
            this.Precio = Precio;
        }

        public DateTime GetFechaVenta() => FechaVenta;
        public string GetMatricula() => Matricula;
        public string GetDocumentoCliente() => DocumentoCliente;
        public string GetDocumentoEmpleado() => DocumentoEmpleado;
        public int GetPrecio() => Precio;     

        public void SetFechaVenta(DateTime FechaRetiro) { this.FechaVenta = FechaVenta; }
        public void SetMatricula(string Matricula) { this.Matricula = Matricula; }
        public void SetDocumentoCliente(string DocumentoCliente) { this.DocumentoCliente = DocumentoCliente; }
        public void SetDocumentoEmpleado(string DocumentoEmpleado) { this.DocumentoEmpleado = DocumentoEmpleado; }
        public void SetPrecio(int Precio) { this.Precio = Precio; }     

    }

}