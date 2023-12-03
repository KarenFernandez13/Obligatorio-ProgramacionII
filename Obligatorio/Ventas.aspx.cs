using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkAdministracion").Visible = BaseDeDatos.usuarioLogueado.GetVerAdministracion();
            Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogueado.GetVerClientes();
            Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogueado.GetVerVehiculos();
            Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogueado.GetVerVentas();
            Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogueado.GetVerAlquileres();
            
            if (!Page.IsPostBack)
            {
                lstClientes.DataSource = BaseDeDatos.ListaClientes;
                lstClientes.DataTextField = "Documento";
                lstClientes.DataBind();
                                
                cboVehiculos.DataSource = BaseDeDatos.VehiculosActivos();
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();

                cboVendedores.DataSource = BaseDeDatos.ListaUsuarios;
                cboVendedores.DataTextField = "Nombre";
                cboVendedores.DataBind();
            }
        }

        protected void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Documento = lstClientes.SelectedItem.Value;
            foreach (var cliente in BaseDeDatos.ListaClientes)
            {
                if (Documento == cliente.GetDocumento())
                {
                    lblCliente.Visible = true;
                    lblCliente.Text = cliente.GetNombre() + " " + cliente.GetApellido();
                }
            }
        }
        protected void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Matricula = cboVehiculos.SelectedItem.Value;

            foreach (var vehiculo in BaseDeDatos.ListaVehiculos)
            {
                if (vehiculo.Matricula == Matricula)
                {
                    lblPrecio.Text = vehiculo.PrecioVenta.ToString();
                    lblPrecio.Visible = true;
                    lblModelo.Text = vehiculo.Modelo.ToString();
                }
            }
        }

        protected void btnVender_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex == -1)
            {
                lblMessage2.Text = "Debe seleccionar un cliente.";
            }
            else
            {               
                string Matricula = cboVehiculos.SelectedValue;
                DateTime fechaVenta = DateTime.Now.Date;
                int precio;
                Int32.TryParse(lblPrecio.Text, out precio);
                Venta nuevaVenta = new Venta();
                nuevaVenta.SetFechaVenta(fechaVenta);
                nuevaVenta.SetDocumentoCliente(lstClientes.Text);
                nuevaVenta.SetMatricula(cboVehiculos.Text);
                nuevaVenta.SetDocumentoEmpleado(BaseDeDatos.usuarioLogueado.Documento);
                nuevaVenta.SetPrecio(precio);
                BaseDeDatos.ListaVentas.Add(nuevaVenta);

                foreach (var vehiculo in BaseDeDatos.ListaVehiculos)
                {
                    if (vehiculo.Matricula == Matricula)
                    {
                        vehiculo.SetActivo(false);
                        break;
                    }
                }

                lblMessage2.Text = String.Empty;
                cboVehiculos.DataSource = BaseDeDatos.VehiculosActivos();
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();

                if (BaseDeDatos.VehiculosActivos().Count == 0)
                {
                    lblSimbolo.Visible = false;
                    lblPrecio.Text = "No tenemos vehículos disponibles.";
                    lblPrecio.Visible = true;
                }
                lblMessage.Text = ("Venta realizada exitosamente!");
            }
        }

        

        protected void cboVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NombreVendedor = cboVendedores.SelectedItem.Value;

            foreach (var usuario in BaseDeDatos.ListaUsuarios)
            {
                if (usuario.Nombre == NombreVendedor)
                {
                    lblNombre.Text = usuario.Nombre + " " + usuario.Apellido;
                }
            }
        }

        
    }
}