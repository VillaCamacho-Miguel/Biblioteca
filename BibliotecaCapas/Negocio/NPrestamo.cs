using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos;
using Biblioteca.Entidades;
using System.Data;

namespace Biblioteca.Negocio
{
    public class NPrestamo
    {
     public static DataTable ObtenPrestamos()
        {
            return DPrestamo.ObtenPrestamos();
        }
        public static string BuscarClave(string clavePrestamo)
        {
            return DPrestamo.BuscarClave(clavePrestamo).Equals("0") ? "NO REPITE":"CLAVE REPETIDA";
        }
        public static string AgregarPrestamo(EPrestamo prestamo)
        {
            return DPrestamo.VerificaExistencia(prestamo.NombreLibro).Equals("1") ? DPrestamo.AgregaPrestamo(prestamo) : "Verificar Existencias del libro!";
        }
        public static string VerificaUsuarios(char usuarioLibro, char usuario)
        {
            return DPrestamo.VerificaUsuarios(usuarioLibro, usuario).Equals("1") ? "CORRECTO":"Libro es para otro tipo de usuario";
        }
        public static string VerificaFecha(DateTime fecha)
        {
            return DPrestamo.VerificaFecha(fecha).Equals("1") ? "CORRECTO" : "fecha incorrecta";
        }

    }
}
