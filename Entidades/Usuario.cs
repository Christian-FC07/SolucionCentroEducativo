using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int Codigo_Usuario {  get; set; }
        public string Descripcion { get; set; }
        public bool Estado {  get; set; }      
        public Usuario() 
        {
            Codigo_Usuario = 0;
            Descripcion = string.Empty;
            Estado = true;
        }
    }
}
