using cinehome.controlador;
using cinehome.modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace cinehome.modelo
{
    public class pelicula
    {
     
        public int id_pelicula { get; set; }
        public string nombre_pelicula { get; set; }
        public string duracion { get; set; }
        public string audio { get; set; }
        public string calidad { get; set; }
        [Required]
        public int id_genero { get; set; }
        public genero genero { get; set; }
        [Required]
        public int id_formato { get; set; }
        public formato formato { get; set; }
        [Required]
        public int id_estudio{ get; set; }
        public estudio estudio { get; set; }
        [Required]
        public int id_director { get; set; }
        public director director { get; set; }
        public string elenco { get; set; }
        [Display(Name = "Fecha Estreno")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        // [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime fecha_estreno { get; set; }
        public string sinopsis { get; set; }

        /**************************************/
        /*****************MYSQL****************/
        /**************************************/



        public static int Agregar(pelicula pId_peliculas)
        {


            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into pelicula (id_pelicula,nombre_pelicula,duracion,audio,calidad,id_genero,id_formato,id_estudio,id_director,fecha_estreno,elenco,sinopsis) values ({0},'{1}','{2}', '{3}','{4}',{5},{6},{7}, {8},'{9}', '{10}','{11}')",
                pId_peliculas.id_pelicula, pId_peliculas.nombre_pelicula, pId_peliculas.duracion, pId_peliculas.audio, pId_peliculas.calidad, pId_peliculas.id_genero, pId_peliculas.id_formato, pId_peliculas.id_estudio, pId_peliculas.id_director, pId_peliculas.fecha_estreno, pId_peliculas.elenco, pId_peliculas.sinopsis), conectarmysql.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<pelicula> Buscar(string pNombre, string paudio)
        {
            List<pelicula> _lista = new List<pelicula>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT id_pelicula,nombre_pelicula,duracion,audio,calidad,id_genero,id_formato,id_estudio,id_director,fecha_estreno,elenco,sinopsis FROM pelicula  where nombre_pelicula ='{0}' or audio= '{1}' ", pNombre, paudio), conectarmysql.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pelicula ppelicula = new pelicula();
                ppelicula.id_pelicula = _reader.GetInt32(0);
                ppelicula.nombre_pelicula = _reader.GetString(1);
                ppelicula.duracion = _reader.GetString(2);
                ppelicula.calidad = _reader.GetString(3);
                ppelicula.id_genero = _reader.GetInt32(4);
                ppelicula.id_formato = _reader.GetInt32(5);
                ppelicula.id_estudio = _reader.GetInt32(6);
                ppelicula.id_director = _reader.GetInt32(7);
                ppelicula.fecha_estreno = _reader.GetDateTime(8);
                ppelicula.elenco = _reader.GetString(9);
                ppelicula.sinopsis = _reader.GetString(10);

       
                _lista.Add(ppelicula);
            }

            return _lista;
        }

    }
}