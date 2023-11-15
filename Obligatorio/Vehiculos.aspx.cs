using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class Vehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gvVehiculos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.ListaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void gvVehiculos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string Matricula = this.gvVehiculos.DataKeys[e.RowIndex].Values[0].ToString();
            foreach(var vehiculo in BaseDeDatos.ListaVehiculos)
            {
                if(vehiculo.Matricula == Matricula)
                {
                    BaseDeDatos.ListaVehiculos.Remove(vehiculo);
                    break;
                }
            }
            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.ListaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void gvVehiculos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvVehiculos.EditIndex = e.NewEditIndex;
            this.gvVehiculos.DataSource = BaseDeDatos.ListaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void gvVehiculos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvVehiculos.Rows[e.RowIndex];
            string Matricula = this.gvVehiculos.DataKeys[e.RowIndex].Values[0].ToString();
            string marca = (filaSeleccionada.FindControl("txtMarcaGrid") as TextBox).Text;
            string modelo = (filaSeleccionada.FindControl("txtModeloGrid") as TextBox).Text;

            foreach(var vehiculo in BaseDeDatos.ListaVehiculos)
            {
                if(vehiculo.Matricula == Matricula)
                {
                    vehiculo.Modelo = modelo;   
                    vehiculo.Marca = marca;
                }
            }
            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.ListaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Matricula=txtMatricula.Text;
            vehiculo.Marca=TxtMarca.Text;
            vehiculo.Modelo=TxtModelo.Text;
            BaseDeDatos.ListaVehiculos.Add(vehiculo);

            this.gvVehiculos.DataSource = BaseDeDatos.ListaVehiculos;
            this.gvVehiculos.DataBind();
        }
    }
}