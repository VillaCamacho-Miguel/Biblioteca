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
    public class DLibro
    {

        public static DataTable ObtenLibros()
        {
            return Utilerias.ObtenTabla("SP_ObtenerLibros");
        }
        public static DataTable ObtenLibrosPopulares()
        {
            return Utilerias.ObtenTabla("SP_LibrosMasPopulares");
        }
        public static DataTable ObtenLibrosMasExistencia()
        {
            return Utilerias.ObtenTabla("SP_ObtenerLibrosMasExistencia");
        }
        public static DataTable ObtenLibrosIndividual(string val)
        {
            SqlDataReader lector = null;
            SqlConnection conn = null;
            DataTable tabla = new DataTable();
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ObtenDatoIndividual", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@isbn", SqlDbType.Char, 13).Value = val;
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
        public static DataTable ObtenLibrosFiltro(string txt)
        {

            SqlDataReader lector = null;
            SqlConnection conn = null;
            DataTable tabla = new DataTable();
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ObtenerLibrosFiltro", conn);
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = txt;
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
        public static string BuscarNombreLibro(string NombreLibro)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_LibroExiste", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor",SqlDbType.VarChar).Value=NombreLibro;
                
                comando.Parameters.Add("@existe",SqlDbType.Int).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(comando.Parameters["@existe"].Value);


                /*
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                 */

               // Rpta = Convert.ToString(parExiste.Value);
            }
            catch (Exception)
            {
                throw;
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
        
        public static string BuscarISBN(string ISBN)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ExisteISBN", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = ISBN;
                comando.Parameters.Add("@existe", SqlDbType.Int).Direction = ParameterDirection.Output;
                /*  
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                */
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(comando.Parameters["@existe"].Value);
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
        public static string Agregar(ELibro libro)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_InsertarLibro", conn);
                comando.CommandType = CommandType.StoredProcedure;

                //Insertar
                comando.Parameters.AddWithValue("@ISBN",libro.ISBN1);
                comando.Parameters.AddWithValue("@nombreLibro", libro.NombreLibro1);
                comando.Parameters.AddWithValue("@Existencia", libro.Existencia);
                comando.Parameters.AddWithValue("@Consulta", libro.Consula1);
                comando.Parameters.AddWithValue("@TipoUsuario", libro.TipoUsuario1);
                comando.Parameters.AddWithValue("@idAutor", libro.idAutor1);
                comando.Parameters.AddWithValue("@idEditorial", libro.idEditorial1);

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
    public static string Modifica(ELibro libro)
        {

            SqlConnection conn = null;
            string rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ModificarLibro", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@isbn", SqlDbType.Char, 13).Value = libro.ISBN1;
                comando.Parameters.Add("@nombrelibro", SqlDbType.VarChar, 30).Value = libro.NombreLibro1;
                comando.Parameters.Add("@existencia", SqlDbType.Int).Value = libro.Existencia;
                comando.Parameters.Add("@consulta", SqlDbType.Char, 1).Value = libro.Consula1;
                comando.Parameters.Add("@tipousuario", SqlDbType.Char, 1).Value = libro.TipoUsuario1;
                comando.Parameters.Add("@idautor", SqlDbType.VarChar).Value = libro.IdAutorAux;
                comando.Parameters.Add("@ideditorial", SqlDbType.VarChar).Value = libro.IdEditorialAux;
                rpta = comando.ExecuteNonQuery() == 1 ? "OK": "Error al ingresar a los datos\n Verificar Existencias del libro";


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
            return rpta;
        }

        // PARA VERIFICAR QUE NO HAYA LLAVES FORANEAS
        public static string ValidaEliminacion(string ISBN)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ValidaEliminacionLibro", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@isbn", SqlDbType.Char, 13).Value = ISBN;
                comando.Parameters.Add("@existeConflicto", SqlDbType.Int).Direction = ParameterDirection.Output;
                /*  
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                */
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(comando.Parameters["@existeConflicto"].Value);
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
        public static string Elimina(string ISBN)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_EliminaLibro", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@isbn", SqlDbType.Char, 13).Value = ISBN;

                Rpta = comando.ExecuteNonQuery() >= 1 ? "ELIMINADO":"Error al ingresar a los datos";
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

    }
}
