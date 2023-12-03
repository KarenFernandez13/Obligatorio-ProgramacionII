<%@ Page Title="Alquileres" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alquileres.aspx.cs" Inherits="Obligatorio.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Alquileres</h3>
        </div>
    </div>
    
    <div class=" row">
        <div class="col-lg-8">
            Clientes:           
            <asp:ListBox ID="lstClientes" runat="server" CssClass="form-control"></asp:ListBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-2">
            <asp:Label ID="lblMessage2" runat="server" Visible="true" ForeColor="Red" Font-Bold="True"></asp:Label>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-6">
            Vehiculos:           
            <asp:DropDownList ID="cboVehiculos" runat="server" OnSelectedIndexChanged="cboVehiculos_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div>
    </div>
    <br />
     <div class="row">
     <div class="col-lg-4">
         Modelo: 
         <asp:Label ID="lblInfoVehiculo" runat="server" Visible="true"></asp:Label>
     </div>
 </div>
    <div class="row">
        <div class="col-lg-2">
            Valor diario:
        <asp:Label ID="lblPrecioDia" runat="server" TextMode="Number" placeholder="Precio/Dia"></asp:Label>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-6">
            Fecha de retiro:
        <asp:TextBox ID="txtFechaRetiro" runat="server" TextMode="Date" OnTextChanged="txtFechaRetiro_TextChanged" />
        </div>
    </div>
    
    <div class="row">
        <div class="col-lg-4">
            <asp:Label ID="lblFecha" runat="server" Visible="false" ForeColor="Red" Font-Bold="True">Fecha incorrecta</asp:Label>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-6">
            <asp:TextBox ID="txtDias" runat="server" CssClass="form-control" placeholder="Cantidad de dias" OnTextChanged="txtDias_TextChanged"></asp:TextBox>
        </div>
    </div>
    
    <div class="row">
        <asp:Label ID="lblMessage1" runat="server" Visible="true" ForeColor="Red" Font-Bold="True" ></asp:Label>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-6">
            <asp:Button ID="btnCalcular" runat="server" CssClass="btn btn-primary" Text="Calcular total" OnClick="btnCalcular_Click" />
        </div>
    </div>
    
    <div class="row">
        <div class="col-lg-6">
            <asp:Label ID="lblPrecio" runat="server" Visible="true" ForeColor="Red" Font-Bold="True"></asp:Label>
        </div>
    </div>
    <br />

    <div class="row">
        <div class="col-lg-6">
            <asp:Button ID="btnAlquilar" runat="server" CssClass="btn btn-primary" Text="Confirmar alquiler" OnClick="btnAlquilar_Click" />
        </div>
    </div>
    <div class="row">
    <div class="col-lg-6">
        <asp:Label ID="lblMessage" runat="server" Visible="true" ForeColor="Red" Font-Bold="True"></asp:Label>
    </div>
</div>
</asp:Content>
