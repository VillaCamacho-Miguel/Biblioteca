using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibreriaBD;
using System.Configuration;
namespace Biblioteca.Datos
{
    public class Conexion
    {

        public static SqlConnection CrearConexion()
        {
            string strConn = getConnectionString(); //"Data Source =DESKTOP-7BIVPA2; Initial Catalog = biblioteca; Integrated Security = True";
            SqlConnection con = UsoBD.ConectaBD(strConn);
            return con;
        }
        public static string getConnectionString()
        {
            string strConn = "";
            try
            {
                //este lo encuentras en el xml (App.Config)
                strConn = ConfigurationManager.ConnectionStrings["conStrBD"].ConnectionString;
            }
            catch (Exception)
            {
                throw;
            }
            return strConn;
        }
    }
}
