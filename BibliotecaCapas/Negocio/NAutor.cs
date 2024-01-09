using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos;
using System.Data;
using Biblioteca.Entidades;
namespace Biblioteca.Negocio
{
    public class NAutor
    {
        public static DataTable ObtenAutores()
        {
            return DAutor.ObtenAutores();
        }
       
        public static DataTable ObtenAutoresFiltro(string val)
        {
            return DAutor.ObtenAutoresFiltro(val);
        }
        public static string BuscarNombreAutor(string NombreAutor)
        {
            return DAutor.BuscarNombreAutor(NombreAutor).Equals("1") ? "EXISTE" : "PROCEDE";
        }

        public static string Agrega(EAutor autor)
        {
            return DAutor.BuscarNombreAutor(autor.NombreAutor1).Equals("0") ? DAutor.Agrega(autor) : "REPETIDO";
        }
        public static string Modifica(EAutor autor)
        {
            return DAutor.BuscarNombreAutor(autor.NombreAutor1).Equals("0") ? DAutor.Modifica(autor) : "REPETIDO";
        }
        public static string ModificaSoloNacio(EAutor autor)
        {
            return DAutor.Modifica(autor);
        }


    }
}
