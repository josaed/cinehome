using cinehome.modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cinehome.vista
{
    public partial class buscar : System.Web.UI.Page
    {
        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=cinehome; Uid=root; pwd=;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b_buscar_Click(object sender, EventArgs e)
        {
            t_pelicula.DataSource = pelicula.Buscar(tb_p_nombre.Text, tb_au.Text);

        }

        protected void b_listar_Click(object sender, EventArgs e)
        {
            conectar.Open();
            MySqlCommand cmd = conectar.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT pelicula.id_pelicula,pelicula.nombre_pelicula,pelicula.duracion,pelicula.audio,pelicula.calidad,genero.descripcion_genero,formato.descripcion_formato,estudio.descripcion_estudio,director.nombre_director,pelicula.fecha_estreno,pelicula.elenco,pelicula.sinopsis FROM pelicula INNER JOIN genero ON pelicula.id_genero = genero.id_genero INNER JOIN formato ON pelicula.id_formato = formato.id_formato INNER JOIN estudio ON pelicula.id_estudio = estudio.id_estudio INNER JOIN director ON pelicula.id_director = director.id_director;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            t_pelicula.DataSource = dt;
            t_pelicula.DataBind();
            conectar.Close();
        }
    }
}