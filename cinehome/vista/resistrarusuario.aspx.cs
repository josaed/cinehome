using cinehome.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cinehome.vista
{
    public partial class resistrarusuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b_aceptar_Click1(object sender, EventArgs e)
        {
            usuario pusuario = new usuario();
            pusuario.id_usuario = Convert.ToInt32(tb_id_usuario.Text.Trim());
            pusuario.nombre_usuario = tb_nombre_u.Text.Trim();
            pusuario.correo = tb_email.Text.Trim();
            pusuario.clave_usuario = tb_password.Text.Trim();


            int resultado = usuario.Agregar(pusuario);
            if (resultado > 0)
            {
                Response.Write("<script>window.alert('Usuario Guardado Con Exito en MYSQL');</script>");
            }
            else
            {
                Response.Write("<script>window.alert('Usuario no Guardado en MYSQL');</script>");

            } 
        }
    }
}