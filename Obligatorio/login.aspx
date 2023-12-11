<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Obligatorio.login" %>

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

            <h3>LOGIN</h3>
        </div>
    </div>
    <br />
            <asp:Label ID="lblCedula" runat="server" Text="(*) Cédula sin puntos ni guiones." CssClass="align-self-center" Font-Italic="true" Font-Size="Small"></asp:Label>
    <br />
    <div class=" row">
        <div class="col-lg-12">    
                <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" TextMode="Number" placeholder="Documento"></asp:TextBox>        
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-dark" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-12">
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red" Font-Bold="True"></asp:Label>
        </div>
    </div>

</asp:Content>
