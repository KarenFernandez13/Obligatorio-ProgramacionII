<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Obligatorio.WebForm2" %>

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
            <h3>INGRESO DE USUARIOS</h3>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-12">
            <asp:RadioButtonList ID="rblTipoUsuario" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rblTipoUsuario_SelectedIndexChanged">
                <asp:ListItem Text="Administrador" Value="Administrador" />
                <asp:ListItem Text="Vendedor" Value="Vendedor" />
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="rfvTipoUsuario" runat="server"
                ControlToValidate="rblTipoUsuario"
                ErrorMessage="El campo Tipo es obligatorio."
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server"
                ControlToValidate="txtNombre"
                ErrorMessage="El campo Nombre es obligatorio."
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Apellido"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvApellido" runat="server"
                ControlToValidate="txtApellido"
                ErrorMessage="El campo Apellido es obligatorio."
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtDocumento" runat="server" TextMode="Number" CssClass="form-control" placeholder="Documento"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDocumento" runat="server"
                ControlToValidate="txtDocumento"
                ErrorMessage="El campo Documento es obligatorio."
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtContraseña" TextMode="Password" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvContraseña" runat="server"
                ControlToValidate="txtContraseña"
                ErrorMessage="El campo Contraseña es obligatorio."
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-12">
            <asp:Label ID="lblMessage" runat="server" Visible="false" ForeColor="red" Font-Bold="true"></asp:Label>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-dark" Text="Guardar" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-dark" CausesValidation="false" Text="Volver" OnClick="btnVolver_Click" />
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:GridView ID="gvUsuarios" runat="server" Width="80%" BorderWidth="2px" CellSpacing="5"
                OnRowCancelingEdit="gvUsuarios_RowCancelingEdit"
                OnRowDeleting="gvUsuarios_RowDeleting"
                OnRowEditing="gvUsuarios_RowEditing"
                OnRowUpdating="gvUsuarios_RowUpdating"
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

                    <asp:TemplateField HeaderText="Contraseña">
                        <ItemTemplate>
                            <asp:Label ID="lbl5" runat="server" Text='<%# Bind("Contraseña") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtContraseñaGrid" runat="server" Text='<%# Bind("Contraseña") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Tipo">
                        <ItemTemplate>
                            <asp:Label ID="lbl6" runat="server" Text='<%# Bind("Tipo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" CausesValidation="false" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
