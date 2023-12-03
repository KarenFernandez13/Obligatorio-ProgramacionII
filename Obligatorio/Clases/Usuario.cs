using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Usuario
    {
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo { get; set; }
        public string Contraseña { get; set; }

        public bool VerClientes { get; set; }
        public bool VerAdministracion { get; set; }
        public bool VerVentas { get; set; }
        public bool VerVehiculos { get; set; }
        public bool VerAlquileres { get; set; }    

        public Usuario() { }
        public Usuario(string documento, string nombre, string apellido, string tipo, string contraseña)
        {
            this.Documento = documento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Tipo = tipo;
            this.Contraseña = contraseña;
        }

        public string GetDocumento() => Documento;
        public string GetNombre() => Nombre;
        public string GetApellido() => Apellido;
        public string GetTipo() => Tipo;
        public string GetContraseña() => Contraseña;

        public bool GetVerClientes()=> VerClientes;
       
        public bool GetVerAdministracion()=> VerAdministracion;
        public bool GetVerVentas() => VerVentas;
        
        public bool GetVerVehiculos() => VerVehiculos;
      
        public bool GetVerAlquileres() => VerAlquileres;
       
        public void SetDocumento(string documento) => this.Documento = documento; 
        public void SetNombre(string nombre) => this.Nombre = nombre; 
        public void SetApellido(string apellido) => this.Apellido = apellido;        
        public void SetTipo(string tipo) => this.Tipo = tipo;
        public void SetContraseña(string contraseña) => this.Contraseña = contraseña;

        public void SetVerCliente(bool VerCliente) => this.VerClientes = VerCliente;
       
        public void SetVerAdministracion(bool VerAdministracion) => this.VerAdministracion = VerAdministracion;
       
        public void SetVerVentas(bool VerVentas) => this.VerVentas = VerVentas;
      
        public void SetVerVehiculos(bool VerVehiculos) => this.VerVehiculos = VerVehiculos;
      
        public void SetVerAlquileres(bool VerAlquileres) => this.VerAlquileres = VerAlquileres;
    }
}