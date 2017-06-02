using cinehome.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cinehome.vista
{
    public partial class in_pelicula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b_aceptar_Click(object sender, EventArgs e)
        {
            pelicula ppelicula = new pelicula();
            ppelicula.id_pelicula = Convert.ToInt32(tb_id_pelicula.Text.Trim());
            ppelicula.nombre_pelicula = tb_nombre_pelicula.Text.Trim();
            ppelicula.duracion = tb_duracion.Text.Trim();
            ppelicula.audio = tb_audio.Text.Trim();
            ppelicula.calidad = tb_calidad.Text.Trim();
            ppelicula.id_genero = Convert.ToInt32(tb_id_genero.Text.Trim());
            ppelicula.id_formato = Convert.ToInt32(tb_id_formato.Text.Trim());
            ppelicula.id_estudio = Convert.ToInt32(tb_id_estudio.Text.Trim());
            ppelicula.id_director = Convert.ToInt32(tb_id_director.Text.Trim());
            ppelicula.fecha_estreno = Convert.ToDateTime(tb_fecha_estreno.Text.Trim());
            ppelicula.elenco = tb_elenco.Text.Trim();
            ppelicula.sinopsis = tb_sinopsis.Text.Trim();

            int resultado = pelicula.Agregar(ppelicula);

            if (resultado > 0)
            {
                Response.Write("<script>window.alert('pelicula Guardado Con Exito en MYSQL');</script>");
            }
            else
            {
                Response.Write("<script>window.alert('pelicula no Guardado en MYSQL');</script>");

            }
        }
    }
}