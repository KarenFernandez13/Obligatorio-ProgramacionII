using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkAdministracion").Visible = false;
            Master.FindControl("lnkClientes").Visible = false;
            Master.FindControl("lnkVehiculos").Visible = false;
            Master.FindControl("lnkVentas").Visible = false;
            Master.FindControl("lnkAlquileres").Visible = false;
            Master.FindControl("LogOut").Visible = false;


            if (!Page.IsPostBack)
                BaseDeDatos.CargarDatosIniciales();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            string contraseña = txtContraseña.Text;

            foreach (var usuario in BaseDeDatos.ListaUsuarios)
            {
                if (documento == usuario.GetDocumento() && contraseña == usuario.GetContraseña())
                {
                    BaseDeDatos.GuardarUsuarioLogueado(usuario);
                    Response.Redirect("Default.aspx");
                }
            }

            lblMessage.Text = ("Datos incorrectos. Por favor, inténtalo de nuevo.");

        }
    }
}