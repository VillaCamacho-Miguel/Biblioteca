using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;
namespace Biblioteca.Negocio
{
    public class NUsuario
    {
        public static DataTable ObtenUsuarios()
        {
            return DUsuario.ObtenUsuarios();
        }
        public static DataTable ObtenUsuarioFiltro(string txt)
        {
            return DUsuario.ObtenUsuarioFiltro(txt);
        }
        

        public static string Agrega(EUsuario usuario)
        {
            return DUsuario.Agregar(usuario);
        }

        public static string Modifica(EUsuario usuario)
        {
            return DUsuario.Modifica(usuario);
        }
        public static DataTable ObtenUsuariosMasActivos()
        {
            return DUsuario.ObtenUsuariosMasActivos();
        }


    }
}
