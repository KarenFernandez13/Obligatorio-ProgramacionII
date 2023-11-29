<%@ Page Title="Registro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Obligatorio.Registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">

            <h3>Registrarse</h3>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Apellido"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" placeholder="Documento"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="txtTipo" runat="server" CssClass="form-control" placeholder="Tipo"></asp:TextBox>
        </div>
    </div>

    
    <br />
    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnRegistrarme" runat="server" CssClass="btn btn-primary" Text="Registrarme" OnClick="btnRegistro_Click" />
            <asp:Button ID="btnLogin2" runat="server" CssClass="btn btn-primary" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </div>
   
    
    <div class="row">
        <div class="col-lg-5">
            <asp:Label ID="lblError" runat="server" Visible="false" ForeColor="Red">Ya existe un usuario registrado con ese documento!</asp:Label>
            <asp:Label ID="lblConfirmacion" runat="server" Visible="false" ForeColor="Blue">Se ha registrado correctamente!</asp:Label>
        </div>
    </div>

</asp:Content>

