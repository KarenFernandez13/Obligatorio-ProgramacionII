<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Obligatorio.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">

            <h3>Login</h3>
        </div>
    </div>
    <br />

    <div class=" row">
        <div class="col-lg-8">
            <div class="d-flex">
                <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" TextMode="Number" placeholder="Documento"></asp:TextBox>&nbsp;
                <asp:Label ID="lblCedula" runat="server" Text="(*) Cédula sin puntos ni guiones." CssClass="align-self-center" Font-Italic="true"></asp:Label>
            </div>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-8">
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </div>

</asp:Content>
