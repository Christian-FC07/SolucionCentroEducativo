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
    public partial class frmMaterias : Form
    {
        private int materiaID = -1;
        List<Profesor> resultadoProfesor;
        List<Horarios> resultadoHorarios;
        List<Aula> resultadoAula;
        List<Materias> resultadoMaterias;

        public frmMaterias()
        {
            InitializeComponent();
            CargaCombo();
            CargarMaterias();
        }

        private void CargaCombo()
        {
            resultadoProfesor = UsuarioLN.Consultar(new Profesor());
            resultadoProfesor.Add(new Profesor { Nombre = "Seleccione" });

            cmbProfesorMateria.DataSource = resultadoProfesor;
            cmbProfesorMateria.DisplayMember = "Nombre";
            cmbProfesorMateria.ValueMember = "Nombre";
            cmbProfesorMateria.Refresh();
            cmbProfesorMateria.SelectedIndex = resultadoProfesor.Count - 1;

            resultadoHorarios = UsuarioLN.Consultar(new Horarios());

            cmbHorarioMateria.DataSource = resultadoHorarios;
            cmbHorarioMateria.DisplayMember = "Horario";
            cmbHorarioMateria.ValueMember = "Hora_inicio";
            cmbHorarioMateria.Refresh();
            cmbHorarioMateria.SelectedIndex = resultadoHorarios.Count - 1;

            resultadoAula = UsuarioLN.Consultar(new Aula());

            cmbAulaMateria.DataSource = resultadoAula;
            cmbAulaMateria.DisplayMember = "Ubicacion";
            cmbAulaMateria.ValueMember = "Ubicacion";
            cmbAulaMateria.Refresh();
            cmbAulaMateria.SelectedIndex = resultadoAula.Count - 1;
        }

        private void CargarMaterias()
        {
            resultadoMaterias = UsuarioLN.Consultar(new Materias());

            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Materia", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Profesor", typeof(string));
            dt.Columns.Add("Ubicacion", typeof(string));
            dt.Columns.Add("Horario", typeof(string));

            foreach (var m in resultadoMaterias)
            {
                DataRow row = dt.NewRow();
                row["ID_Materia"] = m.ID_Materia;
                row["Nombre"] = m.Nombre;
                row["Descripcion"] = m.Descripcion;
                row["Profesor"] = ObtenerProfesor(m.ID_Profesor)?.Nombre ?? "N/A";
                row["Ubicacion"] = ObtenerAula(m.ID_Aula)?.Ubicacion ?? "N/A";
                row["Horario"] = ObtenerHorario(m.ID_Horario)?.Hora_inicio.ToString() ?? "N/A";
                dt.Rows.Add(row);
            }

            dgvMaterias.DataSource = dt;
            dgvMaterias.Refresh();
        }


        private void Limpiar()
        {

            txtNombreCurso.Text = string.Empty;
            txtDescripcionCurso.Text = string.Empty;           
            CargaCombo();
            materiaID = -1;

        }

        private bool ValidarCampos()
        {
            if (cmbProfesorMateria.SelectedIndex == -1 || cmbProfesorMateria.SelectedItem == null || ((Profesor)cmbProfesorMateria.SelectedItem).Nombre == "Seleccione")
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, seleccione un profesor.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProfesorMateria.Focus();
                return false;
            }

            if (cmbHorarioMateria.SelectedIndex == -1 || cmbHorarioMateria.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, seleccione un horario.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHorarioMateria.Focus();
                return false;
            }

            if (cmbAulaMateria.SelectedIndex == -1 || cmbAulaMateria.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, seleccione un aula.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAulaMateria.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreCurso.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, ingrese el nombre del curso.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCurso.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionCurso.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, ingrese la descripción del curso.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcionCurso.Focus();
                return false;
            }

            return true;
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
                if (!ValidarCampos()) return;
                Profesor profesorSeleccionado = (Profesor)cmbProfesorMateria.SelectedItem;
                Horarios horarioSeleccionado = (Horarios)cmbHorarioMateria.SelectedItem;
                Aula aulaSeleccionada = (Aula)cmbAulaMateria.SelectedItem;

                Materias mat = new Materias
                {
                    Nombre = txtNombreCurso.Text.Trim(),
                    Descripcion = txtDescripcionCurso.Text.Trim(),
                    ID_Profesor = profesorSeleccionado.ID_Profesor,
                    ID_Aula = aulaSeleccionada.ID_Aula,
                    ID_Horario = horarioSeleccionado.ID_Horario,
                };

                if (UsuarioLN.Agregar(mat))
                    MessageBox.Show(Constantes.AccionAgregar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarMaterias();
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
                if (!ValidarCampos()) return;
                Profesor profesorSeleccionado = (Profesor)cmbProfesorMateria.SelectedItem;
                Horarios horarioSeleccionado = (Horarios)cmbHorarioMateria.SelectedItem;
                Aula aulaSeleccionada = (Aula)cmbAulaMateria.SelectedItem;

                Materias mat = new Materias
                {
                    ID_Materia = materiaID,
                    Nombre = txtNombreCurso.Text.Trim(),
                    Descripcion = txtDescripcionCurso.Text.Trim(),
                    ID_Profesor = profesorSeleccionado.ID_Profesor,
                    ID_Aula = aulaSeleccionada.ID_Aula,
                    ID_Horario = horarioSeleccionado.ID_Horario,
                };

                if (UsuarioLN.Modificar(mat))
                    MessageBox.Show(Constantes.AccionModificar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarMaterias();
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
                if (!ValidarCampos()) return;
                Materias est = new Materias
                {
                    ID_Materia = materiaID
                };

                if (UsuarioLN.Eliminar(est))
                    MessageBox.Show(Constantes.AccionEliminar, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Constantes.AccionError, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarMaterias();
                Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constantes.TituloMantenimiento, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                materiaID = Convert.ToInt32(dgvMaterias.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNombreCurso.Text = dgvMaterias.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcionCurso.Text = dgvMaterias.Rows[e.RowIndex].Cells[2].Value.ToString();
                Materias materia = ObtenerMateria(materiaID);
                cmbProfesorMateria.SelectedItem = ObtenerProfesor(materia.ID_Profesor);
                cmbAulaMateria.SelectedItem = ObtenerAula(materia.ID_Aula);
                cmbHorarioMateria.SelectedItem = ObtenerHorario(materia.ID_Horario);
            }
            catch 
            {}
        }

        private Materias ObtenerMateria(int id)
        {
            Materias materia = resultadoMaterias.FirstOrDefault(m => m.ID_Materia == id);
            return materia;
        }

        private Profesor ObtenerProfesor(int id)
        {
            Profesor profesor = resultadoProfesor.FirstOrDefault(p => p.ID_Profesor == id);
            return profesor;
        }

        private Horarios ObtenerHorario(int id)
        {
            Horarios horario = resultadoHorarios.FirstOrDefault(h => h.ID_Horario == id);
            return horario;
        }

        private Aula ObtenerAula(int id)
        {
            Aula aula = resultadoAula.FirstOrDefault(a => a.ID_Aula == id);
            return aula;
        }

        #endregion

    }
}

