using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Biblioteca.Datos
{
    public class Utilerias
    {
        public static DataTable ObtenTabla(string procedimiento)
        {

            SqlDataReader lector = null;
            SqlConnection conn = null;
            DataTable tabla = new DataTable();
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand(procedimiento, conn);
                comando.CommandType = CommandType.StoredProcedure;
                lector = comando.ExecuteReader();
                tabla.Load(lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

     

        public static DataTable ObtenTablaFiltro(string procedimiento, string filtro)
        {

            SqlDataReader lector = null;
            SqlConnection conn = null;
            DataTable tabla = new DataTable();
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand(procedimiento, conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = filtro;
                lector = comando.ExecuteReader();
                tabla.Load(lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
       
    }
}
