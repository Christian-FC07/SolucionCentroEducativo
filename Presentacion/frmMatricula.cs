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

namespace Presentacion
{
    public partial class frmMatriculaN : Form
    {
        private int matriculaID = -1;
        List<Estudiantes> resultadoEstudiante;
        List<Materias> resultadoMaterias;
        List<Matricula> resultadoMatriculas;

        public frmMatriculaN()
        {
            InitializeComponent();
            CargarCombosPantalla();
        }

        private void CargarCombosPantalla()
        {
            cmbEstudianteAsociacion.SelectedIndexChanged -= cmbEstudianteAsociacion_SelectedIndexChanged;

            resultadoEstudiante = UsuarioLN.Consultar(new Estudiantes());
            resultadoEstudiante.Add(new Estudiantes { Nombre = "Seleccione" });

            cmbEstudianteAsociacion.DataSource = resultadoEstudiante;
            cmbEstudianteAsociacion.DisplayMember = "Nombre";
            cmbEstudianteAsociacion.ValueMember = "Nombre";
            cmbEstudianteAsociacion.Refresh();
            cmbEstudianteAsociacion.SelectedIndex = resultadoEstudiante.Count - 1;

            cmbEstudianteAsociacion.SelectedIndexChanged += cmbEstudianteAsociacion_SelectedIndexChanged;

            cmbMateriaAsociacion.SelectedIndexChanged -= cmbMateriaAsociacion_SelectedIndexChanged;
            resultadoMaterias = UsuarioLN.Consultar(new Materias());
            resultadoMaterias.Add(new Materias { Nombre = "Seleccione" });

            cmbMateriaAsociacion.DataSource = resultadoMaterias;
            cmbMateriaAsociacion.DisplayMember = "Nombre";
            cmbMateriaAsociacion.ValueMember = "Nombre";
            cmbMateriaAsociacion.Refresh();
            cmbMateriaAsociacion.SelectedIndex = resultadoMaterias.Count - 1;
            cmbMateriaAsociacion.SelectedIndexChanged += cmbMateriaAsociacion_SelectedIndexChanged;
        }

        private void CargarMatriculasEstudiante()
        {
            if (cmbEstudianteAsociacion.SelectedValue != null && cmbEstudianteAsociacion.SelectedValue.ToString() != "Seleccione")
            {
                Estudiantes estudianteSeleccionado = (Estudiantes)cmbEstudianteAsociacion.SelectedItem;
                Matricula ma = new Matricula
                {
                    ID_Estudiante = estudianteSeleccionado.ID_Estudiante
                };
                resultadoMatriculas = UsuarioLN.Consultar(ma);

                DataTable dt = new DataTable();
                dt.Columns.Add("ID_Matricula", typeof(int));
                dt.Columns.Add("Dia_Matricula", typeof(DateTime));
                dt.Columns.Add("Materia", typeof(string));
                dt.Columns.Add("Estudiante", typeof(string));
                dt.Columns.Add("Estado", typeof(bool));

                foreach (var m in resultadoMatriculas)
                {
                    DataRow row = dt.NewRow();
                    row["ID_Matricula"] = m.ID_Matricula;
                    row["Dia_Matricula"] = m.Dia_Matricula;
                    row["Materia"] = ObtenerMateria(m.ID_Materia).Nombre;
                    row["Estudiante"] = ObtenerEstudiante(m.ID_Estudiante).Nombre;
                    row["Estado"] = m.Estado;
                    dt.Rows.Add(row);
                }

                dgvAsociacionPerfilUsuario.DataSource = dt;
                dgvAsociacionPerfilUsuario.Refresh();
            }
            else
            {
                dgvAsociacionPerfilUsuario.DataSource = null;
                dgvAsociacionPerfilUsuario.Refresh();
            }
        }

        private void CargarMateria()
        {
            if (cmbMateriaAsociacion.SelectedValue != null && cmbMateriaAsociacion.SelectedValue.ToString() != "Seleccione")
            {
                Materias materia = (Materias)cmbMateriaAsociacion.SelectedItem;
                Profesor profesor = UsuarioLN.ConsultarProfesor(new Profesor { ID_Profesor = materia.ID_Profesor });
                Horarios horario = UsuarioLN.ConsultarHorario(new Horarios { ID_Horario = materia.ID_Horario });
                Aula aula = UsuarioLN.ConsultarAula(new Aula { ID_Aula = materia.ID_Aula });
                txtHorarioMatricula.Text = horario.Hora_inicio.ToString();
                txtProfesorMatricula.Text = profesor.Nombre;
                txtAulaMatricula.Text = aula.Ubicacion;
            } else
            {
                txtHorarioMatricula.Text = string.Empty;
                txtProfesorMatricula.Text = string.Empty;
                txtAulaMatricula.Text = string.Empty;
            }
        }

