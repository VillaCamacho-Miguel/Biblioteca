using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Entidades;
using System.Data.SqlClient;
using System.Data;
namespace Biblioteca.Datos
{
    public class DEditorial
    {

        public static DataTable ObtenEditoriales()
        {
            return Utilerias.ObtenTabla("SP_ObtenEditoriales");
        }
        public static DataTable ObtenEditorialesFiltro(string filtro)
        {
            return Utilerias.ObtenTablaFiltro("SP_ObtenEditorialesFiltro", filtro);
        }
        public static string BuscarNombreEditorial(string NombreEditorial)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_nombreEditorialExiste", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = NombreEditorial;
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
        public static string Agregar(EEditorial editorial)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_AgregarEditorial", conn);
                comando.CommandType = CommandType.StoredProcedure;

                //Insertar
                comando.Parameters.AddWithValue("@nombre", editorial.NombreEditorial);
                comando.Parameters.AddWithValue("@telefono", editorial.Telefono);
                comando.Parameters.AddWithValue("@direccion", editorial.Direccion);
                comando.Parameters.AddWithValue("@ciudad", editorial.Ciudad);
                
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

        public static string Modifica(EEditorial editorial)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("SP_modificarEditorial", conn);
                comando.CommandType = CommandType.StoredProcedure;

                //Insertar
                comando.Parameters.AddWithValue("@clave", editorial.IdEditorial);
                comando.Parameters.AddWithValue("@nombre", editorial.NombreEditorial);
                comando.Parameters.AddWithValue("@telefono", editorial.Telefono);
                comando.Parameters.AddWithValue("@direccion", editorial.Direccion);
                comando.Parameters.AddWithValue("@ciudad", editorial.Ciudad);

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
