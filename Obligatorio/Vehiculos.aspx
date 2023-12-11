<%@ Page Title="Vehículos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="Obligatorio.Vehiculos" %>

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
        <div>
            <div class="col-lg-12">
                <h3>AGREGAR UN VEHÍCULO</h3>
            </div>
        </div>
        <br />
        <div class="row">
            <asp:RadioButtonList ID="rblTipoVehiculo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rblTipoVehiculo_SelectedIndexChanged">
                <asp:ListItem Text="Auto" />
                <asp:ListItem Text="Moto" />
                <asp:ListItem Text="Camion" />
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="rfvTipoVehiculo" runat="server"
                ControlToValidate="rblTipoVehiculo"
                ErrorMessage="Debes seleccionar un tipo de vehículo"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class=" row">
        <div>
            <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control" Width="200" placeholder="Matricula"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvMatricula" runat="server"
                ControlToValidate="txtMatricula"
                ErrorMessage="Matricula requerida"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
        <br />
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="TxtMarca" runat="server" CssClass="form-control" Width="200" placeholder="Marca"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvMarca" runat="server"
                ControlToValidate="txtMarca"
                ErrorMessage="Marca requerida"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="TxtModelo" runat="server" CssClass="form-control" Width="200" placeholder="Modelo"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvModelo" runat="server"
                ControlToValidate="txtModelo"
                ErrorMessage="Modelo requerido"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="TxtAño" runat="server" CssClass="form-control" Width="200" TextMode="Number" placeholder="Año"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvAño" runat="server"
                ControlToValidate="TxtAño"
                ErrorMessage="Año requerido"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="TextColor" runat="server" CssClass="form-control" Width="200" placeholder="Color"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="TextKm" runat="server" CssClass="form-control" Width="200" TextMode="Number" placeholder="Kilometraje"></asp:TextBox>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="TextPrecioVenta" runat="server" CssClass="form-control" Width="200" TextMode="Number" placeholder="Precio venta"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rflPrecioVenta" runat="server"
                ControlToValidate="TextPrecioVenta"
                ErrorMessage="Precio de venta requerido"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>

    </div>

    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="TextPrecioAlquiler" runat="server" CssClass="form-control" Width="200" TextMode="Number" placeholder="Precio alquiler"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rflPrecioAlquiler" runat="server"
                ControlToValidate="TextPrecioAlquiler"
                ErrorMessage="Precio de alquiler requerido"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div>

    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtCantPasajeros" runat="server" CssClass="form-control" TextMode="Number" Width="200" Visible="false" placeholder="Cantidad de pasajeros"></asp:TextBox>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtCilindrada" runat="server" CssClass="form-control" TextMode="Number" Width="200" Visible="false" placeholder="Cilindrada"></asp:TextBox>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-12">
            <asp:TextBox ID="txtToneladas" runat="server" CssClass="form-control" TextMode="Number" Width="200" Visible="false" placeholder="Toneladas de carga"></asp:TextBox>
        </div>
    </div>
    <asp:Label ID="lblimg2" runat="server" Text="(*) Formato URL" CssClass="align-self-center" Font-Italic="true"></asp:Label>
    <div class=" row">
        <div class="col-lg-12">
            <div class="d-flex">
                <asp:TextBox ID="txtImagenUno" runat="server" CssClass="form-control" Width="200" placeholder="Imagen uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvImagenUno" runat="server"
                    ControlToValidate="txtImagenUno"
                    ErrorMessage="Imagen requerida"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
            </div>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-12">
            <div class="d-flex">
                <asp:TextBox ID="txtImagenDos" runat="server" TextMode="Url" Width="200" CssClass="form-control" placeholder="Imagen dos"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvImagenDos" runat="server"
                    ControlToValidate="txtImagenDos"
                    ErrorMessage="Imagen requerida"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
            </div>
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-12">
            <div class="d-flex">
                <asp:TextBox ID="txtImagenTres" runat="server" CssClass="form-control" Width="200" placeholder="Imagen tres"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvImagenTres" runat="server"
                    ControlToValidate="txtImagenTres"
                    ErrorMessage="Imagen requerida"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
            </div>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-dark" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-12">
            <asp:Label ID="lblMessage" runat="server" Visible="false" ForeColor="red"></asp:Label>
        </div>
    </div>
    <br />
    <div class=" row">
        <div class="col-lg-12">
            <asp:GridView ID="gvVehiculos" runat="server" Width="80%" BorderWidth="2px" CellSpacing="9" 
                OnRowCancelingEdit="gvVehiculos_RowCancelingEdit"
                OnRowDeleting="gvVehiculos_RowDeleting"
                OnRowEditing="gvVehiculos_RowEditing"
                OnRowUpdating="gvVehiculos_RowUpdating"
                AutoGenerateColumns="false"
                DataKeyNames="Matricula"  CssClass="table table-bordered table-condensed table-responsive table-hover">
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

                    <asp:TemplateField HeaderText="Color">
                        <ItemTemplate>
                            <asp:Label ID="lbl6" runat="server" Text='<%# Bind("Color") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtColorGrid" runat="server" Text='<%# Bind("Color") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Kilometros">
                        <ItemTemplate>
                            <asp:Label ID="lbl7" runat="server" Text='<%# Bind("Kilometros") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtKilometrosGrid" runat="server" Text='<%# Bind("Kilometros") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio venta">
                        <ItemTemplate>
                            <asp:Label ID="lbl8" runat="server" Text='<%# Bind("PrecioVenta") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrecioVentaGrid" runat="server" Text='<%# Bind("PrecioVenta") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio alquiler">
                        <ItemTemplate>
                            <asp:Label ID="lbl9" runat="server" Text='<%# Bind("PrecioAlquiler") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrecioAlquilerGrid" runat="server" Text='<%# Bind("PrecioAlquiler") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Campo especial">
                        <ItemTemplate>
                            <asp:Label ID="lbl10" runat="server" Text='<%# Bind("CampoEspecial") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ImagenUno">
                        <ItemTemplate>
                            <asp:Image ID="lbl11" runat="server" ImageUrl='<%# Bind("ImagenUno") %>' Width="180"></asp:Image>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtImagenUnoGrid" runat="server" Text='<%# Bind("ImagenUno") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="txtImagenUnoGrid" runat="server" Text="Debe ingresar una imagen" ValidationGroup="btnGuardar" ErrorMessage="Debe ingresar una imagen" TextMode="Url"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ImagenDos">
                        <ItemTemplate>
                            <asp:Image ID="lb12" runat="server" ImageUrl='<%# Bind("ImagenDos") %>' Width="180"></asp:Image>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtImagenDosGrid" runat="server" Text='<%# Bind("ImagenDos") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="txtImagenUnoGrid" runat="server" Text="Debe ingresar una imagen" ValidationGroup="btnGuardar" ErrorMessage="Debe ingresar una imagen" TextMode="Url"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ImagenTres">
                        <ItemTemplate>
                            <asp:Image ID="lbl13" runat="server" ImageUrl='<%# Bind("ImagenTres") %>' Width="180"></asp:Image>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtImagenTresGrid" runat="server" Text='<%# Bind("ImagenTres") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="txtImagenUnoGrid" runat="server" Text="Debe ingresar una imagen" ValidationGroup="btnGuardar" ErrorMessage="Debe ingresar una imagen" TextMode="Url"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Activo">
                        <ItemTemplate>
                            <asp:Label ID="lbl14" runat="server" Text='<%# Bind("Activo") %>' ></asp:Label>
                        </ItemTemplate>                        
                    </asp:TemplateField>


                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" CausesValidation="false" />
                </Columns>

            </asp:GridView>

        </div>
    </div>




</asp:Content>
