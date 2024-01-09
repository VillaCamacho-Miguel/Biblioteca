using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class EPrestamo
    {
        private string clavePrestamo;
        private string nombreLibro;
        private string Usuario;
        private DateTime fechaDevolucion;
        private char consulta;
        public EPrestamo(string clavePrestamo, string nombreLibro, string usuario, DateTime fechaDevolucion, char consulta)
        {
            this.clavePrestamo = clavePrestamo;
            this.nombreLibro = nombreLibro;
            this.Consulta = consulta;
            Usuario = usuario;
            this.fechaDevolucion = fechaDevolucion;
        }

        public string ClavePrestamo { get => clavePrestamo; set => clavePrestamo = value; }
        public string NombreLibro { get => nombreLibro; set => nombreLibro = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public char Consulta { get => consulta; set => consulta = value; }
    }
}
