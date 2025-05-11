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
        public AccesoDatos datos = new AccesoDatos();
        public bool BuscarVoucher(string codigo)
        {

            string consulta = "SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo FROM Vouchers WHERE CodigoVoucher = @codigo ";

            try
            {
                datos.setConsulta(consulta);
                datos.setParametro("@codigo", codigo);
                datos.ejecutarLectura();


                if (datos.Lector.Read())
                {
                    if (Convert.IsDBNull(datos.Lector["IdCliente"]))
                        return true;

                    return false;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
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
