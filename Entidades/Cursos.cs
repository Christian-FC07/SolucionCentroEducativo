using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cursos
    {
        #region Cursos
        public int ID_Curso { get; set; }
        public string Nombre { get; set; }
        public string Cupo { get; set; }
        public string ID_Horario { get; set; }
        public string ID_Profesor { get; set; }
        public string ID_Materia { get; set; }
        #endregion

        #region Constructor

        public Cursos(){
        ID_Curso = 0;
        Nombre = string.Empty;
        Cupo = string.Empty;
        ID_Horario = string.Empty;
        ID_Profesor = string.Empty;
        ID_Materia = string.Empty;
        }
        #endregion
    }

}
    

