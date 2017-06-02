using cinehome.controlador;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinehome.modelo
{
    public class usuario
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string correo { get; set; }
        public string clave_usuario { get; set; }


        public static int Agregar(usuario pId_usuario)
        {


            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into usuarios (id_usuario,nombre_usuario,email,clave_usuario) values ({0},'{1}','{2}', '{3}')",
                pId_usuario.id_usuario, pId_usuario.nombre_usuario, pId_usuario.correo, pId_usuario.clave_usuario), conectarmysql.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

    }

    
        

}
