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
            if (!Page.IsPostBack)
            {
                lstClientes.DataSource = BaseDeDatos.ListaClientes;
                lstClientes.DataTextField = "Documento";
                lstClientes.DataBind();

                cboVehiculos.DataSource = BaseDeDatos.ListaVehiculos;
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
                    lblPrecioDia.Text = vehiculo.PrecioAlquiler.ToString();
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
            while (txtDias.Text == null || txtDias.Text == "0")
            {
                lblDias.Text = ("Datos incorrectos. Por favor, inténtalo de nuevo.");
                txtDias.Text = String.Empty;
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDias.ToString()))
            {
                int precioDia = Int32.Parse(lblPrecioDia.Text);
                int DiasIng = Int32.Parse(txtDias.Text);
                int Resultado = precioDia * DiasIng;
                lblPrecio.Text = "$" + Resultado.ToString();
            }
        }

        protected void btnAlquilar_Click(object sender, EventArgs e)
        {
            string Cedula = lstClientes.SelectedItem.Value;
            string Matricula = cboVehiculos.SelectedValue;
        }



    }
}