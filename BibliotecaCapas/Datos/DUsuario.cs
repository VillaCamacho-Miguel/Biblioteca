using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Entidades;
namespace Biblioteca.Datos
{
   public class DUsuario
    {

        public static DataTable ObtenUsuarios()
        {
            return Utilerias.ObtenTabla("SP_ObtenUsuarios");
        }
        public static DataTable ObtenUsuariosMasActivos()
        {
            return Utilerias.ObtenTabla("SP_UsuariosMasActivos");
        }


        public static DataTable ObtenUsuarioFiltro(string filtro)
        {
            return Utilerias.ObtenTablaFiltro("sp_FiltraUsuario", filtro);
        }
        public static string Agregar(EUsuario usuario)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_AgregarUsuario", conn);
                comando.CommandType = CommandType.StoredProcedure;

                //Insertar
                comando.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@tipoUsuario", usuario.TipoUsuario);
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "no se pudo ingresar al registro";


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return Rpta;
        }

        public static string Modifica(EUsuario usuario)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ModificarUsuario", conn);
                comando.CommandType = CommandType.StoredProcedure;

                //Insertar
                comando.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                comando.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@tipoUsuario", usuario.TipoUsuario);
                
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "no se pudo ingresar al registro";


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return Rpta;
        }
    }
}
