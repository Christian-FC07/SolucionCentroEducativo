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
    public partial class frmAula : Form
    {
        private int aulaID = -1;
        
        public frmAula()
        {
            InitializeComponent();
            CargaCombo();
            CargarAula();
        }
        private void CargaCombo()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nombre");
            dt.Columns.Add("Contraseña");

            dt.Rows.Add("Perfecto", "Perfecto");
            dt.Rows.Add("Regular", "Regular");
            dt.Rows.Add("Mal", "Mal");

            cmbEstadoAula.DataSource = dt;
            cmbEstadoAula.DisplayMember = "Contraseña";
            cmbEstadoAula.ValueMember = "Nombre";
            cmbEstadoAula.Refresh();
            cmbEstadoAula.SelectedIndex = 0;
        }

        private void CargarAula()
        {
            List<Aula> resultado = UsuarioLN.Consultar(new Aula());

            dgvAula.DataSource = resultado;
            dgvAula.Refresh();
        }


        private void Limpiar()
        {
            numNumeroAula.Value = 0;
            txtUbicacionAula.Text = string.Empty;
            cmbEstadoAula.SelectedIndex = 0;
            aulaID = -1;
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
                if (Validaciones.ValidarEspaciosEnBlanco(new Validador { Valor = txtUbicacionAula.Text.Trim() }))
                {
                    MessageBox.Show(Constantes.ValidacionCampoEnBlanco, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUbicacionAula.Focus();
                    return;
                }

                Aula au = new Aula
                {
                    Numero = (int)numNumeroAula.Value,
                    Ubicacion = txtUbicacionAula.Text.Trim(),
                    Estado = cmbEstadoAula.SelectedValue.ToString(),
                };

                if (UsuarioLN.Agregar(au))
                    MessageBox.Show(Constantes.AccionAgregar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarAula();
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
                Aula au = new Aula
                {
                    ID_Aula = aulaID,
                    Numero = (int)numNumeroAula.Value,
                    Ubicacion = txtUbicacionAula.Text.Trim(),
                    Estado = cmbEstadoAula.SelectedValue.ToString(),
                };

                if (UsuarioLN.Modificar(au))
                    MessageBox.Show(Constantes.AccionModificar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarAula();
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
                Aula au = new Aula
                {
                    ID_Aula = aulaID
                };

                if (UsuarioLN.Eliminar(au))
                    MessageBox.Show(Constantes.AccionEliminar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarAula();
                Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvAula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aulaID = Convert.ToInt32(dgvAula.Rows[e.RowIndex].Cells[0].Value.ToString());
                numNumeroAula.Value = Convert.ToInt32(dgvAula.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtUbicacionAula.Text = dgvAula.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbEstadoAula.SelectedValue = dgvAula.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        #endregion
    }
}
