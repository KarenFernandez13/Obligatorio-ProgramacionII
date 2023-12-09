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
                cboVehiculos.DataSource = BaseDeDatos.VehiculosActivos();
                cboVehiculos.DataValueField = "Matricula";
                cboVehiculos.DataTextField = "MarcaModelo";
                cboVehiculos.DataBind();

                lstClientes.DataSource = BaseDeDatos.ListaClientes;
                lstClientes.DataValueField = "Documento";
                lstClientes.DataTextField = "NombreApellido";
                lstClientes.DataBind();
                   
                cboVendedores.DataSource = BaseDeDatos.ListaUsuarios;
                cboVendedores.DataTextField = "Nombre";
                cboVendedores.DataBind();

                string Matricula = cboVehiculos.SelectedItem.Value;

                foreach (var vehiculo in BaseDeDatos.VehiculosActivos())
                {
                    if (vehiculo.Matricula == Matricula)
                    {
                        lblPrecio.Text = vehiculo.PrecioVenta;
                        lblPrecio.Visible = true;
                    }
                }
            }
        }

        protected void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Documento = lstClientes.SelectedItem.Value;            
        }
        protected void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Matricula = cboVehiculos.SelectedItem.Value;

            foreach (var vehiculo in BaseDeDatos.VehiculosActivos())
            {
                if (vehiculo.Matricula == Matricula)
                {
                    lblPrecio.Text = vehiculo.PrecioVenta;
                    lblPrecio.Visible = true;                    
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
                DateTime fechaVenta = DateTime.Now;
                int precio;
                Int32.TryParse(lblPrecio.Text, out precio);
                Venta nuevaVenta = new Venta();
                nuevaVenta.SetFechaVenta(fechaVenta);
                nuevaVenta.SetDocumentoCliente(lstClientes.Text);
                nuevaVenta.SetMatricula(cboVehiculos.Text);
                string documentoVendedor = "";

                foreach (var usuario in BaseDeDatos.ListaUsuarios)
                {
                    if (usuario.Documento == cboVendedores.SelectedItem.Value)
                    {
                        documentoVendedor = usuario.Documento;
                    }
                }

                nuevaVenta.SetDocumentoEmpleado(documentoVendedor);
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
                cboVehiculos.DataValueField = "Matricula";
                cboVehiculos.DataTextField = "MarcaModelo";
                cboVehiculos.DataBind();
                txtBuscar.Text = String.Empty;
                lstClientes.SelectedIndex = -1;

                if (BaseDeDatos.VehiculosActivos().Count == 0)
                {
                    lblSimbolo.Visible = false;
                    lblPrecio.Text = "No tenemos vehículos disponibles.";
                    lblPrecio.Visible = true;
                }
                lblMessage.Text = ("Venta realizada exitosamente!");
            }
        }       


        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string docu = txtBuscar.Text;
            ListItem clienteEncontrado = lstClientes.Items.FindByValue(docu);

            if (clienteEncontrado != null)
            {
                clienteEncontrado.Selected = true;
            }
            else
            {
                lblMessage2.Text = "No hay un cliente registrado con ese documento";
                lblMessage2.Visible = true;
                txtBuscar.Text = String.Empty;
                lstClientes.SelectedIndex = -1;                
            }
        }
    }
}