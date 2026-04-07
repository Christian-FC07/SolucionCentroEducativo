using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Matricula
    {
        #region Matricula
        public int ID_Matricula { get; set; }
        public DateTime Dia_Matricula { get; set; }
        public int ID_Materia { get; set; }
        public int ID_Estudiante { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region Constructor
        public Matricula()
        {
            ID_Matricula = 0;
            Dia_Matricula = DateTime.Now;
            ID_Materia = 0;
            ID_Estudiante = 0;
            Estado = true;
        }
        #endregion
    }
}
