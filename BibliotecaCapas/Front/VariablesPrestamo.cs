using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Front
{
    public class VariablesPrestamo
    {
        static string clavePrestamo = "";
        static string ISBN = "";
        static string idUsuario = "";
        static string fechaDevolucion = "";
        static string consulta = "";

        public static string ClavePrestamo { get => clavePrestamo; set => clavePrestamo = value; }
        public static string ISBN1 { get => ISBN; set => ISBN = value; }
        public static string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public static string FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public static string Consulta { get => consulta; set => consulta = value; }
    }
}
