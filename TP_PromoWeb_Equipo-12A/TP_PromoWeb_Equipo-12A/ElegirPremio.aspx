<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ElegirPremio.aspx.cs" Inherits="TP_PromoWeb_Equipo_12A.ElegirPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Elegí tu premio: </h1>

    <!-- Prueba1 con Repeater -->


    <asp:Repeater ID="rptArticulo" runat="server">

        <ItemTemplate>
            <img src="<%# Eval("UrlImagen") %>" alt="Alternate Text" />

            <div class="card-body">
                <h5 class="card-title"><%# Eval("Nombre") %></h5>
                <p class="card-text"><%# Eval("Descripcion") %></p>
                <a href='' class='btn btn-primary'>Elegir</a>
            </div>

            <br />
        </ItemTemplate>

    </asp:Repeater>


</asp:Content>
