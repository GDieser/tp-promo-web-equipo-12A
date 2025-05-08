<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="TP_PromoWeb_Equipo_12A.RegistroUsuario" %>

<asp:Content ID="Contenido" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
        <h2 class="mb-4">Formulario de Cliente</h2>
        <div class="row mb-3">
            <label class="col-sm-2 col-form-label">DNI</label>
            <div class="col-sm-6 d-flex">
                <asp:TextBox ID="txtDni" runat="server" CssClass="form-control me-2" />
                <asp:Button ID="btnBuscarDni" runat="server" Text="🔍" CssClass="btn btn-outline-secondary" OnClick="btnBuscarDni_Click" />
            </div>
            <div class="col-sm-4">
                <asp:Label ID="lblDniError" runat="server" CssClass="text-danger" />
            </div>
        </div>

        <div class="row mb-3">
            <label class="col-sm-2 col-form-label">Nombre</label>
            <div class="col-sm-6">
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ReadOnly="true" />
            </div>
            <div class="col-sm-4">
                <asp:Label ID="lblNombreError" runat="server" CssClass="text-danger" />
            </div>
        </div>

        <div class="row mb-3">
            <label class="col-sm-2 col-form-label">Apellido</label>
            <div class="col-sm-6">
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" ReadOnly="true" />
            </div>
            <div class="col-sm-4">
                <asp:Label ID="lblApellidoError" runat="server" CssClass="text-danger" />
            </div>
        </div>

        <div class="row mb-3">
            <label class="col-sm-2 col-form-label">Direccion</label>
            <div class="col-sm-6">
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" ReadOnly="true" />
            </div>
        </div>


        <div class="row mb-3">
            <div class="col-sm-6 offset-sm-2">
                <div class="form-check">
                    <asp:CheckBox ID="chkTerminos" runat="server" CssClass="form-check-input" Enabled="false" />
                    <label class="form-check-label" for="chkTerminos">Acepto términos y condiciones</label>
                </div>
                <asp:Label ID="lblTerminosError" runat="server" CssClass="text-danger" />
            </div>
        </div>

        <div class="row mt-4">
            <div class="col-sm-6 offset-sm-2">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary me-2" OnClick="btnAceptar_Click" Enabled="false" />
                <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-secondary" PostBackUrl="~/Default.aspx" />
            </div>
        </div>
    </div>
</asp:Content>

