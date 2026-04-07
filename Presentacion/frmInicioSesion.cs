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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario 
                {
                    Nombre = txtUsuario.Text.Trim(),
                    Contraseña = txtContraseña.Text.Trim()
                };

                Funcionario resultado = UsuarioLN.Autentificacion(funcionario);
                if(resultado != null)
                {
                    if(resultado.Nombre.Length > 0)
                    {
                        frmMenu frm = new frmMenu();
                        frm.UsuarioConectado = resultado;
                        frm.CargarOpciones();
                        frm.Show();
                        Hide();
                    }
                    else
                        MessageBox.Show(Constantes.ValidacionAutenticacionError, Constantes.TituloInicioSesion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(Constantes.AccionError, Constantes.TituloInicioSesion, MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }

        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void ClickCambioUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistrarUsuario frm = new frmRegistrarUsuario();
            frm.ShowDialog();
        }
    }
}
