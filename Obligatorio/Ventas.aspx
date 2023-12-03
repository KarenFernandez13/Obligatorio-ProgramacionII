<%@ Page Title="Ventas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Obligatorio.Ventas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Ventas</h3>
        </div>
    </div>
    
    <div class=" row">
        <div class="col-lg-8">
            Clientes:           
            <asp:ListBox ID="lstClientes" runat="server" CssClass="form-control" OnSelectedIndexChanged="lstClientes_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-8">
            Nombre cliente:
            <asp:Label ID="lblCliente" runat="server" Visible="false"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-2">
            <asp:Label ID="lblMessage2" runat="server" Visible="true" ForeColor="Red" Font-Bold="True"></asp:Label>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-8">
            Vehiculos:&nbsp;       
            <asp:DropDownList ID="cboVehiculos" runat="server" OnSelectedIndexChanged="cboVehiculos_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-4">
            Modelo: 
            <asp:Label ID="lblModelo" runat="server" Text="" Visible="true"></asp:Label>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-1">
            <asp:Label ID="lblSimbolo" runat="server" Visible="true" ForeColor="Red" Font-Bold="True">u$s</asp:Label>
        </div>
        <div class="col-lg-5">
            <asp:Label ID="lblPrecio" runat="server" Visible="false" ForeColor="Red" Font-Bold="True"></asp:Label>
            <br />

        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-8">
            Vendedor:&nbsp;          
         <asp:DropDownList ID="cboVendedores" runat="server" AutoPostBack="true" OnSelectedIndexChanged="cboVendedores_SelectedIndexChanged"></asp:DropDownList>&nbsp;
            <asp:Label ID="lblNombre" runat="server" Text="" Font-Italic="true"></asp:Label>
        </div>
    </div>
    <br />
    
    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnVender" runat="server" CssClass="btn btn-primary" Text="Confirmar venta" OnClick="btnVender_Click" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-8">
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Blue" Font-Bold="True"></asp:Label>
        </div>

    </div>






</asp:Content>
