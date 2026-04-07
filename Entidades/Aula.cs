using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        #region Aulas
        public int ID_Aula { get; set; }
        public int Numero { get; set; }
        public string Ubicacion { get; set; }
        public string Estado { get; set; }

        #endregion

        #region Constructor
        public Aula()
        {
            ID_Aula = 0;
            Numero = 0;
            Ubicacion = string.Empty;
            Estado = string.Empty;
        }
        #endregion
    }
}
