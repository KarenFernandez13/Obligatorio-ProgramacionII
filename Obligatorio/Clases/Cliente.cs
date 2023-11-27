using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Cliente
    {
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Cliente() { }

        public Cliente(string documento, string nombre, string apellido, string telefono, string direccion)
        {
            this.Documento = documento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }


        public string GetDocumento() => Documento;
        public string GetNombre() => Nombre;
        public string GetApellido() => Apellido;
        public string GetTelefono() => Telefono;

        public void SetDocumento(string documento) { this.Documento = documento; }
        public void SetNombre(string nombre) {  this.Nombre = nombre;}
        public void SetApellido(string apellido) {  this.Apellido = apellido;}
        public void SetTelefono(string telefono) { this.Telefono = telefono; }
    }
}