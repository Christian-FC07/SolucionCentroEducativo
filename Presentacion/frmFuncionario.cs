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
    public partial class frmManFuncionario : Form
    {

        #region Constructor
        public frmManFuncionario()
        {
            InitializeComponent();
            CargaCombo();
            CargarFuncionarios();     

        }

        #endregion

        #region Metodos
        private void CargaCombo() 
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nombre");
            dt.Columns.Add("Contraseña");

            dt.Rows.Add("true", "Activo");
            dt.Rows.Add("false", "Inactivo");

            cmbEstado.DataSource = dt;
            cmbEstado.DisplayMember = "Contraseña";
            cmbEstado.ValueMember = "Nombre";
            cmbEstado.Refresh();
            cmbEstado.SelectedIndex = 0;
        }
       
        private void CargarFuncionarios()
        {
            List<Funcionario> resultado = UsuarioLN.Consultar(new Funcionario());          

            dgvFuncionarios.DataSource = resultado;
            dgvFuncionarios.Refresh();
        }

       
        private void Limpiar()
        {

            txtNombreFuncio.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtPuesto.Text = string.Empty;
            txtNombreFuncio.Focus();
            txtNombreFuncio.ReadOnly = false;

            cmbEstado.SelectedIndex = 0;

        }
        #endregion

        #region Eventos

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones.ValidarEspaciosEnBlanco(new Validador { Valor = txtNombreFuncio.Text.Trim() }))
                {
                    MessageBox.Show(Constantes.ValidacionCampoEnBlanco, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreFuncio.Focus();
                    return;
                }
                else if (Validaciones.ValidarEspaciosEnBlanco(new Validador { Valor = txtClave.Text.Trim() }))
                {
                    MessageBox.Show(Constantes.ValidacionCampoEnBlanco, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Focus();
                    return;
                }
                          
                
                Funcionario f = new Funcionario
                {
                    Nombre = txtNombreFuncio.Text.Trim(),
                    Contraseña = txtClave.Text.Trim(),
                    Puesto = txtPuesto.Text.Trim(),
                    Estado = Convert.ToBoolean(cmbEstado.SelectedValue.ToString()),
                };

                if (UsuarioLN.Agregar(f))
                    MessageBox.Show(Constantes.AccionAgregar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarFuncionarios();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario f = new Funcionario
                {
                    Nombre = txtNombreFuncio.Text.Trim(),
                    Contraseña = txtClave.Text.Trim(),
                    Puesto = txtPuesto.Text.Trim(),
                    Estado = Convert.ToBoolean(cmbEstado.SelectedValue.ToString()),
                };

                if (UsuarioLN.Modificar(f))
                    MessageBox.Show(Constantes.AccionModificar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarFuncionarios();
                Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario f = new Funcionario
                {
                    Nombre = txtNombreFuncio.Text.Trim(),

                };

                if (UsuarioLN.Eliminar(f))
                    MessageBox.Show(Constantes.AccionEliminar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarFuncionarios();
                Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreFuncio.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtClave.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPuesto.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbEstado.SelectedValue = Convert.ToBoolean(dgvFuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtNombreFuncio.ReadOnly = true;
            }
            catch
            {
            }
        }

        #endregion

        
    }
}
