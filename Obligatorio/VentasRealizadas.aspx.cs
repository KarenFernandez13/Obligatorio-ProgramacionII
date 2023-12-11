using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class VentasRealizadas : System.Web.UI.Page
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
                this.gvVentas.DataSource = BaseDeDatos.ListaVentas;
                this.gvVentas.DataBind();                
            }                
        }

        protected void gvVentas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DocumentoCliente = this.gvVentas.DataKeys[e.RowIndex].Values[0].ToString();
            string matricula = "";
            foreach (var venta in BaseDeDatos.ListaVentas)
            {
                if (venta.DocumentoCliente == DocumentoCliente)
                {
                    matricula = venta.Matricula;
                    BaseDeDatos.ListaVentas.Remove(venta);
                    
                    break;
                }
            }

            foreach (var vehiculo in BaseDeDatos.ListaVehiculos)
            {
                if (vehiculo.Matricula == matricula)
                {
                    vehiculo.SetActivo(true);
                    break;
                }
            }

            this.gvVentas.EditIndex = -1;
            this.gvVentas.DataSource = BaseDeDatos.ListaVentas;
            this.gvVentas.DataBind();
            
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administracion.aspx");
           
        }
    }
}