<%@ Page Title="Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Obligatorio.WebForm1" %>

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
            <h3>AGREGAR UN CLIENTE</h3>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" width="200" placeholder="Nombre"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server"
                ControlToValidate="txtNombre"
                ErrorMessage="El campo Nombre es obligatorio."
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" width="200" placeholder="Apellido"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvApellido" runat="server"
                ControlToValidate="txtApellido"
                ErrorMessage="El campo Apellido es obligatorio."
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" width="200" placeholder="Documento"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDocumento" runat="server"
                ControlToValidate="txtDocumento"
                ErrorMessage="El campo Documento es obligatorio."
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" width="200" placeholder="Teléfono"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTelefono" runat="server"
                ControlToValidate="txtTelefono"
                ErrorMessage="El campo Teléfono es obligatorio."
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" width="200" placeholder="Dirección"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDireccion" runat="server"
                ControlToValidate="txtDireccion"
                ErrorMessage="El campo Dirección es obligatorio."
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-12">
            <asp:Label ID="lblMessage" runat="server" Visible="true" ForeColor="Red" Font-Bold="True"></asp:Label>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-dark" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:GridView ID="gvClientes" runat="server" Width="80%" BorderWidth="2px" CellSpacing="9"
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


                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true"  CausesValidation="false"/>
                </Columns>

            </asp:GridView>

        </div>
    </div>




</asp:Content>
