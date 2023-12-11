<%@ Page Title="Alquileres" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alquileres.aspx.cs" Inherits="Obligatorio.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
            display: flex;
            text-align: center;
        }

        .container {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
        }
    </style>
    <br />
    <div class="row">
        <div class="col-lg-12">
            <h3>AGREGAR UN ALQUILER</h3>
        </div>
    </div>
    <br />
    <br />
    <div class=" row">   
        <div class="col-lg-6">
            <br />
            <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" placeholder="Buscar cliente por CI" OnTextChanged="txtBuscar_TextChanged"></asp:TextBox>
            <br />
            <button id="btnBuscar" runat="server" cssclass="btn btn-dark">Buscar</button>
        </div>
        <div class="col-lg-6">
            Clientes 
   
    <asp:ListBox ID="lstClientes" runat="server" CssClass="form-control" OnSelectedIndexChanged="lstClientes_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
            <asp:RequiredFieldValidator ID="rfvListaClientes" runat="server"
                ControlToValidate="lstClientes"
                ErrorMessage="Debe seleccionar un cliente."
                Display="Dynamic">
    </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <asp:Label ID="lblMessage2" runat="server" Visible="true" ForeColor="Red" Font-Bold="True"></asp:Label>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-6">
            Vehiculos&nbsp; 
           
            <asp:DropDownList ID="cboVehiculos" runat="server" OnSelectedIndexChanged="cboVehiculos_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="col-lg-6">
            <img src="img/" id="imgVehiculo" runat="server" alt="Foto del vehículo" visible="false" width="150" height="100" data-value="Matricula" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-12">
            Valor diario:    
        
            <asp:Label ID="lblPrecioDia" runat="server" TextMode="Number" placeholder="Precio/Dia"></asp:Label>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-12">
            Fecha de retiro&nbsp;    
        
            <asp:TextBox ID="txtFechaRetiro" runat="server" TextMode="Date" OnTextChanged="txtFechaRetiro_TextChanged" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-12">
            <asp:Label ID="lblFecha" runat="server" Visible="false" ForeColor="Red" Font-Bold="True"></asp:Label>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            Cantidad de días&nbsp;
           
            <asp:TextBox ID="txtDias" runat="server" CssClass="form-control" placeholder="Cantidad de dias"></asp:TextBox>
        </div>
    </div>
    <br />
    <div class="row">
        <asp:Label ID="lblMessage1" runat="server" Visible="true" ForeColor="Red" Font-Bold="True"></asp:Label>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            Vendedor&nbsp;
           
            <asp:DropDownList ID="cboVendedores" runat="server" AutoPostBack="true">
            </asp:DropDownList>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:Button ID="btnCalcular" runat="server" CssClass="btn btn-dark" AutoPostBack="false" Text="Calcular total" OnClick="btnCalcular_Click" />
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">
            <asp:Label ID="lblPrecio" runat="server" Visible="true" ForeColor="Red" Font-Bold="True"></asp:Label>
        </div>
    </div>
    <br />

    <div class="row">
        <div class="col-lg-12">
            <asp:Button ID="btnAlquilar" runat="server" CssClass="btn btn-dark" Text="Confirmar alquiler" OnClick="btnAlquilar_Click" />
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <asp:Label ID="lblMessage" runat="server" Visible="true" ForeColor="blue" Font-Bold="True"></asp:Label>
        </div>
    </div>
</asp:Content>
