<%@ Page Title="Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Obligatorio.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Clientes</h3>
        </div>
    </div>
    <br />
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
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" placeholder="Teléfono"></asp:TextBox>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="Dirección"></asp:TextBox>
        </div>
    </div>
    <br />
    <div class="row">
    <div class="col-lg-4">
        <asp:Label ID="lblMessage" runat="server" Visible="true" ForeColor="Red" Font-Bold="True"></asp:Label>
    </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-8">
            <asp:GridView ID="gvClientes" runat="server" Width="80%" BorderWidth="2px" CellSpacing="5"
                OnRowCancelingEdit="gvClientes_RowCancelingEdit"
                OnRowDeleting="gvClientes_RowDeleting"
                OnRowEditing="gvClientes_RowEditing"
                OnRowUpdating="gvClientes_RowUpdating"
                AutoGenerateColumns="false"
                DataKeyNames="Documento">
                <Columns>
                    <asp:TemplateField HeaderText="Documento">
                        <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Text='<%# Bind("Documento") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lbl2" runat="server" Text='<%# Bind("Documento") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <asp:Label ID="lbl3" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombreGrid" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Apellido">
                        <ItemTemplate>
                            <asp:Label ID="lbl4" runat="server" Text='<%# Bind("Apellido") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtApellidoGrid" runat="server" Text='<%# Bind("Apellido") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Teléfono">
                        <ItemTemplate>
                            <asp:Label ID="lbl5" runat="server" Text='<%# Bind("Telefono") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTelefonoGrid" runat="server" Text='<%# Bind("Telefono") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Dirección">
                        <ItemTemplate>
                            <asp:Label ID="lbl6" runat="server" Text='<%# Bind("Direccion") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDireccionGrid" runat="server" Text='<%# Bind("Direccion") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>


                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />
                </Columns>

            </asp:GridView>

        </div>
    </div>




</asp:Content>
