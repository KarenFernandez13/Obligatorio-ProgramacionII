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
                lstClientes.DataSource = BaseDeDatos.ListaClientes;
                lstClientes.DataTextField = "Documento";
                lstClientes.DataBind();

                cboVehiculos.DataSource = BaseDeDatos.VehiculosActivos();
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();

                txtFechaRetiro.Attributes["min"] = DateTime.Now.ToString("yyyy-MM-dd");
            }
        }

        protected void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Matricula = cboVehiculos.SelectedItem.Value;

            foreach (var vehiculo in BaseDeDatos.ListaVehiculos)
            {
                if (vehiculo.Matricula == Matricula)
                {
                    lblPrecioDia.Text = vehiculo.PrecioAlquiler;
                    lblInfoVehiculo.Text=vehiculo.Modelo;
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

        protected void txtDias_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtDias.Text) || txtDias.Text == "0")
            {
                lblMessage1.Text = "Debe ingresar un valor mayor a 0";
                txtDias.Text = String.Empty;
            }
            else
            {
                lblMessage1.Text = String.Empty;
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int precioDia = 0;
            if (!String.IsNullOrEmpty(txtDias.Text) || txtDias.Text != "0")
            {
                int cantDias = 0;
                Int32.TryParse(lblPrecioDia.Text, out precioDia);
                Int32.TryParse(txtDias.Text, out cantDias);
                int Resultado = precioDia * cantDias;
                lblPrecio.Text = "$" + Resultado.ToString();
            }
            else
            {
                lblMessage1.Text = "Debe ingresar un valor mayor a 0";
                txtDias.Text = String.Empty;
            }
        }

        protected void btnAlquilar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex == -1)
            {
                lblMessage2.Text = "Debe seleccionar un cliente.";
            }
            else
            {
                lblMessage2.Text = String.Empty;
                string Cedula = lstClientes.SelectedItem.Value;
                string Matricula = cboVehiculos.SelectedValue;
                DateTime fechaAlq;
                DateTime.TryParse(txtFechaRetiro.Text, out fechaAlq);
                int precio = 0;
                Int32.TryParse(lblPrecio.Text, out precio);
                int cantDias = 0;
                Int32.TryParse(txtDias.Text, out cantDias);
                Alquiler NuevoAlquiler = new Alquiler();
                NuevoAlquiler.SetCantidadDias(cantDias);
                NuevoAlquiler.SetCedula(Cedula);
                NuevoAlquiler.SetMatricula(Matricula);
                NuevoAlquiler.SetPrecio(precio);
                NuevoAlquiler.SetNombreUsuario(BaseDeDatos.usuarioLogueado.Nombre);
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
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();
                if (BaseDeDatos.VehiculosActivos().Count == 0)
                {
                    lblFecha.Text = "No tenemos vehículos disponibles.";
                }

                lblMessage.Text = ("Alquiler realizado exitosamente!");
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

    }
}