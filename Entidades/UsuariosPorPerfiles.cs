using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuariosPorPerfiles
    {
        #region UsuariosPorPerfiles
        public string Nombre { get; set; }
        public string Codigo_Usuario { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region Constructor
            public UsuariosPorPerfiles()
        { 
            Nombre = string.Empty;
            Codigo_Usuario = string.Empty;
            Estado = true;
        }    
        #endregion
    }
}
