﻿using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class WebForm1 : System.Web.UI.Page
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
                this.gvClientes.DataSource = BaseDeDatos.ListaClientes;
                this.gvClientes.DataBind();
            }
        }
        protected void gvClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvClientes.EditIndex = -1;
            this.gvClientes.DataSource = BaseDeDatos.ListaClientes;
            this.gvClientes.DataBind();
        }

        protected void gvClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string Documento = this.gvClientes.DataKeys[e.RowIndex].Values[0].ToString();
            foreach (var cliente in BaseDeDatos.ListaClientes)
            {
                if (cliente.Documento == Documento)
                {
                    BaseDeDatos.ListaClientes.Remove(cliente);
                    break;
                }
            }
            this.gvClientes.EditIndex = -1;
            this.gvClientes.DataSource = BaseDeDatos.ListaClientes;
            this.gvClientes.DataBind();
        }

        protected void gvClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvClientes.EditIndex = e.NewEditIndex;
            this.gvClientes.DataSource = BaseDeDatos.ListaClientes;
            this.gvClientes.DataBind();
        }

        protected void gvClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvClientes.Rows[e.RowIndex];
            string documento = this.gvClientes.DataKeys[e.RowIndex].Values[0].ToString();
            string nombre = (filaSeleccionada.FindControl("txtNombreGrid") as TextBox).Text;
            string apellido = (filaSeleccionada.FindControl("txtApellidoGrid") as TextBox).Text;
            string direccion = (filaSeleccionada.FindControl("txtDireccionGrid") as TextBox).Text;
            string telefono = (filaSeleccionada.FindControl("txtTelefonoGrid") as TextBox).Text;

            foreach (var cliente in BaseDeDatos.ListaClientes)
            {
                if (cliente.Documento == documento)
                {
                    cliente.Nombre = nombre;
                    cliente.Apellido = apellido;
                    cliente.Telefono = telefono;
                    cliente.Direccion= direccion;
                }
            }
            this.gvClientes.EditIndex = -1;
            this.gvClientes.DataSource = BaseDeDatos.ListaClientes;
            this.gvClientes.DataBind();
        }
        //datavaluefield
        //require field validator
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            CIValidator CiValidator = new CIValidator();
            string cedula = txtDocumento.Text;
            bool ciValida = false;
            ciValida = CiValidator.Validate(cedula);
            if (ciValida == false /*|| txtDocumento.Text == null || txtDocumento.Text == String.Empty*/) 
            {
                lblMessage.Text = "El documento no es correcto";
                lblMessage.Visible = true;                
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.Documento = cedula;
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Direccion = txtDireccion.Text;
                BaseDeDatos.ListaClientes.Add(cliente);
                lblMessage.Text = "Cliente ingresado correctamente";
                lblMessage.Visible = true;
                this.gvClientes.DataSource = BaseDeDatos.ListaClientes;
                this.gvClientes.DataBind();
            }         
                       
        }

    }

}
