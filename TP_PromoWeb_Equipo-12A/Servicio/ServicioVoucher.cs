using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    public class ServicioVoucher
    {
        public bool asignarVoucher(int idCliente, int idArticulo, string voucher)
        {
            AccesoDatos datos = null;
            try
            {
                datos = new AccesoDatos();
                datos.setConsulta("UPDATE Vouchers SET idCliente = @idCliente, idArticulo = @idArticulo, fechaCanje = GETDATE() WHERE codigoVoucher = @voucher;");
                datos.setParametro("@idCliente", idCliente);
                datos.setParametro("@idArticulo", idArticulo);
                datos.setParametro("@voucher", voucher);
                datos.ejecutarLectura();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (datos != null)
                {
                    try
                    {
                        if (datos.Lector != null && !datos.Lector.IsClosed)
                            datos.Lector.Close();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
         }

    }
}
