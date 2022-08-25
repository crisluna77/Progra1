using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace DB_Progra.MySQL
{
    class Conexion2
    {
        public static MySqlConnection obtener()
        {
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = progra1.tb_alumno; Uid= root; Password= ClunaA2001");
            conexion.Open();
            return conexion;


        }
    }
}