<%@ Page Title="Vehículos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="Obligatorio.Vehiculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Catálogo de Vehículos</h3>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control" placeholder="Matricula"></asp:TextBox>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="TxtMarca" runat="server" CssClass="form-control" placeholder="Marca"></asp:TextBox>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="TxtModelo" runat="server" CssClass="form-control" placeholder="Modelo"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="TxtAño" runat="server" CssClass="form-control" TextMode="Number" placeholder="Año"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="TextColor" runat="server" CssClass="form-control" placeholder="Color"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="TextKm" runat="server" CssClass="form-control" TextMode="Number" placeholder="Kilometraje"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="TextPrecioVenta" runat="server" CssClass="form-control" TextMode="Number" placeholder="Precio de Venta"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:TextBox ID="TextPrecioAlquiler" runat="server" CssClass="form-control" TextMode="Number" placeholder="Precio Alquiler"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:GridView ID="gvVehiculos" runat="server" Width="80%" BorderWidth="2px" CellSpacing="5"
                OnRowCancelingEdit="gvVehiculos_RowCancelingEdit"
                OnRowDeleting="gvVehiculos_RowDeleting"
                OnRowEditing="gvVehiculos_RowEditing"
                OnRowUpdating="gvVehiculos_RowUpdating"
                AutoGenerateColumns="false"
                DataKeyNames="Matricula">
                <Columns>
                    <asp:TemplateField HeaderText="Matricula">
                        <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lbl2" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Marca">
                        <ItemTemplate>
                            <asp:Label ID="lbl3" runat="server" Text='<%# Bind("Marca") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtMarcaGrid" runat="server" Text='<%# Bind("Marca") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Modelo">
                        <ItemTemplate>
                            <asp:Label ID="lbl4" runat="server" Text='<%# Bind("Modelo") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtModeloGrid" runat="server" Text='<%# Bind("Modelo") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Año">
                        <ItemTemplate>
                            <asp:Label ID="lbl5" runat="server" Text='<%# Bind("Año") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAñoGrid" runat="server" Text='<%# Bind("Año") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio Venta">
                        <ItemTemplate>
                            <asp:Label ID="lbl6" runat="server" Text='<%# Bind("PrecioVenta") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrecioVentaGrid" runat="server" Text='<%# Bind("PrecioVenta") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio Alquiler">
                        <ItemTemplate>
                            <asp:Label ID="lbl7" runat="server" Text='<%# Bind("PrecioAlquiler") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrecioAlquilerGrid" runat="server" Text='<%# Bind("PrecioAlquiler") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />
                </Columns>

            </asp:GridView>

        </div>
    </div>




</asp:Content>
