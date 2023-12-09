<%@ Page Title="Administración" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="Obligatorio.Administracion" %>

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
            <h3>ADMINISTRACIÓN</h3>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:Button ID="btnUsuarios" runat="server" CssClass="btn btn-dark" Text="Ir a usuarios" OnClick="btnUsuarios_Click" />
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:Button ID="btnVerVentas" runat="server" CssClass="btn btn-dark" Text="Ver listado de ventas" OnClick="btnVerVentas_Click" />
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:Button ID="btnVerAlquileres" runat="server" CssClass="btn btn-dark" Text="Ver listado de alquileres" OnClick="btnVerAlquileres_Click" />
        </div>
    </div>
  </asp:Content>
