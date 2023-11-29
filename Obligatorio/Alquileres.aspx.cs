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
            }
        }

        protected void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Matricula = cboVehiculos.SelectedItem.Value;

            foreach (var vehiculo in BaseDeDatos.ListaVehiculos)
            {
                if (vehiculo.Matricula == Matricula)
                {
                    lblPrecio.Text = vehiculo.PrecioAlquiler.ToString();                    
                    lblPrecio.Visible = true;
                    lblPrecioDia.Text = vehiculo.PrecioAlquiler.ToString();
                }
            }           
        }

        protected void txtDias_TextChanged(object sender, EventArgs e) {}
        
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int precioDia = Int32.Parse(lblPrecioDia.Text);
            int DiasIng = Int32.Parse(txtDias.Text);
            int Resultado = precioDia * DiasIng;
            lblPrecio.Text = Resultado.ToString();
        }
      
        protected void btnAlquilar_Click(object sender, EventArgs e)
        {
            string Cedula = lstClientes.SelectedItem.Value;
            string Matricula = cboVehiculos.SelectedValue;
        }
    }
}