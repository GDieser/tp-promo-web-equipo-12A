using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_PromoWeb_Equipo_12A
{
    public partial class VoucherInvalido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool valido = bool.Parse(Request.QueryString["valido"]);

            if (valido)
            {
                txtVouvherInvalido.Text = "¡El código ingresado es inválido!";
            }
            else
            {
                txtVouvherInvalido.Text = "¡El código ingresado ya fue utilizado!";
            }
        }

        protected void btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}