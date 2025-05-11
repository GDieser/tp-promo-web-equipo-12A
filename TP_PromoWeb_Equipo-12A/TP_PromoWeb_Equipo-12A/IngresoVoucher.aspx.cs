using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicio;

namespace TP_PromoWeb_Equipo_12A
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            ServicioVoucher servicio = new ServicioVoucher();

            if (ValidarCodigo())
            {
                if (servicio.BuscarVoucher(txtVoucher.Text))
                {
                    Session.Add("voucher", txtVoucher.Text);
                    Response.Redirect("ElegirPremio.aspx");
                }
                else
                {
                    lblErrorVoucher.Text = "*El código es invalido o ya fue canjeado!";
                    lblErrorVoucher.Visible = true;
                }

            }


        }
        private bool ValidarCodigo()
        {
            if (string.IsNullOrEmpty(txtVoucher.Text))
            {
                lblErrorVoucher.Text = "*Debés ingresar el codigo del Voucher !";
                lblErrorVoucher.Visible = true;
                return false;
            }

            return true;
        }
    }
}