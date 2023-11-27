using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void gvUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvUsuarios.EditIndex = -1;
            this.gvUsuarios.DataSource = BaseDeDatos.ListaUsuarios;
            this.gvUsuarios.DataBind();
        }

        protected void gvUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string Documento = this.gvUsuarios.DataKeys[e.RowIndex].Values[0].ToString();
            foreach (var usuario in BaseDeDatos.ListaUsuarios)
            {
                if (usuario.Documento == Documento)
                {
                    BaseDeDatos.ListaUsuarios.Remove(usuario);
                    break;
                }
            }
            this.gvUsuarios.EditIndex = -1;
            this.gvUsuarios.DataSource = BaseDeDatos.ListaUsuarios;
            this.gvUsuarios.DataBind();
        }

        protected void gvUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvUsuarios.EditIndex = e.NewEditIndex;
            this.gvUsuarios.DataSource = BaseDeDatos.ListaUsuarios;
            this.gvUsuarios.DataBind();
        }

        protected void gvUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvUsuarios.Rows[e.RowIndex];
            string documento = this.gvUsuarios.DataKeys[e.RowIndex].Values[0].ToString();
            string nombre = (filaSeleccionada.FindControl("txtNombreGrid") as TextBox).Text;
            string apellido = (filaSeleccionada.FindControl("txtApellidoGrid") as TextBox).Text;
            string contraseña = (filaSeleccionada.FindControl("txtContraseñaGrid") as TextBox).Text;
            string tipo = (filaSeleccionada.FindControl("txtTipoGrid") as TextBox).Text;

            foreach (var usuario in BaseDeDatos.ListaUsuarios)
            {
                if (usuario.Documento == documento)
                {
                    usuario.Nombre = nombre;
                    usuario.Apellido = apellido;
                    usuario.Tipo = tipo;
                    usuario.Contraseña = contraseña;
                }
            }
            this.gvUsuarios.EditIndex = -1;
            this.gvUsuarios.DataSource = BaseDeDatos.ListaUsuarios;
            this.gvUsuarios.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Documento = txtDocumento.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Tipo = txtTipo.Text; 
            usuario.Contraseña = txtContraseña.Text;
            BaseDeDatos.ListaUsuarios.Add(usuario);

            this.gvUsuarios.DataSource = BaseDeDatos.ListaUsuarios;
            this.gvUsuarios.DataBind();
        }
    }
}
