<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="VoucherInvalido.aspx.cs" Inherits="TP_PromoWeb_Equipo_12A.VoucherInvalido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- <h1>  ventana voucher invalido</h1>-->
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6 text-center border-top border-bottom py-4">

                <div class="card border-danger mb-3 text-danger" style="max-width: 40rem;">
                    <div class="card-header">¡ATENCIÓN!</div>
                    <div class="card-body text-danger">
                        <h5 class="card-title">❌</h5>
                        <asp:Label ID="txtVouvherInvalido" Text="" runat="server" CssClass=" form-label fs-5" />
                        
                        <div class="mb-3">
                            <br />
                            <asp:Button ID="btninicio" runat="server" Text="Inicio" CssClass="btn btn-primary" OnClick="btninicio_Click" />
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
