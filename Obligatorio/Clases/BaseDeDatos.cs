using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio.Clases
{
    public abstract class BaseDeDatos
    {
        public static List<Vehiculo>ListaVehiculos = new List<Vehiculo>();
        public static List<Cliente>ListaClientes = new List<Cliente>();
        public static List<Alquiler>ListaAlquileres = new List<Alquiler>();
        public static List<Venta>ListaVentas = new List<Venta>();
        public static List<Usuario>ListaUsuarios = new List<Usuario>();

        public static Usuario usuarioLogueado;

        public static void CargarDatosIniciales()
        {
            Usuario usuario = new Usuario();
            usuario.SetNombre("admin");
            usuario.SetContraseña("admin");
            usuario.SetDocumento("11111111");
            usuario.SetVerAlquileres(true);
            usuario.SetVerVentas(true);
            usuario.SetVerCliente(true);
            usuario.SetVerUsuarios(true);
            usuario.SetVerVehiculos(true);

            ListaUsuarios.Add(usuario);

            Cliente cliente = new Cliente { Apellido = "Perez", Documento = "4586658-0", Direccion = "dr Edye 3456", Nombre = "Juan" };
            Cliente cliente2 = new Cliente { Apellido = "Lopez", Documento = "4589998-9", Direccion = "dr Edye 5585", Nombre = "Javier" };
            Cliente cliente3 = new Cliente { Apellido = "Gomez", Documento = "3785468-2", Direccion = "Aigua 3588", Nombre = "Luis" };
            ListaClientes.Add(cliente);
            ListaClientes.Add(cliente2);
            ListaClientes.Add(cliente3);

            Vehiculo vehiculo = new Vehiculo { Marca = "Ferrari", Matricula = "MA458855", Modelo = "F40", PrecioVenta = 1000000 };
            Vehiculo vehiculo2 = new Vehiculo { Marca = "Chery", Matricula = "TG945884", Modelo = "TIGO", PrecioVenta = 95600 };
            Vehiculo vehiculo3 = new Vehiculo { Marca = "Fiat", Matricula = "FR46665", Modelo = "UNO", PrecioVenta = 857588 };
            ListaVehiculos.Add(vehiculo);
            ListaVehiculos.Add(vehiculo2);
            ListaVehiculos.Add(vehiculo3);
        }

        public static void GuardarUsuarioLogueado(Usuario usuario)
        {
            usuarioLogueado = usuario;
        }
    }

}