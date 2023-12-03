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
            Master.FindControl("lnkAdministracion").Visible = BaseDeDatos.usuarioLogueado.GetVerAdministracion();
            Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogueado.GetVerClientes();
            Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogueado.GetVerVehiculos();
            Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogueado.GetVerVentas();
            Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogueado.GetVerAlquileres();
            
            if (!Page.IsPostBack)
            {

                this.gvVehiculos.DataSource = BaseDeDatos.VehiculosActivos();
                this.gvVehiculos.DataBind();
            }
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
            string año = (filaSeleccionada.FindControl("txtAñoGrid") as TextBox).Text;
            string color = (filaSeleccionada.FindControl("txtColorGrid") as TextBox).Text;
            string kilometros = (filaSeleccionada.FindControl("txtKilometrosGrid") as TextBox).Text;
            string precioVenta = (filaSeleccionada.FindControl("txtPrecioVentaGrid") as TextBox).Text;
            string precioAlquiler= (filaSeleccionada.FindControl("txtPrecioAlquilerGrid") as TextBox).Text;
            string imagenUno = (filaSeleccionada.FindControl("txtImagenUnoGrid") as TextBox).Text;
            string imagenDos = (filaSeleccionada.FindControl("txtImagenDosGrid") as TextBox).Text;
            string imagenTres = (filaSeleccionada.FindControl("txtImagenTresGrid") as TextBox).Text;

            foreach (var vehiculo in BaseDeDatos.ListaVehiculos)
            {
                if(vehiculo.Matricula == Matricula)
                {
                    vehiculo.Modelo = modelo;   
                    vehiculo.Marca = marca;
                    vehiculo.Año = año;
                    vehiculo.Color = color;
                    vehiculo.Kilometros = kilometros;
                    vehiculo.PrecioVenta = precioVenta;
                    vehiculo.PrecioAlquiler = precioAlquiler;
                    vehiculo.ImagenUno = imagenUno;
                    vehiculo.ImagenDos = imagenDos;
                    vehiculo.ImagenTres = imagenTres;
                }
            }
            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.ListaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rblTipoVehiculo.SelectedItem.Value == "Moto")
            {

                Moto vehiculo = new Moto();
                vehiculo.Matricula = txtMatricula.Text;
                vehiculo.Marca = TxtMarca.Text;
                vehiculo.Modelo = TxtModelo.Text;
                vehiculo.Año = TxtAño.Text;
                vehiculo.Color = TextColor.Text;
                vehiculo.Kilometros = TextKm.Text;
                vehiculo.PrecioVenta = TextPrecioVenta.Text;
                vehiculo.PrecioAlquiler = TextPrecioAlquiler.Text;
                vehiculo.Activo = true;
                vehiculo.ImagenUno = txtImagenUno.Text;
                vehiculo.ImagenDos = txtImagenDos.Text;
                vehiculo.ImagenTres = txtImagenTres.Text;
                BaseDeDatos.ListaVehiculos.Add(vehiculo);                              
            }
            else if(rblTipoVehiculo.SelectedItem.Value == "Auto")
            {
                Auto vehiculo = new Auto(); 
                vehiculo.Matricula = txtMatricula.Text;
                vehiculo.Marca = TxtMarca.Text;
                vehiculo.Modelo = TxtModelo.Text;
                vehiculo.Año = TxtAño.Text;
                vehiculo.Color = TextColor.Text;
                vehiculo.Kilometros = TextKm.Text;
                vehiculo.PrecioVenta = TextPrecioVenta.Text;
                vehiculo.PrecioAlquiler = TextPrecioAlquiler.Text;
                vehiculo.Activo = true;
                vehiculo.ImagenUno = txtImagenUno.Text;
                vehiculo.ImagenDos = txtImagenDos.Text;
                vehiculo.ImagenTres = txtImagenTres.Text;
                BaseDeDatos.ListaVehiculos.Add(vehiculo);
            }
            else if(rblTipoVehiculo.SelectedItem.Value == "Camion")
            {
                Camion vehiculo = new Camion();
                vehiculo.Matricula = txtMatricula.Text;
                vehiculo.Marca = TxtMarca.Text;
                vehiculo.Modelo = TxtModelo.Text;
                vehiculo.Año = TxtAño.Text;
                vehiculo.Color = TextColor.Text;
                vehiculo.Kilometros = TextKm.Text;
                vehiculo.PrecioVenta = TextPrecioVenta.Text;
                vehiculo.PrecioAlquiler = TextPrecioAlquiler.Text;
                vehiculo.Activo = true;
                vehiculo.ImagenUno = txtImagenUno.Text;
                vehiculo.ImagenDos = txtImagenDos.Text;
                vehiculo.ImagenTres = txtImagenTres.Text;
                BaseDeDatos.ListaVehiculos.Add(vehiculo);
            }
            this.gvVehiculos.DataSource = BaseDeDatos.ListaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void txtCantPasajeros_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void rblTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblTipoVehiculo.SelectedItem.Value == "Moto")
            {
                txtCilindrada.Visible = true;
                txtCantPasajeros.Visible = false;
                txtToneladas.Visible = false;
            }
            else if (rblTipoVehiculo.SelectedItem.Value == "Auto")
            {
                txtCantPasajeros.Visible = true;
                txtToneladas.Visible = false;
                txtCilindrada.Visible = false;
            }
            else if (rblTipoVehiculo.SelectedItem.Value == "Camion")
            {
                txtToneladas.Visible = true;
                txtCantPasajeros.Visible = false;
                txtCilindrada.Visible = false;
            }
        }
    }
}