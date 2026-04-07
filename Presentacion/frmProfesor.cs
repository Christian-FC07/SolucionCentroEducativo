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
    public partial class frmProfesor : Form
    {
        public frmProfesor()
        {
            InitializeComponent();
            CargaCombo();
            CargarProfesor();
        }
        private void CargaCombo()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nombre");
            dt.Columns.Add("Contraseña");

            dt.Rows.Add("true", "Activo");
            dt.Rows.Add("false", "Inactivo");

            cmbEstadoProfesor.DataSource = dt;
            cmbEstadoProfesor.DisplayMember = "Contraseña";
            cmbEstadoProfesor.ValueMember = "Nombre";
            cmbEstadoProfesor.Refresh();
            cmbEstadoProfesor.SelectedIndex = 0;
        }

        private void CargarProfesor()
        {
            List<Profesor> resultado = UsuarioLN.Consultar(new Profesor());

            dgvProfesor.DataSource = resultado;
            dgvProfesor.Refresh();
        }


        private void Limpiar()
        {

            txtNombreProfesor.Text = string.Empty;
            txtCorreoProfesor.Text = string.Empty;
            txtTelefonoProfesor.Text = string.Empty;
            txtNombreProfesor.Focus();
            txtNombreProfesor.ReadOnly = false;

            cmbEstadoProfesor.SelectedIndex = 0;

        }


        #region Eventos

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones.ValidarEspaciosEnBlanco(new Validador { Valor = txtNombreProfesor.Text.Trim() }))
                {
                    MessageBox.Show(Constantes.ValidacionCampoEnBlanco, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreProfesor.Focus();
                    return;
                }
                else if (Validaciones.ValidarEspaciosEnBlanco(new Validador { Valor = txtCorreoProfesor.Text.Trim() }))
                {
                    MessageBox.Show(Constantes.ValidacionCampoEnBlanco, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreoProfesor.Focus();
                    return;
                }

                Profesor prof = new Profesor
                {
                    Nombre = txtNombreProfesor.Text.Trim(),
                    Correo = txtCorreoProfesor.Text.Trim(),
                    Telefono = txtTelefonoProfesor.Text.Trim(),
                    Estado = Convert.ToBoolean(cmbEstadoProfesor.SelectedValue.ToString()),
                };

                if (UsuarioLN.Agregar(prof))
                    MessageBox.Show(Constantes.AccionAgregar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarProfesor();
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
                Profesor prof = new Profesor
                {
                    Nombre = txtNombreProfesor.Text.Trim(),
                    Correo = txtCorreoProfesor.Text.Trim(),
                    Telefono = txtTelefonoProfesor.Text.Trim(),
                    Estado = Convert.ToBoolean(cmbEstadoProfesor.SelectedValue.ToString()),
                };

                if (UsuarioLN.Modificar(prof))
                    MessageBox.Show(Constantes.AccionModificar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarProfesor();
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
                Profesor prof = new Profesor
                {
                    Nombre = txtNombreProfesor.Text.Trim(),

                };

                if (UsuarioLN.Eliminar(prof))
                    MessageBox.Show(Constantes.AccionEliminar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarProfesor();
                Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvProfesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreProfesor.Text = dgvProfesor.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCorreoProfesor.Text = dgvProfesor.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTelefonoProfesor.Text = dgvProfesor.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbEstadoProfesor.SelectedValue = Convert.ToBoolean(dgvProfesor.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtNombreProfesor.ReadOnly = true;
            }
            catch
            {

            }
        }
        #endregion
    }
}
