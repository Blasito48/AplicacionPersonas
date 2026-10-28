using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public static string cadena = "Server=localhost;Port=3306;Database=bd_empresa;Uid=root;Pwd=root;";
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
        //funcion Insertar
        //parametros: id,nombre,telefono
        //retorno: true o false
        public static bool Func_Insertar(long id, string name, string tel)
        {
            try
            {
                //creo la conexion con su cadena de conexion    
                MySqlConnection con = new MySqlConnection(cadena);
                //creo la consulta SQL
                string Sql = "Insert Into tbl_persona (id_persona,nombre,telefono) Values (" + id + ",'" + name + "','" + tel + "');";
                //creo el comando con su consulta SQL y su conexion
                MySqlCommand cmd = new MySqlCommand(Sql, con);
                //abro la conexion
                con.Open();
                //ejecuto la consulta SQL con el comando
                cmd.ExecuteNonQuery();
                //cierro la conexion
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return false;
            }
        }
        //Funcion Traer Todos los Datos
        //parametros: Ninguno
        //retorna: DataTable
        public static DataTable Func_TraerTodo()
        {
            //creo una tabla vacia
            DataTable dt = new DataTable();
            try
            {
                //creo la conexion con su cadena de conexion    
                MySqlConnection con = new MySqlConnection(cadena);
                //creo la consulta SQL
                string Sql = "Select * From tbl_persona;";
                //creo el comando con su consulta SQL y su conexion
                MySqlCommand cmd = new MySqlCommand(Sql, con);
                //abro la conexion
                con.Open();
                //crea un DataReader en Memoria
                MySqlDataReader dr = cmd.ExecuteReader();
                //cargo la tabla con el DataReader
                dt.Load(dr);
                //cierro la conexion
                con.Close();
                return dt;
            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return dt;
            }
        }
        //funcion Elminar
        //parametros: id
        //retorno: true o false
        public static bool Func_Eliminar(long id)
        {
            try
            {
                //creo la conexion con su cadena de conexion    
                MySqlConnection con = new MySqlConnection(cadena);
                //creo la consulta SQL
                string Sql = "Delete From tbl_persona Where id_persona="+id;
                //creo el comando con su consulta SQL y su conexion
                MySqlCommand cmd = new MySqlCommand(Sql, con);
                //abro la conexion
                con.Open();
                //ejecuto la consulta SQL con el comando
                cmd.ExecuteNonQuery();
                //cierro la conexion
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
