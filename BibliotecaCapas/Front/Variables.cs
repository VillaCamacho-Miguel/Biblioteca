using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Front
{
   public class Variables
    {

        
        //Libro
        static string nombreLibro;
        static string clave;
        static string existencia;
        static string consulta;
        static string tipoDeUsuario;
        static string autor;
        static string editorial;
       
       
        public static string Clave { get => clave; set => clave = value; }
        public static string Existencia { get => existencia; set => existencia = value; }
        public static string NombreLibro { get => nombreLibro; set => nombreLibro = value; }
        //Libro
      
        public static string Consulta { get => consulta; set => consulta = value; }
        public static string TipoDeUsuario { get => tipoDeUsuario; set => tipoDeUsuario = value; }
        public static string Autor { get => autor; set => autor = value; }
        public static string Editorial { get => editorial; set => editorial = value; }
    }
}
