<%@ Page Title="Listado de ventas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VentasRealizadas.aspx.cs" Inherits="Obligatorio.VentasRealizadas" %>

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
         <h3>VENTAS</h3>
     </div>
 </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:GridView ID="gvVentas" runat="server" Height="150px" OnRowDeleting="gvVentas_RowDeleting" BorderWidth="2px" CellSpacing="5"
                Width="650px" DataKeyNames="DocumentoCliente" AutoGenerateColumns="false"  CssClass="table table-bordered table-condensed table-responsive table-hover">
                <Columns>
                    <asp:TemplateField HeaderText="Fecha venta">
                        <ItemTemplate>
                            <asp:Label ID="lblFechaVenta" runat="server" TextMode="Date" Text='<%# Bind("FechaVenta") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFechaVentaGrid" runat="server" Text='<%# Bind("FechaVenta") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Documento cliente">
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

                    <asp:TemplateField HeaderText="Precio venta">
                        <ItemTemplate>
                            <asp:Label ID="lblPrecio" runat="server" Text='<%# Bind("Precio") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrecioGrid" runat="server" Text='<%# Bind("Precio") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Vendedor">
                        <ItemTemplate>
                            <asp:Label ID="lblDocumentoEmpleado" runat="server" Text='<%# Bind("DocumentoEmpleado") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDocumentoEmpleadoGrid" runat="server" Text='<%# Bind("DocumentoEmpleado") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ButtonType="Link" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
            <br />
            <div class=" row">
                <div class="col-lg-12">
                    <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-dark" Text="Volver" OnClick="btnVolver_Click" />
                </div>
            </div>
        </div>
    </div>




</asp:Content>
