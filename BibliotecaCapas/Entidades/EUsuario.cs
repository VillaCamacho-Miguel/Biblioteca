using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class EUsuario
    {
       private int idUsuario;
       private string nombreUsuario;
       private char tipoUsuario;

        public EUsuario(int idUsuario, string nombreUsuario, char tipoUsuario)
        {
            this.IdUsuario = idUsuario;
            this.NombreUsuario = nombreUsuario;
            this.TipoUsuario = tipoUsuario;
        }
        public EUsuario(string nombreUsuario, char tipoUsuario)
        {
            this.NombreUsuario = nombreUsuario;
            this.TipoUsuario = tipoUsuario;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public char TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
    }
}
