using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Front
{
    public class VariablesEditorial
    {
        static string idEditorial ="";
        static string nombreEditorial ="";
        static string telefono ="";
        static string direccion = "";
        static string ciudad = "";

        public static string IdEditorial { get => idEditorial; set => idEditorial = value; }
        public static string NombreEditorial { get => nombreEditorial; set => nombreEditorial = value; }
        public static string Telefono { get => telefono; set => telefono = value; }
        public static string Direccion { get => direccion; set => direccion = value; }
        public static string Ciudad { get => ciudad; set => ciudad = value; }
    }
}
