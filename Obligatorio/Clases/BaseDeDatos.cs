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
            Usuario usuario = new Usuario("11111111", "Administrador", "01", "Administrador", "admin");
            ListaUsuarios.Add(usuario);
            Usuario Vendedor = new Usuario("44292691", "Alejandra", "Fernandez", "Vendedor", "11");            
            ListaUsuarios.Add(Vendedor);

            Cliente cliente = new Cliente {Nombre = "Juan", Apellido = "Perez", Documento = "45866580", 
                Direccion = "dr Edye 3456", Telefono ="096878967" };
            Cliente cliente2 = new Cliente {Nombre = "Javier", Apellido = "Lopez", Documento = "56290716",
                Direccion = "dr Edye 5585", Telefono = "092557465" };
            Cliente cliente3 = new Cliente { Nombre = "Luis", Apellido = "Gomez", Documento = "37854682",
                Direccion = "Aigua 3588", Telefono = "099210430" };
            ListaClientes.Add(cliente);
            ListaClientes.Add(cliente2);
            ListaClientes.Add(cliente3);

            Moto vehiculo = new Moto { Marca = "Kawasaki", Matricula = "MA458855", Modelo = "Ninja", Color = "Blanco", Kilometros="45000",
                PrecioVenta = "20000", ImagenUno = "img/Kawasaki-Ninja-300-ii.jpg", ImagenDos = "img/81jSByQFgYL.jpg", ImagenTres = "img/KAWA1182.jpg",
                PrecioAlquiler = "1000", Activo= true, CampoEspecial= "Cilindrada: 1000", Año = "2015" };
            Auto vehiculo2 = new Auto { Marca = "Ferrari", Matricula = "TG945884", Modelo = "F40", Color="Negro",Kilometros = "59000",
                PrecioVenta = "180000", ImagenUno = "img/gas_monkey_f40_01212016.jpg", ImagenDos = "img/Ferrari-F40-Year-1987.jpg", ImagenTres = "img/1991-Ferrari-F40-black-2-630x419.jpg",
                PrecioAlquiler = "2000",Activo = true, CampoEspecial= "Cant. Pasajeros: 2", Año = "2009" };
            Camion vehiculo3 = new Camion { Marca = "Scania", Matricula = "FR46665", Modelo = "V8", Color = "Blanco", PrecioVenta = "250000", 
                ImagenUno = "img/scania-electrico-bateria.jpeg", ImagenDos = "img/scania2.jpg", ImagenTres = "img/scania3.jpg",
                Kilometros = "468000", PrecioAlquiler = "5000", Activo = true, CampoEspecial= "Toneladas: 100", Año = "2019" };
            Auto vehiculo4 = new Auto{Marca = "Nissan",Matricula = "NT2464", Modelo = "Tiida",PrecioVenta = "8000", Color= "Plata", ImagenUno = "img/tiida1.jpg",
                ImagenDos = "img/tiida2.jpeg",ImagenTres = "img/tiida3.jpg", PrecioAlquiler = "150", Activo = false, CampoEspecial = "Cant. Pasajeros: 4",
                Kilometros = "122560", Año="2010"};
            Camion vehiculo5 = new Camion {Marca = "Mercedes", Modelo = "1114", Matricula = "YU789801", PrecioVenta = "250000", ImagenUno = "img/mercedes1114.jpg",
                ImagenDos = "img/mercedes1114-2.jpg", ImagenTres = "img/mercedes1114-3.jpg", PrecioAlquiler = "4000", Activo = false, Color="Rojo",
                CampoEspecial = "Toneladas: 48",Kilometros = "620000", Año="1968"};
        
            ListaVehiculos.Add(vehiculo);
            ListaVehiculos.Add(vehiculo2);
            ListaVehiculos.Add(vehiculo3);
            ListaVehiculos.Add(vehiculo4);
            ListaVehiculos.Add(vehiculo5);

            Venta venta = new Venta { FechaVenta = DateTime.Now, DocumentoCliente = "45866580", 
                Matricula = "YU789801", DocumentoEmpleado = "44292691", Precio = 250000 };
            ListaVentas.Add(venta);
            Alquiler alquiler = new Alquiler { CantidadDias = 2, FechaRetiro = DateTime.Now, DocumentoCliente = "37854682", 
                Matricula = "NT2464", Precio = 300, Devuelto = false };
            ListaAlquileres.Add(alquiler);        
        }

        public static void GuardarUsuarioLogueado(Usuario usuario)
        {
            usuarioLogueado = usuario;
            if(usuarioLogueado.GetTipo() == "Administrador")
            {
                usuario.SetVerAlquileres(true);
                usuario.SetVerVentas(true);
                usuario.SetVerCliente(true);
                usuario.SetVerAdministracion(true);
                usuario.SetVerVehiculos(true);
            }
            else if(usuarioLogueado.GetTipo() == "Vendedor")
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