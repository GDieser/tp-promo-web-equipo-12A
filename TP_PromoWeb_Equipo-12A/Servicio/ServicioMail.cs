using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    public class ServicioMail
    {

        private readonly string remitente = "from@example.com";

        public bool EnviarCorreoSorteo(string destinatarioEmail, string nombreUsuario, string imagenURL, string nombreArticulo)
        {
            string htmlBody = $@"
            <!DOCTYPE html>
            <html lang='es'>
            <head>
                <meta charset='UTF-8'>
                <title>¡Estás participando!</title>
            </head>
            <body>
                <div style='text-align:center; font-family:Arial;'>
                    <h1>¡Felicidades {nombreUsuario}!</h1>
                    <p>Ya estás participando por el sorteo de este increíble premio:</p>
                    <img src='{imagenURL}' alt='Premio del sorteo' style='max-width:100%; border-radius:10px;'/>
                    <div style='font-size:18px; margin-top:10px;'><strong>{nombreArticulo}</strong></div>
                    <p style='margin-top:30px; color:#555;'>¡Muchos éxitos!</p>
                </div>
            </body>
            </html>";


            var mensaje = new MailMessage();
            mensaje.From = new MailAddress(remitente);
            mensaje.To.Add(destinatarioEmail);
            mensaje.Subject = "¡Ya estás participando!";
            mensaje.Body = htmlBody;
            mensaje.IsBodyHtml = true;

            var cliente = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("0bce8ed59e7eda", "4ff6dce7385b7e"),
                EnableSsl = true
            };

            try
            {
                cliente.Send(mensaje);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar: " + ex.Message);
                return false;
            }
        }


    }
}
