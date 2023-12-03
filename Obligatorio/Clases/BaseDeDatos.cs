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
            usuario.SetTipo("Admin");
            ListaUsuarios.Add(usuario);

            Usuario Vendedor = new Usuario("11", "Alejandra", "Fernandez", "Vendedor", "11");            
            ListaUsuarios.Add(Vendedor);

            Cliente cliente = new Cliente { Apellido = "Perez", Documento = "4586658-0", Direccion = "dr Edye 3456", Nombre = "Juan" };
            Cliente cliente2 = new Cliente { Apellido = "Lopez", Documento = "4589998-9", Direccion = "dr Edye 5585", Nombre = "Javier" };
            Cliente cliente3 = new Cliente { Apellido = "Gomez", Documento = "3785468-2", Direccion = "Aigua 3588", Nombre = "Luis" };
            ListaClientes.Add(cliente);
            ListaClientes.Add(cliente2);
            ListaClientes.Add(cliente3);

            Vehiculo vehiculo = new Vehiculo { Marca = "Ferrari", Matricula = "MA458855", Modelo = "F40", PrecioVenta = "1000000", PrecioAlquiler = "1000", Activo= true};
            Vehiculo vehiculo2 = new Vehiculo { Marca = "Chery", Matricula = "TG945884", Modelo = "TIGO", PrecioVenta = "95600", PrecioAlquiler = "100", Activo = true };
            Vehiculo vehiculo3 = new Vehiculo { Marca = "Fiat", Matricula = "FR46665", Modelo = "UNO", PrecioVenta = "857588", PrecioAlquiler = "130", Activo = true };
            Vehiculo vehiculo4 = new Vehiculo { Marca = "Chevrolet", Matricula = "YYU32885", Modelo = "ONIX", PrecioVenta = "80900", PrecioAlquiler = "115", Activo = false };
            ListaVehiculos.Add(vehiculo);
            ListaVehiculos.Add(vehiculo2);
            ListaVehiculos.Add(vehiculo3);
            ListaVehiculos.Add(vehiculo4);

            Venta venta = new Venta { FechaVenta = DateTime.Now, DocumentoCliente = "23648895", Matricula = "YYU32885", DocumentoEmpleado = "11111111", Precio = 80900 };
            ListaVentas.Add(venta);
        }

        public static void GuardarUsuarioLogueado(Usuario usuario)
        {
            usuarioLogueado = usuario;
            if(usuarioLogueado.GetTipo() == "Admin" || usuarioLogueado.GetTipo() == "admin")
            {
                usuario.SetVerAlquileres(true);
                usuario.SetVerVentas(true);
                usuario.SetVerCliente(true);
                usuario.SetVerAdministracion(true);
                usuario.SetVerVehiculos(true);
            }
            else if(usuarioLogueado.GetTipo() == "Vendedor" || usuarioLogueado.GetTipo() == "vendedor")
            {
                usuario.SetVerAlquileres(true);
                usuario.SetVerCliente(true);
                usuario.SetVerAdministracion(false);
                usuario.SetVerVehiculos(true);
                usuario.SetVerVentas(true);
            }
        }

        public static List <Vehiculo> VehiculosActivos()
        {
            List<Vehiculo> vehiculosActivos = new List<Vehiculo>();
            foreach (var vehiculo in ListaVehiculos)
            {
                if (vehiculo.Activo)
                {
                    vehiculosActivos.Add(vehiculo);
                }
            }
            return vehiculosActivos;
        }
    }

}