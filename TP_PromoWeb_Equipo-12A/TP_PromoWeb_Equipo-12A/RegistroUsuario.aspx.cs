using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_PromoWeb_Equipo_12A
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
       
        protected void btnBuscarDni_Click(object sender, EventArgs e)
        {
            String dni = txtDni.Text.ToString();

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}