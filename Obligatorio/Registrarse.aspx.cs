using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            bool existeUsuario = false;
            
            foreach (var usuario in BaseDeDatos.ListaUsuarios)
            {
                if (documento == usuario.GetDocumento())
                {
                    existeUsuario = true;
                }
            }

            if (existeUsuario == true) 
            {
                lblConfirmacion.Visible = false;
                lblError.Visible = true;
                
            } else if (existeUsuario == false)
            {
                Usuario nuevoUsuario = new Usuario();
                nuevoUsuario.SetDocumento(txtDocumento.Text);
                nuevoUsuario.SetNombre(txtNombre.Text);
                nuevoUsuario.SetApellido(txtApellido.Text);
                nuevoUsuario.SetContraseña(txtContraseña.Text);
                nuevoUsuario.SetTipo(txtTipo.Text);
                BaseDeDatos.ListaUsuarios.Add(nuevoUsuario);
                lblConfirmacion.Visible = true;
                lblError.Visible = false;
            }
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtTipo.Text = string.Empty;
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}