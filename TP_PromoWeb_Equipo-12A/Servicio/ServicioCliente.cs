using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    internal class ServicioCliente
    {
        public int IdCliente { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }


        public Cliente obtenerCliente(string dni)
        {
            AccesoDatos datos = null;
            Cliente cliente = new Cliente();

            try
            {
                datos = new AccesoDatos();
                datos.setConsulta("SELECT * FROM CLIENTE WHERE DOCUMENTO = @dni");
                datos.setParametro("@dni", dni);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    cliente.IdCliente = (int)datos.Lector["IDCLIENTE"];
                    cliente.Documento = (string)datos.Lector["DOCUMENTO"];
                    cliente.Nombre = (string)datos.Lector["NOMBRE"];
                    cliente.Apellido = (string)datos.Lector["APELLIDO"];
                    cliente.Email = (string)datos.Lector["EMAIL"];
                    cliente.Direccion = (string)datos.Lector["DIRECCION"];
                    cliente.Ciudad = (string)datos.Lector["CIUDAD"];
                    cliente.CodigoPostal = (int)datos.Lector["CODIGOPOSTAL"];
                    return cliente;
                }

                return cliente;
            }
            catch (Exception)
            {
                return cliente;
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
                    catch { }
                    datos.cerrarConexion();
                }
            }
        }
        
        public bool altaCliente(Cliente cliente)
        {
            AccesoDatos datos = null;
            try
            {
                datos = new AccesoDatos();
                datos.limpiarParametros();
                datos.setConsulta("INSERT INTO CLIENTE (DOCUMENTO, NOMBRE, APELLIDO, EMAIL, DIRECCION, CIUDAD, CODIGOPOSTAL) VALUES (@documento, @nombre, @apellido, @email, @direccion, @ciudad, @codigoPostal)");
                datos.setParametro("@documento", cliente.Documento);
                datos.setParametro("@nombre", cliente.Nombre);
                datos.setParametro("@apellido", cliente.Apellido);
                datos.setParametro("@email", cliente.Email);
                datos.setParametro("@direccion", cliente.Direccion);
                datos.setParametro("@ciudad", cliente.Ciudad);
                datos.setParametro("@codigoPostal", cliente.CodigoPostal);
                datos.ejecutarAccion();
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
                    catch { }
                    datos.cerrarConexion();
                }
            }
        }


    }
}
