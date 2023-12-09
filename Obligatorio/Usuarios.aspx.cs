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
            Master.FindControl("lnkAdministracion").Visible = false;
            Master.FindControl("lnkClientes").Visible = false;
            Master.FindControl("lnkVehiculos").Visible = false;
            Master.FindControl("lnkVentas").Visible = false;
            Master.FindControl("lnkAlquileres").Visible = false;
            Master.FindControl("LogOut").Visible = false;
            if (!Page.IsPostBack)
            {
                this.gvUsuarios.DataSource = BaseDeDatos.ListaUsuarios;
                this.gvUsuarios.DataBind();
            }
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
            lblMessage.Text = "Usuario eliminado";
            lblMessage.Visible = true;
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
            

            foreach (var usuario in BaseDeDatos.ListaUsuarios)
            {
                if (usuario.Documento == documento)
                {
                    usuario.Nombre = nombre;
                    usuario.Apellido = apellido;                    
                    usuario.Contraseña = contraseña;
                }
            }

            this.gvUsuarios.EditIndex = -1;
            this.gvUsuarios.DataSource = BaseDeDatos.ListaUsuarios;
            this.gvUsuarios.DataBind();
        }

        protected void rblTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorSeleccionado = rblTipoUsuario.SelectedValue;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            CIValidator validator = new CIValidator();
            bool UsuarioValido = false;
            Usuario usuario = new Usuario();
            usuario.Tipo = rblTipoUsuario.SelectedValue;
            string Documento = txtDocumento.Text;
            UsuarioValido = validator.Validate(Documento);
            if (UsuarioValido == false)
            {
                lblMessage.Text = "El documento no es correcto";
                lblMessage.Visible = true;
            }
            else
            {
                UsuarioValido = ValidarUsuario(Documento);
                if (UsuarioValido == true)
                {
                    lblMessage.Visible = true;
                }
                else
                {
                    usuario.Documento = Documento;
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.Contraseña = txtContraseña.Text;
                    BaseDeDatos.ListaUsuarios.Add(usuario);
                    lblMessage.Text = "Usuario agregado correctamente";
                    lblMessage.Visible = true;
                    txtDocumento.Text = String.Empty;
                    txtNombre.Text = String.Empty;
                    txtApellido.Text = String.Empty;
                    this.gvUsuarios.DataSource = BaseDeDatos.ListaUsuarios;
                    this.gvUsuarios.DataBind();
                }
            }
           
        } 
        
        protected bool ValidarUsuario(string documento)
        {
            bool ExisteUsuario = false;
            foreach (var usuario in BaseDeDatos.ListaUsuarios)
            {
                if (usuario.Documento == documento)
                {
                    lblMessage.Text = "Ya existe un usuario con ese documento. Debe ingresar otro";
                    ExisteUsuario = true;
                }                
            }            
            return ExisteUsuario;               
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administracion.aspx");
        }
    }
}
