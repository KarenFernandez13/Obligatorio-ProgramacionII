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
    <br />
    <div class=" row">
        <div class="col-lg-8">
            Clientes:
            <asp:ListBox ID="lstClientes" runat="server" CssClass="form-control"></asp:ListBox>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-8">
            Vehiculos:
            <asp:DropDownList ID="cboVehiculos" runat="server" OnSelectedIndexChanged="cboVehiculos_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div>
    </div>
    <br />
    <div class=" row">
    <div class="col-lg-8">
        Fecha de venta: 
        <asp:TextBox ID="txtFechaVenta" runat="server" TextMode="Date"></asp:TextBox>
    </div>
</div>
    <br />
     <div class="row">
     <div class="col-lg-5">
         <br />
         <asp:Label ID="lblPrecio" runat="server" Visible="false" ForeColor="Red"></asp:Label>
     </div>
 </div>
     <br />
    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnVender" runat="server" CssClass="btn btn-primary" Text="Confirmar Venta" OnClick="btnVender_Click" />
        </div>
    </div>
   <br />
    <div class="row">
    <div class="col-lg-8">
        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Blue"></asp:Label>
    </div>
</div>






</asp:Content>
