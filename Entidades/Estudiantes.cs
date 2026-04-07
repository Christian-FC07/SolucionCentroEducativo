using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiantes
    {
        #region Estudiantes
        public int ID_Estudiante { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region Constructor
        public Estudiantes()
        {
            ID_Estudiante = 0;
            Nombre = string.Empty;
            Correo = string.Empty;
            Telefono = string.Empty;
            Estado = true;
        }
        #endregion
    }
}