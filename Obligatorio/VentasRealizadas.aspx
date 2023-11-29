<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VentasRealizadas.aspx.cs" Inherits="Obligatorio.VentasRealizadas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class=" row">
        <div class="col-lg-8">
            <asp:GridView ID="gvVentas" runat="server" Height="171px" OnRowDeleting="gvVentas_RowDeleting"
                Width="676px" DataKeyNames="DocumentoCliente" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="DocumentoCliente">
                        <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Text='<%# Bind("DocumentoCliente") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lbl2" runat="server" Text='<%# Bind("DocumentoCliente") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Matricula">
                        <ItemTemplate>
                            <asp:Label ID="lblMatricula" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtMatriculaGrid" runat="server" Text='<%# Bind("Matricula") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="FechaVenta">
                        <ItemTemplate>
                            <asp:Label ID="lblFechaVenta" runat="server" Text='<%# Bind("FechaVenta") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFechaVentaGrid" runat="server" Text='<%# Bind("FechaVenta") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio">
                        <ItemTemplate>
                            <asp:Label ID="lblPrecio" runat="server" Text='<%# Bind("Precio") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrecioGrid" runat="server" Text='<%# Bind("Precio") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="DocumentoEmpleado">
                        <ItemTemplate>
                            <asp:Label ID="lblDocumentoEmpleado" runat="server" Text='<%# Bind("DocumentoEmpleado") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDcoumentoEmpleadoGrid" runat="server" Text='<%# Bind("DocumentoEmpleado") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ButtonType="Link" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>

            <br />
             <br />
            <div class=" row">
                <div class="col-lg-8">
                    <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-primary" Text="Volver"  OnClick="btnVolver_Click" />
                </div>
            </div>
        </div>
    </div>




</asp:Content>
