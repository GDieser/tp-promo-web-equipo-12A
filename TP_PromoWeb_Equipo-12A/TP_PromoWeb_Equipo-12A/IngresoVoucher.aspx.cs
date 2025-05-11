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
                bool valido = false;

                if (servicio.BuscarVoucher(txtVoucher.Text, ref valido))
                {
                    Session.Add("voucher", txtVoucher.Text);
                    Response.Redirect("ElegirPremio.aspx");
                }
                else
                {
                    Response.Redirect("VoucherInvalido.aspx?valido="+valido);
  
                }

            }


        }
        private bool ValidarCodigo()
        {
            if (string.IsNullOrEmpty(txtVoucher.Text))
            {
                lblErrorVoucher.Text = "* ¡Debes ingresar el código del Voucher!";
                lblErrorVoucher.Visible = true;
                return false;
            }

            return true;
        }
    }
}