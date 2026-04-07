using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Horarios
    {
        #region Horarios
        public int ID_Horario { get; set; }
        public string Dia { get; set; }
        public TimeSpan Hora_inicio { get; set; }
        public TimeSpan Hora_fin { get; set; }

        #endregion

        #region Constructor
        public Horarios()
        {
            ID_Horario = 0;
            Dia = string.Empty;
            Hora_inicio = TimeSpan.MinValue;
            Hora_fin = TimeSpan.MinValue;
        }

        #endregion
    }
}
