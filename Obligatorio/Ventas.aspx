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
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" placeholder="Buscar cliente por CI" OnTextChanged="txtBuscar_TextChanged"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <button id="btnBuscar" runat="server" cssclass="btn btn-dark">Buscar</button>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
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
    <div class="row">
        <div class="col-lg-12">
            <asp:Label ID="lblMessage2" runat="server" Visible="true" ForeColor="Red" Font-Bold="True"></asp:Label>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            Vehiculos&nbsp;     
            <asp:DropDownList ID="cboVehiculos" runat="server" OnSelectedIndexChanged="cboVehiculos_SelectedIndexChanged" AutoPostBack="true"> 
            </asp:DropDownList>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-12">
            <asp:Label ID="lblSimbolo" runat="server" Visible="true" ForeColor="Red" Font-Bold="True">u$s</asp:Label>
        </div>
        <div class="col-lg-12">
            <asp:Label ID="lblPrecio" runat="server" Visible="false" ForeColor="Red" Font-Bold="True"></asp:Label>
            <br />

        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            Vendedor&nbsp;    
            <asp:DropDownList ID="cboVendedores" runat="server" AutoPostBack="true"></asp:DropDownList>&nbsp;
            <asp:Label ID="lblNombre" runat="server" Text="" Font-Italic="true"></asp:Label>
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
