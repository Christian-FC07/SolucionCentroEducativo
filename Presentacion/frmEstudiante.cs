using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios;

namespace Presentacion
{
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
            CargaCombo();
            CargarEstudiantes();
        }

        private void CargaCombo()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nombre");
            dt.Columns.Add("Contraseña");

            dt.Rows.Add("true", "Activo");
            dt.Rows.Add("false", "Inactivo");

            cmbEstadoEstudiante.DataSource = dt;
            cmbEstadoEstudiante.DisplayMember = "Contraseña";
            cmbEstadoEstudiante.ValueMember = "Nombre";
            cmbEstadoEstudiante.Refresh();
            cmbEstadoEstudiante.SelectedIndex = 0;
        }

        private void CargarEstudiantes()
        {
            List<Estudiantes> resultado = UsuarioLN.Consultar(new Estudiantes());

            dgvEstudiante.DataSource = resultado;
            dgvEstudiante.Refresh();
        }


        private void Limpiar()
        {

            txtNombreEstudiante.Text = string.Empty;
            txtemailEstudiante.Text = string.Empty;
            txtTelefonoEstudiante.Text = string.Empty;
            txtNombreEstudiante.Focus();
            txtNombreEstudiante.ReadOnly = false;

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
                if (Validaciones.ValidarEspaciosEnBlanco(new Validador { Valor = txtNombreEstudiante.Text.Trim() }))
                {
                    MessageBox.Show(Constantes.ValidacionCampoEnBlanco, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreEstudiante.Focus();
                    return;
                }
                else if (Validaciones.ValidarEspaciosEnBlanco(new Validador { Valor = txtemailEstudiante.Text.Trim() }))
                {
                    MessageBox.Show(Constantes.ValidacionCampoEnBlanco, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtemailEstudiante.Focus();
                    return;
                }         

                Estudiantes est = new Estudiantes
                {
                    Nombre = txtNombreEstudiante.Text.Trim(),
                    Correo = txtemailEstudiante.Text.Trim(),
                    Telefono = txtTelefonoEstudiante.Text.Trim(),
                    Estado = Convert.ToBoolean(cmbEstadoEstudiante.SelectedValue.ToString()),
                };

                if (UsuarioLN.Agregar(est))
                    MessageBox.Show(Constantes.AccionAgregar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarEstudiantes();
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
                Estudiantes est = new Estudiantes
                {
                    Nombre = txtNombreEstudiante.Text.Trim(),
                    Correo = txtemailEstudiante.Text.Trim(),
                    Telefono = txtTelefonoEstudiante.Text.Trim(),
                    Estado = Convert.ToBoolean(cmbEstadoEstudiante.SelectedValue.ToString()),
                };

                if (UsuarioLN.Modificar(est))
                    MessageBox.Show(Constantes.AccionModificar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarEstudiantes();
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
                Estudiantes est = new Estudiantes
                {
                    Nombre = txtNombreEstudiante.Text.Trim(),

                };

                if (UsuarioLN.Eliminar(est))
                    MessageBox.Show(Constantes.AccionEliminar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarEstudiantes();
                Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreEstudiante.Text = dgvEstudiante.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtemailEstudiante.Text = dgvEstudiante.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTelefonoEstudiante.Text = dgvEstudiante.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbEstadoEstudiante.SelectedValue = Convert.ToBoolean(dgvEstudiante.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtNombreEstudiante.ReadOnly = true;
            } catch
            {

            }
        }
        #endregion

    }
}
