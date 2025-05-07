using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicio;

namespace TP_PromoWeb_Equipo_12A
{
    public partial class ElegirPremio : System.Web.UI.Page
    {
        //Me traigo los art para elegir uno
        public List<Articulo> ListaArticulos;

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloServicio servicio = new ArticuloServicio();
            ListaArticulos = servicio.listar();

            rptArticulo.DataSource = ListaArticulos;
            rptArticulo.DataBind();
        }
    }
}