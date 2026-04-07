using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Utilitarios;

namespace Presentacion
{
    public partial class frmHorarios : Form
    {
        private int horarioID = -1;

        public frmHorarios()
        {
            InitializeComponent();
            CargaCombo();
            CargarHorarios();
        }

        private void CargaCombo()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Dia");
            dt.Columns.Add("Hora");
        }

        private void CargarHorarios()
        {
            List<Horarios> resultado = UsuarioLN.Consultar(new Horarios());

            dgvHorarios.DataSource = resultado;
            dgvHorarios.Refresh();
        }

        private void Limpiar()
        {
            timePickerDia.Value = DateTime.Now;
            timePickerHoraInicio.Value = DateTime.Now;
            timePickerHoraFin.Value = DateTime.Now;
            timePickerDia.Focus();
            timePickerDia.Enabled = true;
            horarioID = -1;
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
                if (Validaciones.ValidarEspaciosEnBlanco(new Validador { Valor = timePickerDia.Text.Trim() }))
                {
                    MessageBox.Show(Constantes.ValidacionCampoEnBlanco, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    timePickerDia.Focus();
                    return;
                }
                else if (Validaciones.ValidarEspaciosEnBlanco(new Validador { Valor = timePickerHoraInicio.Text.Trim() }))
                {
                    MessageBox.Show(Constantes.ValidacionCampoEnBlanco, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    timePickerHoraInicio.Focus();
                    return;
                }

                Horarios hor = new Horarios
                {
                    Dia = timePickerDia.Value.Date.ToString("yyyy-MM-dd"),
                    Hora_inicio = timePickerHoraInicio.Value.TimeOfDay,
                    Hora_fin = timePickerHoraFin.Value.TimeOfDay,
                };

                if (UsuarioLN.Agregar(hor))
                    MessageBox.Show(Constantes.AccionAgregar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarHorarios();
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
                Horarios hor = new Horarios
                {
                    ID_Horario = horarioID,
                    Dia = timePickerDia.Value.Date.ToString("yyyy-MM-dd"),
                    Hora_inicio = timePickerHoraInicio.Value.TimeOfDay,
                    Hora_fin = timePickerHoraFin.Value.TimeOfDay,
                };

                if (UsuarioLN.Modificar(hor))
                    MessageBox.Show(Constantes.AccionModificar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarHorarios();
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
                Horarios hor = new Horarios
                {
                    Dia = timePickerDia.Value.Date.ToString("yyyy-MM-dd"),
                    Hora_inicio = timePickerHoraInicio.Value.TimeOfDay,
                    Hora_fin = timePickerHoraFin.Value.TimeOfDay,
                };

                if (UsuarioLN.Eliminar(hor))
                    MessageBox.Show(Constantes.AccionEliminar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarHorarios();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            horarioID = int.Parse(dgvHorarios.Rows[e.RowIndex].Cells[0].Value.ToString());
            timePickerDia.Value = DateTime.Parse(dgvHorarios.Rows[e.RowIndex].Cells[1].Value.ToString());
            timePickerHoraInicio.Value = DateTime.Parse(dgvHorarios.Rows[e.RowIndex].Cells[2].Value.ToString());
            timePickerHoraFin.Value = DateTime.Parse(dgvHorarios.Rows[e.RowIndex].Cells[3].Value.ToString());
            timePickerDia.Enabled = false;
        }
        #endregion
    }
}