using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Obligatorio
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkUsuarios").Visible = false;
            Master.FindControl("lnkClientes").Visible = false;
            Master.FindControl("lnkVehiculos").Visible = false;
            Master.FindControl("lnkVentas").Visible = false;
            Master.FindControl("lnkAlquileres").Visible = false;
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            
            foreach (var usuario in BaseDeDatos.ListaUsuarios)
            {
                if (documento == usuario.GetDocumento())
                {
                    lblError.Visible = true;
                    txtNombre.Text = string.Empty;
                    txtApellido.Text = string.Empty;
                    txtDocumento.Text = string.Empty;
                    txtTipo.Text = string.Empty;
                }
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}