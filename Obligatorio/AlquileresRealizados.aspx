<%@ Page Title="Listado de alquileres" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlquileresRealizados.aspx.cs" Inherits="Obligatorio.AlquileresRealizados" %>

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
            <h3>ALQUILERES</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <asp:GridView ID="gvAlquileres" runat="server" Width="650px" Height="150px" BorderWidth="2px" CellSpacing="5"
                AutoGenerateColumns="false"
                OnRowCancelingEdit="gvVehiculos_RowCancelingEdit"
                OnRowDeleting="gvVehiculos_RowDeleting"
                OnRowEditing="gvVehiculos_RowEditing"
                OnRowUpdating="gvVehiculos_RowUpdating"
                DataKeyNames="NumeroAlquiler" OnSelectedIndexChanged="gvAlquileres_SelectedIndexChanged" CssClass="table table-bordered table-condensed table-responsive table-hover">
                <Columns>
                    <asp:TemplateField HeaderText="Número alquiler">
                        <ItemTemplate>
                            <asp:Label ID="numAlquiler" runat="server" Text='<%# Bind("NumeroAlquiler") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Matricula">
                        <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Documento cliente">
                        <ItemTemplate>
                            <asp:Label ID="lbl3" runat="server" Text='<%# Bind("DocumentoCliente") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Fecha alquiler">
                        <ItemTemplate>
                            <asp:Label ID="lbl4" runat="server" Text='<%# Bind("FechaRetiro") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Dias">
                        <ItemTemplate>
                            <asp:Label ID="lbl7" runat="server" Text='<%# Bind("CantidadDias") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio">
                        <ItemTemplate>
                            <asp:Label ID="lbl8" runat="server" Text='<%# Bind("Precio") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Devuelto">
                        <ItemTemplate>
                            <asp:CheckBox ID="lbl9" runat="server" Checked='<%# Bind("Devuelto") %>' Enabled="false"></asp:CheckBox>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkDevueltoGrid" runat="server" Checked='<%# Bind("Devuelto") %>'></asp:CheckBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Estado">
                        <ItemTemplate>
                            <asp:Label ID="lbl10" runat="server" Text='<%# Bind("Estado") %>' ForeColor="Red" Font-Bold="true"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />

                </Columns>

            </asp:GridView>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-dark" Text="Volver" OnClick="btnVolver_Click" />
        </div>
    </div>
</asp:Content>
