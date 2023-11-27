<%@ Page Title="Ventas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Obligatorio.Ventas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <h3>Ventas</h3>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            Clientes:
            <asp:ListBox ID="lstClientes" runat="server" CssClass="form-control"></asp:ListBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            Vehiculos:
            <asp:DropDownList ID="cboVehiculos" runat="server" Visible="false" CssClass="form-control"></asp:DropDownList>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnVender" runat="server" CssClass="btn btn-primary" Text="Vender" OnClick="btnVender_Click" />
        </div>
    </div>
     <div class="row">
         <div class="col-lg-5">
             <asp:Label ID="lblPrecioSimbolo" runat="server" Visible="false" CssClass="form-control" ForeColor="Red">$ </asp:Label>
             <asp:Label ID="lblPrecio" runat="server" Visible="false" CssClass="form-control" ForeColor="Red"></asp:Label>
         </div>
     </div>






</asp:Content>
