using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
   public class EAutor
    {
        private int idAutor;
        private string NombreAutor;
        private string Nacionalidad;

        public EAutor(int idAutor, string nombreAutor, string nacionalidad)
        {
            this.IdAutor = idAutor;
            NombreAutor1 = nombreAutor;
            Nacionalidad1 = nacionalidad;
        }
        public EAutor(string nombreAutor, string nacionalidad)
        {
            this.IdAutor = idAutor;
            NombreAutor1 = nombreAutor;
            Nacionalidad1 = nacionalidad;
        }

        public int IdAutor { get => idAutor; set => idAutor = value; }
        public string NombreAutor1 { get => NombreAutor; set => NombreAutor = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }
    }
}
