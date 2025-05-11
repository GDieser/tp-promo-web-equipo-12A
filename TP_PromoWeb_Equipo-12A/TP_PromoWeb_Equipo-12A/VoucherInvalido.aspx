<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="VoucherInvalido.aspx.cs" Inherits="TP_PromoWeb_Equipo_12A.VoucherInvalido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <!-- <h1>  ventana voucher invalido</h1>-->
          <div class="container mt-5"> 
        <div class="row justify-content-center">
            <div class="col-md-6 text-center border-top border-bottom py-4"> 

                <div class="mb-3">
                    <label for="txtVoucher" class="form-label fs-5">¡el codigo de tu voucher es invalido o ya fue utilizado!</label>
                </div>

                <div class="mb-3">
                   <asp:Button ID="btninicio" runat="server" Text="inicio" CssClass="btn btn-primary" OnClick="btninicio_Click" />
                </div>

            </div>
        </div>
    </div>
</asp:Content>
