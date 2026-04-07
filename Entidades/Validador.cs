using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    #region Propiedad
    public class Validador
    {
        public string Valor { get; set; }
        public string Patron { get; set; }

        #endregion

        #region Constructor

        public Validador()
        {
            Valor = string.Empty;
            Patron = string.Empty;
        }
        #endregion
    }
}
