using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Front
{
    public class VariablesAutor
    {
        static string idAutor="";
        static string nombreAutor="";
        static string nacionalidad="";

        public static string IdAutor { get => idAutor; set => idAutor = value; }
        public static string NombreAutor { get => nombreAutor; set => nombreAutor = value; }
        public static string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    }
}
