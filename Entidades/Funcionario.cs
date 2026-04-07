using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Funcionario
    {
        #region Funcionario
        public string Nombre { get; set; }
        public string Contraseña  { get; set; }
        public string Puesto { get; set; }
        public bool Estado { get; set; }

        public List<Funcionario> PerfilesAsociados { get; set; } 

        #endregion

        #region Constructor
        public Funcionario()
        {
            Nombre = string.Empty;
            Contraseña = string.Empty;
            Puesto = string.Empty;
            Estado = true;
            PerfilesAsociados = new List<Funcionario>();
        }
        #endregion

    }
}
