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
    public class NEdtitorial
    {

        public static DataTable ObtenEditoriales()
        {
            return DEditorial.ObtenEditoriales();
        }
        public static DataTable ObtenEditorialesFiltro(string filtro)
        {
            return DEditorial.ObtenEditorialesFiltro(filtro);
        }

        public static string BuscarNombreEditorial(string nombreEditorial)
        {
            return DEditorial.BuscarNombreEditorial(nombreEditorial).Equals("0")
                ? "NO EXISTE" : "EXISTE";
        }
    

        public static string Agrega(EEditorial editorial)
        {
            return DEditorial.BuscarNombreEditorial(editorial.NombreEditorial).Equals("0") ? DEditorial.Agregar(editorial) : "REPETIDO";
        }
        
        public static string Modifica(EEditorial editorial)
        {
            return DEditorial.BuscarNombreEditorial(editorial.NombreEditorial).Equals("0") ? DEditorial.Modifica(editorial):"Error al ingresar a los datos";
        }
        public static string Modifica2(EEditorial editorial)
        {
            return DEditorial.Modifica(editorial);
        }
    }
}
