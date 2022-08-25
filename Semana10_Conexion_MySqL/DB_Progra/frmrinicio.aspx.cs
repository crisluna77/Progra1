using DB_Progra.Clases.archivos;
using DB_Progra.Clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DB_Progra
{
    public partial class frmrinicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void cargarArchivoexterno()
        {
            string fuente = @"C:\Users\Cristian Luna\Desktop\Archivo\crudDB (1).csv";
            ClsArchivo ar = new ClsArchivo();
            ClsConexiones cn = new ClsConexiones();

            //obtener tood el archivo de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencial_sql = "";
            int NumeroLinea = 0;

            //interamos sobre el arreglo, line por linea para luego convertirlo en dadots
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (NumeroLinea > 0)
                {
                    sentencial_sql += $"insert into progra1.tb_alumno values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                }// end foreach

                NumeroLinea++;

            }
            NumeroLinea = 0;
            cn.EjecutaSQLDirecto(sentencial_sql);
        }

        protected void ButtonCargardatos_Click(object sender, EventArgs e)
        {
             cargarArchivoexterno();
        }

        public DataTable CargarDatosDB(string condicion = "1=1")
        {
            ClsConexiones cn = new ClsConexiones();
            DataTable dt = new DataTable();
            string sentencia = $"select * from progra1.tb_alumno where {condicion} ";
            dt = cn.consultaTablaDirecta(sentencia);
            return dt;

        }
            


        protected void ButtonID_Click(object sender, EventArgs e)
        {
            string id = TextBoxIDE.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt = CargarDatosDB(condicion);
            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("nombre");
                TextBoxNombre.Text = nombre;
            }
            else
            {
                TextBoxNombre.Text = "No hay informacion en la numeracion";
            }

        }

        protected void ButtonBuscarName_Click(object sender, EventArgs e)
        {
            string nombre = TextBoxNombre.Text.Trim();
            string condicion = $"('%{nombre}%')";
            DataTable dt = CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<Int32>("correlativo");
                TextBoxIDE.Text = id+"";
            }
            else
            {
                TextBoxIDE.Text = "No hay resultados";
            }

        }
    }
}