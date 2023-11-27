using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class login : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkUsuarios").Visible = false;
            Master.FindControl("lnkClientes").Visible = false;
            Master.FindControl("lnkVehiculos").Visible = false;
            Master.FindControl("lnkVentas").Visible = false;
            Master.FindControl("lnkAlquileres").Visible = false;


            if (!Page.IsPostBack)
                BaseDeDatos.CargarDatosIniciales();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            string contraseña = txtContraseña.Text;
            bool existeUsuario = false;
            foreach (var usuario in BaseDeDatos.ListaUsuarios)
            {
                if (documento == usuario.GetDocumento() && contraseña == usuario.GetContraseña())
                {
                    existeUsuario = true;
                }
            }
            if (existeUsuario == true)
            {
                Response.Redirect("Default.aspx"); 
            }
            else
            {
                lblMessage.Text = ("Datos incorrectos. Por favor, inténtalo de nuevo.");
            }
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse.aspx");
        }
    }
}