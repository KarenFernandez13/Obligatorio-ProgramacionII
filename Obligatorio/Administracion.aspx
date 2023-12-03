<%@ Page Title="Administración" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="Obligatorio.Administracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Administración</h3>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnUsuarios" runat="server" CssClass="btn btn-primary" Text="Ir a usuarios" OnClick="btnUsuarios_Click" />
        </div>
    </div>
      <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnVerVentas" runat="server" CssClass="btn btn-primary" Text="Ver listado de ventas" OnClick="btnVerVentas_Click" />
        </div>
    </div>
</div>

</asp:Content>
