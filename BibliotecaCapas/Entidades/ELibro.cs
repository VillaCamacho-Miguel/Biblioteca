using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    
    public class ELibro
    {

        private string ISBN;
        private string NombreLibro;
        private int idAutor;
        private string idAutorAux;
        private int idEditorial;
        private string idEditorialAux;
        private byte existencia;
        private char Consula;
        private char TipoUsuario;

        public ELibro(string iSBN, string nombreLibro, byte existencia, char consula, char tipoUsuario, int idAutor, int idEditorial)
        {
            ISBN1 = iSBN;
            NombreLibro1 = nombreLibro;
           this.idAutor = idAutor;
            this.idEditorial = idEditorial;
            this.Existencia = existencia;
            Consula1 = consula;
            TipoUsuario1 = tipoUsuario;
        }
        public ELibro(string iSBN, string nombreLibro, byte existencia, char consula, char tipoUsuario, string idAutor, string idEditorial)
        {
            ISBN1 = iSBN;
            NombreLibro1 = nombreLibro;
            this.idAutorAux = idAutor;
            this.idEditorialAux = idEditorial;
            this.Existencia = existencia;
            Consula1 = consula;
            TipoUsuario1 = tipoUsuario;
        }

        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string NombreLibro1 { get => NombreLibro; set => NombreLibro = value; }
        public int idAutor1 { get => idAutor; set => idAutor = value; }
        public int idEditorial1 { get => idEditorial; set => idEditorial = value; }
        public byte Existencia { get => existencia; set => existencia = value; }
        public char Consula1 { get => Consula; set => Consula = value; }
        public char TipoUsuario1 { get => TipoUsuario; set => TipoUsuario = value; }
        public string IdEditorialAux { get => idEditorialAux; set => idEditorialAux = value; }
        public string IdAutorAux { get => idAutorAux; set => idAutorAux = value; }
    }
}
