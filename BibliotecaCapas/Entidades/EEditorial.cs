using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class EEditorial
    {
        private int idEditorial;
        private string nombreEditorial;
        private string telefono;
        private string direccion;
        private string ciudad;

        public EEditorial(int idEditorial, string nombreEditorial, string telefono, string direccion, string ciudad)
        {
            this.IdEditorial = idEditorial;
            this.NombreEditorial = nombreEditorial;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
        }
        public EEditorial(string nombreEditorial, string telefono, string direccion, string ciudad)
        {
            this.NombreEditorial = nombreEditorial;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
        }


        public int IdEditorial { get => idEditorial; set => idEditorial = value; }
        public string NombreEditorial { get => nombreEditorial; set => nombreEditorial = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
    }
}
