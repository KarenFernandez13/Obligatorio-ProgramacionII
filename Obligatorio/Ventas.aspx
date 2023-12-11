<%@ Page Title="Ventas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Obligatorio.Ventas" %>

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
            <h3>AGREGAR UNA VENTA</h3>
        </div>
    </div>
    <br />
    <br />
    <div class=" row">
        <br />
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
    <br />
    <br />
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
            <img src="img/" id="imgVehiculo" runat="server" alt="Foto del vehículo" visible="false" width="150" height="100" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-8">
            <asp:Label ID="lblSimbolo" runat="server" Visible="true" ForeColor="Red" Font-Bold="True" Font-Size="16px">Precio base u$s</asp:Label>
        </div>
        <div class="col-lg-4">
            <asp:Label ID="lblPrecio" runat="server" Visible="false" ForeColor="Red" Font-Bold="True" Font-Size="16px"></asp:Label>
            
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-6">
            <asp:TextBox ID="txtNuevoPrecio" runat="server" CssClass="form-control" placeholder="Nuevo precio" TextMode="Number" />
        </div>
        <div class="col-lg-6">
            <asp:Button ID="btnCambioPrecio" runat="server" CssClass="btn btn-dark" Text="Cambiar Precio" OnClick="btnCambioPrecio_Click" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-8">
            <asp:Label ID="lblSimbolo1" runat="server" Text="Precio final u$s" Style="white-space: nowrap;" ForeColor="Red" Font-Bold="True" Font-Size="16px"></asp:Label>
        </div>
        <div class="col-lg-4">
            <asp:Label ID="lblPrecioFinal" runat="server" Visible="false" ForeColor="Red" Font-Bold="True" Font-Size="16px"></asp:Label>
            <br />
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            Vendedor&nbsp;    
           
            <asp:DropDownList ID="cboVendedores" runat="server" AutoPostBack="true"></asp:DropDownList>&nbsp;
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:Button ID="btnVender" runat="server" CssClass="btn btn-dark" Text="Confirmar venta" OnClick="btnVender_Click" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-12">
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Blue" Font-Bold="True"></asp:Label>
        </div>
    </div>
</asp:Content>
