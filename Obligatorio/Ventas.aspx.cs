﻿using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                lstClientes.DataSource = BaseDeDatos.ListaClientes;
                lstClientes.DataTextField = "Documento";
                lstClientes.DataBind();

                cboVehiculos.DataSource = BaseDeDatos.ListaVehiculos;
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();
            }
        }

        protected void btnVender_Click(object sender, EventArgs e)
        {
            string Cedula = lstClientes.SelectedItem.Value;

            string Matricula = cboVehiculos.SelectedValue;
        }

        protected void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Matricula = cboVehiculos.SelectedItem.Value;

            foreach (var vehiculo in BaseDeDatos.ListaVehiculos)
            {
                if (vehiculo.Matricula == Matricula)
                {
                    lblPrecio.Text = vehiculo.PrecioVenta.ToString();
                    lblPrecio.Visible = true;
                    lblPrecioSimbolo.Visible = true;
                }
            }

        }
    }
}