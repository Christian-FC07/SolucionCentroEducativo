using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios;

namespace Presentacion
{
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
              Funcionario objfuncionario = new Funcionario
            {
                Nombre = txtNombre.Text.Trim(), 
                Contraseña = txtContraseña.Text.Trim(),
                Puesto = txtPuesto.Text.Trim(),
                Estado = true
            };

            if(UsuarioLN.Agregar(objfuncionario))
            {
                MessageBox.Show(Constantes.AccionAgregar, Constantes.TituloRegistro, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmInicioSesion frm = new frmInicioSesion();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(Constantes.AccionError, Constantes.TituloRegistro, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
