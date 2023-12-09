using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class WebForm3 : System.Web.UI.Page
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
                cboVendedores.DataTextField = "NombreApellido";
                cboVendedores.DataBind();

                txtFechaRetiro.Attributes["min"] = DateTime.Now.ToString("yyyy-MM-dd");

                string Matricula = cboVehiculos.SelectedItem.Value;
                foreach (var vehiculo in BaseDeDatos.VehiculosActivos())
                {
                    if (vehiculo.Matricula == Matricula)
                    {
                        lblPrecioDia.Text = vehiculo.PrecioAlquiler;
                    }
                }
            }
        }

        protected void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Matricula = cboVehiculos.SelectedItem.Value;

            foreach (var vehiculo in BaseDeDatos.VehiculosActivos())
            {
                if (vehiculo.Matricula == Matricula)
                {
                    lblPrecioDia.Text = vehiculo.PrecioAlquiler;                    
                }
            }
        }
        protected void txtFechaRetiro_TextChanged(object sender, EventArgs e)
        {
            DateTime fechaIngresada;

            if (DateTime.TryParse(txtFechaRetiro.Text, out fechaIngresada))
            {
                if (fechaIngresada.Date >= DateTime.Today)
                {
                    lblFecha.Visible = false;
                }
                else
                {
                    lblFecha.Text = "Debe ingresar una fecha a partir de hoy";
                    lblFecha.Visible = true;
                    txtFechaRetiro.Text = String.Empty;
                    lblPrecio.Text = String.Empty;
                }
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int precioDia = 0;
            if (String.IsNullOrEmpty(txtDias.Text))
            {
                lblMessage1.Text = "Debe ingresar cantidad de días.";
            }
            else if (lstClientes.SelectedIndex == -1)
            {
                lblMessage2.Text = "Debe seleccionar un cliente.";
            }
            else
            {
                lblMessage1.Visible = false;
                lblMessage2.Visible = false;
                int cantDias = 0;
                Int32.TryParse(lblPrecioDia.Text, out precioDia);
                Int32.TryParse(txtDias.Text, out cantDias);
                int Resultado = precioDia * cantDias;
                lblPrecio.Text = "$" + Resultado.ToString();
                
            }
        }

        protected void btnAlquilar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDias.Text))
            {
                lblMessage1.Text = "Debe ingresar cantidad de días.";
            }
            else 
            {
                lblMessage1.Visible = false;
                lblMessage2.Visible = false;
                string DocumentoCliente = lstClientes.SelectedItem.Value;
                string Matricula = cboVehiculos.SelectedValue;
                DateTime fechaAlq;
                DateTime.TryParse(txtFechaRetiro.Text, out fechaAlq);
                int precio = 0;
                Int32.TryParse(lblPrecio.Text, out precio);
                int cantDias = 0;
                Int32.TryParse(txtDias.Text, out cantDias);
                Alquiler NuevoAlquiler = new Alquiler();
                NuevoAlquiler.SetCantidadDias(cantDias);
                NuevoAlquiler.SetDocumentoCliente(DocumentoCliente);
                NuevoAlquiler.SetMatricula(Matricula);
                NuevoAlquiler.SetPrecio(precio);
                string documentoVendedor = "";

                foreach (var usuario in BaseDeDatos.ListaUsuarios)
                {
                    if (usuario.Documento == cboVendedores.SelectedItem.Value)
                    {
                        documentoVendedor = usuario.Documento;
                    }
                }
                NuevoAlquiler.SetDocumentoUsuario(documentoVendedor);
                NuevoAlquiler.SetFechaRetiro(fechaAlq);
                NuevoAlquiler.SetDevuelto(false);
                BaseDeDatos.ListaAlquileres.Add(NuevoAlquiler);

                foreach (var vehiculo in BaseDeDatos.ListaVehiculos)
                {
                    if (vehiculo.Matricula == Matricula)
                    {
                        vehiculo.SetActivo(false);
                        break;
                    }
                }

                cboVehiculos.DataSource = BaseDeDatos.VehiculosActivos();
                cboVehiculos.DataValueField = "Matricula";
                cboVehiculos.DataTextField = "MarcaModelo";
                cboVehiculos.DataBind();
                if (BaseDeDatos.VehiculosActivos().Count == 0)
                {
                    lblFecha.Text = "No tenemos vehículos disponibles.";
                    lblFecha.Visible = true;
                }

                lblMessage.Text = ("Alquiler realizado exitosamente!");
                txtBuscar.Text = String.Empty;
                lstClientes.SelectedIndex = -1;
                txtDias.Text = String.Empty;
            }

        }

        protected void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex == -1)
            {
                lblMessage2.Text = "Debe seleccionar un cliente.";
            }
            else
            {
                lblMessage2.Text = String.Empty;
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