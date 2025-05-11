<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TP_PromoWeb_Equipo_12A.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
      <div class="container mt-5"> 
        <div class="row justify-content-center">
            <div class="col-md-6 text-center border-top border-bottom py-4"> 

                <div class="mb-3">
                    <label for="txtVoucher" class="form-label fs-5">¡Ingresá el código de tu voucher!</label>
                </div>

                <div class="mb-3">
                    <asp:TextBox ID="txtVoucher" runat="server" CssClass="form-control" ></asp:TextBox>
                   <asp:Label ID="lblErrorVoucher" Font-Size="Small" CssClass="text-danger" Visible="false" runat="server" />
                </div>

                <div class="mb-3">
                    <asp:Button ID="btnSiguiente" runat="server" Text="ingresar" CssClass="btn btn-primary" OnClick="btnSiguiente_Click" />
                </div>

            </div>
        </div>
    </div>
    
</asp:Content>
