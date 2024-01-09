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
    public class DPrestamo
    {
        
        public static DataTable ObtenPrestamos()
        {
            return Utilerias.ObtenTabla("SP_ObtenPrestamos");   
        }

        public static string VerificaExistencia(string nombreLibro)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_VerificaExistenciaPrestamo", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombreLibro", SqlDbType.VarChar).Value = nombreLibro;
                comando.Parameters.Add("@mensaje", SqlDbType.Int).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(comando.Parameters["@mensaje"].Value);
                return Rpta;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public static string AgregaPrestamo(EPrestamo prestamo)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_AgregarPrestamo", conn);
                comando.CommandType = CommandType.StoredProcedure;
                //insertar
                comando.Parameters.AddWithValue("@clavePrestamo", prestamo.ClavePrestamo);
                comando.Parameters.AddWithValue("@nombreLibro", prestamo.NombreLibro);
                comando.Parameters.AddWithValue("@Usuario", prestamo.Usuario1);
                comando.Parameters.AddWithValue("@fechaDevolucion", prestamo.FechaDevolucion);
                comando.Parameters.AddWithValue("@consulta", prestamo.Consulta);


                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK":"no se pudo ingresar al registro,\n Verificar Existencias";
                return Rpta;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }

        public static string BuscarClave(string clavePrestamo)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ClavePrestamoExiste", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = clavePrestamo;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(parExiste.Value);
            }
            catch (Exception)
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return Rpta;

        }
        public static string VerificaUsuarios(char usuarioLibro, char usuario)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_VerificarUsuarios", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@UsuarioLibro", SqlDbType.Char).Value = usuarioLibro;
                comando.Parameters.Add("@UsuarioTipo", SqlDbType.Char).Value = usuario;
                comando.Parameters.Add("@procede", SqlDbType.Int).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(comando.Parameters["@procede"].Value);
                return Rpta;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public static string VerificaFecha(DateTime fecha)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_VerificaFechaDevolucion", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
                comando.Parameters.Add("@procede", SqlDbType.Int).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(comando.Parameters["@procede"].Value);
                return Rpta;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

    }
}
