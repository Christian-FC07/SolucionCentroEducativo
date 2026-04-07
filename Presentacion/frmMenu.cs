using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utilitarios;

namespace Presentacion
{
    public partial class frmMenu : Form
    {
        public Funcionario UsuarioConectado  { get; set; }

        public frmMenu()
        {
            InitializeComponent();
        }

        public void CargarOpciones()
        {
            tssl_usuarioconectado.Text = UsuarioConectado.Nombre;  
           
            mantenimietoToolStripMenuItem.Visible = false;
            procesosToolStripMenuItem.Visible = false;
            consultasToolStripMenuItem.Visible = false;
            
            List<Usuario> resultado = UsuarioLN.Autorizacion(UsuarioConectado);   
            resultado.ForEach(Usuario =>
            {                 
                switch (Usuario.Codigo_Usuario)
                {                    
                    //Ventana Mantenimiento
                    case 1: {
                            mantenimietoToolStripMenuItem.Visible = true;
                        } break;
                    //Ventana Procesos
                    case 2: {
                            procesosToolStripMenuItem.Visible = true; 
                        } break;
                    //Ventana Consultas
                    case 3: { 
                            consultasToolStripMenuItem.Visible= true;
                        } break;
                }
            });
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existe = MdiChildren.ToList().Find(x => x.Name.Equals("frmManFuncionario"));

            if (existe == null)
            {
                frmManFuncionario frm = new frmManFuncionario();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show(Constantes.ValidacionAperturaOpcionMenu, Constantes.TituloMenuPrincipal, MessageBoxButtons.OK,MessageBoxIcon.Warning);
           
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicioSesion frm = new frmInicioSesion();
            frm.Show();
            Hide();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existe = MdiChildren.ToList().Find(x => x.Name.Equals("frmManFuncionario")); 

            if (existe == null)
            {
                frmEstudiante frm = new frmEstudiante();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
                MessageBox.Show(Constantes.ValidacionAperturaOpcionMenu, Constantes.TituloMenuPrincipal, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existe = MdiChildren.ToList().Find(x => x.Name.Equals("frmManFuncionario")); 

            if (existe == null)
            {
                frmHorarios frm = new frmHorarios();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
                MessageBox.Show(Constantes.ValidacionAperturaOpcionMenu, Constantes.TituloMenuPrincipal, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existe = MdiChildren.ToList().Find(x => x.Name.Equals("frmManFuncionario")); 

            if (existe == null)
            {
                frmMaterias frm = new frmMaterias();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show(Constantes.ValidacionAperturaOpcionMenu, Constantes.TituloMenuPrincipal, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existe = MdiChildren.ToList().Find(x => x.Name.Equals("frmManFuncionario")); 

            if (existe == null)
            {
                frmProfesor frm = new frmProfesor();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show(Constantes.ValidacionAperturaOpcionMenu, Constantes.TituloMenuPrincipal, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void matriculaNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existe = MdiChildren.ToList().Find(x => x.Name.Equals("frmMatriculaN")); 

            if (existe == null)
            {
                frmMatriculaN frm = new frmMatriculaN();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show(Constantes.ValidacionAperturaOpcionMenu, Constantes.TituloMenuPrincipal, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void reporteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existe = MdiChildren.ToList().Find(x => x.Name.Equals("frmReporteria"));

            if (existe == null)
            {
                frmReporteria frm = new frmReporteria();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show(Constantes.ValidacionAperturaOpcionMenu, Constantes.TituloMenuPrincipal, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existe = MdiChildren.ToList().Find(x => x.Name.Equals("frmManAula"));

            if (existe == null)
            {
                frmAula frm = new frmAula();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show(Constantes.ValidacionAperturaOpcionMenu, Constantes.TituloMenuPrincipal, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
