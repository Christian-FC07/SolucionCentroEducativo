using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materias
    {
        #region Materias
        public int ID_Materia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ID_Profesor { get; set; }
        public int ID_Aula { get; set; }
        public int ID_Horario { get; set; }

        #endregion

        #region Constructor
        public Materias()
        {
            ID_Materia = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            ID_Profesor = 0;
            ID_Aula = 0;
            ID_Horario  = 0;
        }
        #endregion
    }
}
