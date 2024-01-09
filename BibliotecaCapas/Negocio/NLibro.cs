using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Biblioteca.Datos;
using Biblioteca.Entidades;


namespace Biblioteca.Negocio
{
    public class NLibro
    {
        public static DataTable ObtenLibros()
        {
            return DLibro.ObtenLibros();
        }
        public static DataTable ObtenLibrosIndividual(string val)
        {
            return DLibro.ObtenLibrosIndividual(val);
        }
        public static DataTable ObtenLibrosPopulares()
        {
            return DLibro.ObtenLibrosPopulares();
        }
        public static DataTable ObtenLibrosMasExistencia()
        {
            return DLibro.ObtenLibrosMasExistencia();
        }
        
        // public static DataTable ObtenerAutores()
        //{
        //   return 
        //}
        public static string BuscarNombreLibro(string nombreLibro)
        {
            string respuesta = "NO EXISTE";
            string retorno = DLibro.BuscarNombreLibro(nombreLibro);
            if (retorno.Equals("1")) respuesta = "YA EXISTE";
            return respuesta;
        }
        public static string Agregar(ELibro libro)
        {
           // string existe = DLibro.BuscarISBN(libro.ISBN1);
            return DLibro.BuscarISBN(libro.ISBN1).Equals("0")
                ? DLibro.Agregar(libro) : "YA EXISTE";
          //  if (existe.Equals("0")) return DLibro.Agregar(libro);
           // else return "YA EXISTE";
        }
        public static string modifica(ELibro libro)
        {
            return DLibro.Modifica(libro);
        }
        public static string modifica2(ELibro libro)
        {
            return DLibro.BuscarISBN(libro.NombreLibro1).Equals("0") ? DLibro.Modifica(libro) : "Libro Existe";
        }
        public static string validaEliminacion(string id)
        {
            return DLibro.ValidaEliminacion(id).Equals("1") ? "EXISTE" : "PROCEDE";
        }
        public static string Elimina(string id)
        {
            return  DLibro.ValidaEliminacion(id).Equals("1") ? " Conflicto con llave heredada(hay un libro prestado) ":DLibro.Elimina(id);
        }
        public static string BuscarISBNLibro(string ISBN)
        {
            /*
             * string respuesta = "NO EXISTE";
             * string retorno = DLibro.BuscarISBN(ISBN);
             * if(retorno.Equals("1")) respuesta = "YA EXISTE";
             * return respuesta;
             */
            return DLibro.BuscarISBN(ISBN).Equals("1") ? "YA EXISTE":"NO EXISTE";
        }
     public static DataTable ObtenLibrosFiltro(string txt)
        {
            return DLibro.ObtenLibrosFiltro(txt);

        }
    }
}
