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
                //Master.FindControl("lnkAdministracion").Visible = BaseDeDatos.usuarioLogueado.GetVerAdministracion();
                //Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogueado.GetVerClientes();
                //Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogueado.GetVerVehiculos();
                //Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogueado.GetVerVentas();
                //Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogueado.GetVerAlquileres();
                //NO NECESITAMOS ESTO PORQUE CREAMOS 2 TIPOS DE USUARIOS QUE YA DETERMINAN LOS PERMISOS
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
            string TipoUsuario = txtTipo.Text;
            
            if(TipoUsuario == "Admin" || TipoUsuario == "admin" || TipoUsuario == "Vendedor" || TipoUsuario == "vendedor")
            {
                Usuario usuario = new Usuario();
                usuario.Tipo = TipoUsuario;
                usuario.Documento = txtDocumento.Text;
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Contraseña = txtContraseña.Text;
                BaseDeDatos.ListaUsuarios.Add(usuario);
                lblMessage.Text = "Usuario agregado correctamente";
                lblMessage.Visible = true;
                txtDocumento.Text = String.Empty;
                txtNombre.Text = String.Empty;
                txtApellido.Text = String.Empty;
                txtTipo.Text = String.Empty;
                this.gvUsuarios.DataSource = BaseDeDatos.ListaUsuarios;
                this.gvUsuarios.DataBind();
                            
            }
            else
            {
                lblMessage.Text = "El tipo de usuario debe ser: 'Admin' o 'Vendedor'";
                lblMessage.Visible = true;
            }            
        }

    
    }
}
