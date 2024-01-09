using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Front
{
    public class VariablesUsuario
    {
        static string idUsuario="";
        static string TipoUsuario="";
        static string nombreUsuario="";

        public static string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public static string TipoUsuario1 { get => TipoUsuario; set => TipoUsuario = value; }
        public static string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
    }
}
