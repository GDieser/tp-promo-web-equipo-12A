<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Exito.aspx.cs" Inherits="TP_PromoWeb_Equipo_12A.Exito" %>


<asp:Content ID="Exito" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex flex-column align-items-center text-center my-5">

        <div class="alert alert-success w-100" style="max-width: 720px;" role="alert">
            <h4 class="alert-heading">🎉 ¡Registro Exitoso! 🎉</h4>
            <p>¡Felicitaciones! Tu participación ha sido registrada correctamente.</p>
            <hr>
            <p class="mb-0">En breve recibirás un correo de confirmación con los detalles de tu participación. ¡Gracias por sumarte!</p>
        </div>

        <div class="card text-center mt-4" style="width: 22rem;">
            <img src="https://cdn-icons-png.flaticon.com/512/3209/3209955.png" class="card-img-top mx-auto mt-3" alt="Éxito" style="width: 96px; height: 96px;">
            <div class="card-body">
                <h5 class="card-title">¡Estás participando!</h5>
                <p class="card-text">Te deseamos mucha suerte. Revisá tu email para más información.</p>
                <a href="Default.aspx" class="btn btn-primary">Volver al inicio</a>
            </div>
        </div>

    </div>
</asp:Content>

