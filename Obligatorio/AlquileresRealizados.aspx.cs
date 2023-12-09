using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class AlquileresRealizados : System.Web.UI.Page
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
                this.gvAlquileres.DataSource = BaseDeDatos.ListaAlquileres;
                this.gvAlquileres.DataBind();                
            }
        }
        protected void gvAlquileres_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        protected void gvAlquileres_EntrgarClick(object sender, EventArgs e)
        {



        }

        protected void gvVehiculos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvAlquileres.EditIndex = -1;
            this.gvAlquileres.DataSource = BaseDeDatos.ListaAlquileres;
            this.gvAlquileres.DataBind();
        }

        protected void gvVehiculos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int NumeroAlquiler = Convert.ToInt32(this.gvAlquileres.DataKeys[e.RowIndex].Values[0]);
            string Matricula = string.Empty;
            foreach (var alquiler in BaseDeDatos.ListaAlquileres)
            {
                if (alquiler.NumeroAlquiler == NumeroAlquiler)
                {
                    Matricula = alquiler.Matricula;
                    BaseDeDatos.ListaAlquileres.Remove(alquiler);
                    break;
                }
            }
            foreach (var vehiculo in BaseDeDatos.ListaVehiculos)
            {
                if (vehiculo.Matricula == Matricula)
                {
                    vehiculo.Activo = true;
                }
            }
            this.gvAlquileres.EditIndex = -1;
            this.gvAlquileres.DataSource = BaseDeDatos.ListaAlquileres;
            this.gvAlquileres.DataBind();


        }

        protected void gvVehiculos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvAlquileres.EditIndex = e.NewEditIndex;
            this.gvAlquileres.DataSource = BaseDeDatos.ListaAlquileres;
            this.gvAlquileres.DataBind();
        }

        protected void gvVehiculos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvAlquileres.Rows[e.RowIndex];
            string NumeroAlquiler = this.gvAlquileres.DataKeys[e.RowIndex].Values[0].ToString();

            bool devuelto = (filaSeleccionada.FindControl("chkDevueltoGrid") as CheckBox).Checked;

            foreach (var alquiler in BaseDeDatos.ListaAlquileres)
            {
                if (alquiler.NumeroAlquiler.ToString() == NumeroAlquiler)
                {
                    alquiler.Devuelto = devuelto;
                }
            }

            this.gvAlquileres.EditIndex = -1;
            this.gvAlquileres.DataSource = BaseDeDatos.ListaAlquileres;
            this.gvAlquileres.DataBind();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administracion.aspx");
        }
    }
}
   