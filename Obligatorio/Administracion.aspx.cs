using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class Administracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkAdministracion").Visible = true;
            Master.FindControl("lnkClientes").Visible = true;
            Master.FindControl("lnkVehiculos").Visible = true;
            Master.FindControl("lnkVentas").Visible = true;
            Master.FindControl("lnkAlquileres").Visible = true;
            Master.FindControl("LogOut").Visible = true;
        }

        protected void btnUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuarios.aspx");
        }

        protected void btnVerVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("VentasRealizadas.aspx");
        }
    }
}