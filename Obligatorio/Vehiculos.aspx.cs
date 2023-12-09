using Antlr.Runtime.Misc;
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

                this.gvVehiculos.DataSource = BaseDeDatos.ListaVehiculos;
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
            foreach (var vehiculo in BaseDeDatos.ListaVehiculos)
            {
                if (vehiculo.Matricula == Matricula)
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
            string precioAlquiler = (filaSeleccionada.FindControl("txtPrecioAlquilerGrid") as TextBox).Text;
            string imagenUno = (filaSeleccionada.FindControl("txtImagenUnoGrid") as TextBox).Text;
            string imagenDos = (filaSeleccionada.FindControl("txtImagenDosGrid") as TextBox).Text;
            string imagenTres = (filaSeleccionada.FindControl("txtImagenTresGrid") as TextBox).Text;

            foreach (var vehiculo in BaseDeDatos.ListaVehiculos)
            {
                if (vehiculo.Matricula == Matricula)
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
            string MatriculaIngresada = txtMatricula.Text;
            bool existeVehiculo = BaseDeDatos.ListaVehiculos.Any(vehiculo => vehiculo.Matricula == MatriculaIngresada);

            if (existeVehiculo)
            {
                lblMessage.Text = "Ya existe un vehículo con ese número de matrícula";
                lblMessage.Visible = true;
            }
            else
            {
                if (rblTipoVehiculo.SelectedItem.Value == "Moto")
                {
                    Moto moto = new Moto();
                    moto.Matricula = txtMatricula.Text;
                    moto.Marca = TxtMarca.Text;
                    moto.Modelo = TxtModelo.Text;
                    moto.Año = TxtAño.Text;
                    moto.Color = TextColor.Text;
                    moto.Kilometros = TextKm.Text;
                    moto.PrecioVenta = TextPrecioVenta.Text;
                    moto.PrecioAlquiler = TextPrecioAlquiler.Text;
                    moto.CampoEspecial = "Cilindradas:" + txtCilindrada.Text;
                    moto.Activo = true;
                    moto.ImagenUno = txtImagenUno.Text;
                    moto.ImagenDos = txtImagenDos.Text;
                    moto.ImagenTres = txtImagenTres.Text;
                    BaseDeDatos.ListaVehiculos.Add(moto);
                }
                else if (rblTipoVehiculo.SelectedItem.Value == "Auto")
                {
                    Auto auto = new Auto();
                    auto.Matricula = txtMatricula.Text;
                    auto.Marca = TxtMarca.Text;
                    auto.Modelo = TxtModelo.Text;
                    auto.Año = TxtAño.Text;
                    auto.Color = TextColor.Text;
                    auto.Kilometros = TextKm.Text;
                    auto.PrecioVenta = TextPrecioVenta.Text;
                    auto.PrecioAlquiler = TextPrecioAlquiler.Text;
                    auto.CampoEspecial = "Cant. Pasajeros:" + txtCantPasajeros.Text;
                    auto.Activo = true;
                    auto.ImagenUno = txtImagenUno.Text;
                    auto.ImagenDos = txtImagenDos.Text;
                    auto.ImagenTres = txtImagenTres.Text;
                    BaseDeDatos.ListaVehiculos.Add(auto);
                }
                else if (rblTipoVehiculo.SelectedItem.Value == "Camion")
                {
                    Camion camion = new Camion();
                    camion.Matricula = txtMatricula.Text;
                    camion.Marca = TxtMarca.Text;
                    camion.Modelo = TxtModelo.Text;
                    camion.Año = TxtAño.Text;
                    camion.Color = TextColor.Text;
                    camion.Kilometros = TextKm.Text;
                    camion.PrecioVenta = TextPrecioVenta.Text;
                    camion.PrecioAlquiler = TextPrecioAlquiler.Text;
                    camion.CampoEspecial = "Toneladas: " + txtToneladas.Text;
                    camion.Activo = true;
                    camion.ImagenUno = txtImagenUno.Text;
                    camion.ImagenDos = txtImagenDos.Text;
                    camion.ImagenTres = txtImagenTres.Text;
                    BaseDeDatos.ListaVehiculos.Add(camion);
                }
                this.gvVehiculos.DataSource = BaseDeDatos.ListaVehiculos;
                this.gvVehiculos.DataBind();
            }
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
