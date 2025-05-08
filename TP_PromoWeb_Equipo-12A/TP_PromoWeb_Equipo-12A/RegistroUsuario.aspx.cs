using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicio;

namespace TP_PromoWeb_Equipo_12A
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtDni.Focus();
                hdnIdArticulo.Value = Request.QueryString["idArticulo"];
                hdnVoucher.Value = Request.QueryString["voucher"];
            }
        }

        protected void btnBuscarDni_Click(object sender, EventArgs e)
        {
            if (btnBuscarDni.Text.Equals("❌"))
            {
                Response.Redirect("RegistroUsuario.aspx");
            }
            else
            {
                String dni = txtDni.Text.ToString();
                ServicioCliente servicioCliente = new ServicioCliente();
                Cliente cliente = servicioCliente.obtenerCliente(dni);
                lblDni.Text = "";

                if (txtDni.Text.Length == 8)
                {
                    hdnIdCliente.Value = cliente.IdCliente.ToString();
                    if (cliente.IdCliente != 0)
                    {
                        txtDni.ReadOnly = true;
                    }

                    txtNombre.Text = cliente.Nombre;
                    txtNombre.ReadOnly = false;

                    txtApellido.Text = cliente.Apellido;
                    txtApellido.ReadOnly = false;

                    txtEmail.Text = cliente.Email;
                    txtEmail.ReadOnly = false;

                    txtDireccion.Text = cliente.Direccion;
                    txtDireccion.ReadOnly = false;

                    txtCiudad.Text = cliente.Ciudad;
                    txtCiudad.ReadOnly = false;

                    txtCp.Text = cliente.CodigoPostal.ToString();
                    txtCp.ReadOnly = false;

                    chkTerminos.Enabled = true;
                    btnBuscarDni.Text = "❌";
                }
                else
                {
                    lblDni.Text = "DNI Invalido, intente nuevamente...";
                }
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            bool err = false;

            if (txtNombre.Text.Length < 3)
            {
                lblNombreError.Text = "El nombre debe tener al menos 3 caracteres";
                err = true;
            }
            else
            {
                lblNombreError.Text = "";
            }

            if (txtApellido.Text.Length < 3)
            {
                lblApellidoError.Text = "El apellido debe tener al menos 3 caracteres";
                err = true;

            }
            else
            {
                lblApellidoError.Text = "";
            }

            if (txtEmail.Text.Length < 3)
            {
                lblEmailError.Text = "El email debe tener al menos 3 caracteres";
                err = true;

            }
            else
            {
                lblEmailError.Text = "";
            }

            if (txtDireccion.Text.Length < 3)
            {
                lblDireccionError.Text = "La direccion debe tener al menos 3 caracteres";
                err = true;

            }
            else
            {
                lblDireccionError.Text = "";
            }

            if (txtCiudad.Text.Length < 3)
            {
                lblCiudadError.Text = "La ciudad debe tener al menos 3 caracteres";
                err = true;

            }
            else
            {
                lblCiudadError.Text = "";
            }

            if (txtCp.Text.Length != 4)
            {
                lblCpError.Text = "El codigo postal debe tener 4 caracteres";
                err = true;

            }
            else
            {
                lblCpError.Text = "";
            }

            if (!chkTerminos.Checked)
            {
                lblTerminosError.Text = "Debe aceptar los terminos y condiciones";
                err = true;
            }
            else
            {
                lblTerminosError.Text = "";
            }

            if (!err)
            {
                Cliente cliente = new Cliente();
                int exito;

                cliente.IdCliente = int.Parse(hdnIdCliente.Value);
                cliente.Documento = txtDni.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Email = txtEmail.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Ciudad = txtCiudad.Text;
                cliente.CodigoPostal = int.Parse(txtCp.Text);

                ServicioCliente servicioCliente = new ServicioCliente();
                if (cliente.IdCliente.Equals(0))
                {
                    exito = servicioCliente.altaCliente(cliente);
                }
                else
                {
                    if (servicioCliente.actualizarCliente(cliente))
                    {
                        exito = 1;
                    }
                    else
                    {
                        exito = 0;
                    }
                }
                if (exito != 0)
                {
                    ServicioVoucher servicioVoucher = new ServicioVoucher();
                    if (servicioVoucher.asignarVoucher(cliente.IdCliente, int.Parse(hdnIdArticulo.Value), hdnVoucher.Value))
                    {

                        Response.Redirect("RegistroExitoso.aspx");
                    }
                    else
                    {
                        lblTituloError.Text = "Error al asignar el voucher";
                        lblCuerpoError.Text = "No se pudo asignar el voucher al cliente. Por favor, intente nuevamente.";
                        string script = "var modal = new bootstrap.Modal(document.getElementById('modalError')); modal.show();";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "modalError", script, true);
                    }
                }
                else
                {
                    lblTituloError.Text = "Error al actualizar el cliente";
                    lblCuerpoError.Text = "No se pudo actualizar el cliente. Por favor, intente nuevamente.";
                    string script = "var modal = new bootstrap.Modal(document.getElementById('modalError')); modal.show();";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "modalError", script, true);
                }
            }

        }
    }
}