        private void cmbEstudianteAsociacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMatriculasEstudiante();
        }

        private void cmbMateriaAsociacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMateria();
        }

        private void bntAgregarAsociacion_Click(object sender, EventArgs e)
        {
            if (cmbEstudianteAsociacion.SelectedValue.ToString() == "Seleccione" ||
                cmbMateriaAsociacion.SelectedValue.ToString() == "Seleccione" ||
                (!cbSiAsociacion.Checked && !cbNoAsociacion.Checked))
            {
                MessageBox.Show("Debe seleccionar todas las opciones y una opción de estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Materias materiaSeleccionada = (Materias)cmbMateriaAsociacion.SelectedItem;
            Estudiantes estudianteSeleccionado = (Estudiantes)cmbEstudianteAsociacion.SelectedItem;
            Matricula m = new Matricula
            {
                ID_Materia = materiaSeleccionada.ID_Materia,
                ID_Estudiante = estudianteSeleccionado.ID_Estudiante,
                Estado = cbSiAsociacion.Checked
            };

            UsuarioLN.Agregar(m);
            CargarMatriculasEstudiante();
            MessageBox.Show("Se genero la matricula con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarAsociacion_Click(object sender, EventArgs e)
        {
            if (cmbEstudianteAsociacion.SelectedValue.ToString() == "Seleccione" ||
                cmbMateriaAsociacion.SelectedValue.ToString() == "Seleccione" ||
                (!cbSiAsociacion.Checked && !cbNoAsociacion.Checked))
            {
                MessageBox.Show("Debe seleccionar todas las opciones y una opción de estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Materias materiaSeleccionada = (Materias)cmbMateriaAsociacion.SelectedItem;
            Estudiantes estudianteSeleccionado = (Estudiantes)cmbEstudianteAsociacion.SelectedItem;
            Matricula m = new Matricula
            {
                ID_Matricula = matriculaID,
                ID_Materia = materiaSeleccionada.ID_Materia,
                ID_Estudiante = estudianteSeleccionado.ID_Estudiante,
                Estado = cbSiAsociacion.Checked
            };
            UsuarioLN.Modificar(m);
            CargarMatriculasEstudiante();
            MessageBox.Show("Se modifico la matricula con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarAsociacion_Click(object sender, EventArgs e)
        {
            if (cmbEstudianteAsociacion.SelectedValue.ToString() == "Seleccione" ||
                cmbMateriaAsociacion.SelectedValue.ToString() == "Seleccione" ||
                (!cbSiAsociacion.Checked && !cbNoAsociacion.Checked))
            {
                MessageBox.Show("Debe seleccionar todas las opciones y una opción de estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Matricula m = new Matricula
            {
                ID_Matricula = matriculaID,
            };

            UsuarioLN.Eliminar(m);
            CargarMatriculasEstudiante();
            MessageBox.Show("Se elimino con exito la matricula.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvAsociacionPerfilUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                matriculaID = Convert.ToInt32(dgvAsociacionPerfilUsuario.Rows[e.RowIndex].Cells[0].Value.ToString());
                Matricula matricula = ObtenerMatricula(matriculaID);
                Materias materia = ObtenerMateria(matricula.ID_Materia);
                cmbMateriaAsociacion.SelectedItem = materia;
                bool estado = dgvAsociacionPerfilUsuario.Rows[e.RowIndex].Cells[4].Value.ToString() == "True";
                if (estado)
                {
                    cbSiAsociacion.Checked = true;
                    cbNoAsociacion.Checked = false;
                } else
                {
                    cbNoAsociacion.Checked = true;
                    cbSiAsociacion.Checked = false;
                }
            }
            catch (Exception ex)
            {}
        }

        private void cbSiAsociacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSiAsociacion.Checked)
            {
                cbNoAsociacion.Checked = false;
            }
        }

        private void cbNoAsociacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoAsociacion.Checked)
            {
                cbSiAsociacion.Checked = false;
            }
        }

        private Matricula ObtenerMatricula(int id)
        {
            Matricula matricula = resultadoMatriculas.FirstOrDefault(m => m.ID_Matricula == id);
            return matricula;
        }

        private Materias ObtenerMateria(int id)
        {
            Materias materia = resultadoMaterias.FirstOrDefault(m => m.ID_Materia == id);
            return materia;
        }

        private Estudiantes ObtenerEstudiante(int id)
        {
            Estudiantes estudiante = resultadoEstudiante.FirstOrDefault(e => e.ID_Estudiante == id);
            return estudiante;
        }
    }
}