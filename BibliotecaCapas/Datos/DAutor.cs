using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Entidades;
using System.Data;
using System.Data.SqlClient;
namespace Biblioteca.Datos
{
    public class DAutor
    {
        public static DataTable ObtenAutores()
        {
            return Utilerias.ObtenTabla("SP_ObtenAutores");
        }
        public static DataTable ObtenAutoresFiltro(string val)
        {
            return Utilerias.ObtenTablaFiltro("SP_ObtenAutoresFiltro", val);
        }

        public static string BuscarNombreAutor(string NombreAutor)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_NombreAutorRepetido", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = NombreAutor;
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

        public static string Agrega(EAutor autor)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_AgregaAutor", conn);
                comando.CommandType = CommandType.StoredProcedure;

                //Insertar
                comando.Parameters.AddWithValue("@nombreAutor", autor.NombreAutor1);
                comando.Parameters.AddWithValue("@nacionalidad", autor.Nacionalidad1);
               
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
        public static string Modifica(EAutor autor)
        {

            SqlConnection conn = null;
            string rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_modificaAutor", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@idAutor", SqlDbType.Int).Value = autor.IdAutor;
                comando.Parameters.Add("@nombreAutor", SqlDbType.Char, 25).Value = autor.NombreAutor1;
                comando.Parameters.Add("@nacionalidad", SqlDbType.VarChar, 30).Value = autor.Nacionalidad1;
              
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "Error al ingresar a los datos";


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


    }
}
