using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//uso la libreria de conexion a MySQL
using MySql.Data.MySqlClient;

namespace AplicacionPersonas
{
    public class ClaseFunciones
    {
        //cadena de conexion
        public static string cadena = "Server=localhost;Database=bd_empresa;Uid=root;Pwd=root;";
        //mensaje de excepcion
        public static string excepcion = "";
        //funcion conectar
        //devuelve ?
        //parametros ?
        public static bool Func_Conectar()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return false;
            }
        }
    }
}
