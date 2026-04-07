using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmReporteria : Form
    {
        private Dictionary<string, string> opcionesReporte;
        private ComboBox cmbEstudiantes;
        private Label lblEstudiante;

        public frmReporteria()
        {
            InitializeComponent();
            CargarCombosReporteria();
            cmbConsultarReporte.SelectedIndexChanged += cmbConsultarReporte_SelectedIndexChanged;
        }

        private void CargarCombosReporteria()
        {
            opcionesReporte = new Dictionary<string, string>
            {
                { "Funcionarios Activos del Sistema", "FuncionariosActivos" },
                { "Funcionarios Inactivos del Sistema", "FuncionariosInactivos" },
                { "Estudiantes Activos del Sistema", "EstudiantesActivos" },
                { "Estudiantes Inactivos del Sistema", "EstudiantesInactivos" },
                { "Profesores Activos del Sistema", "ProfesoresActivos" },
                { "Profesores Inactivos del Sistema", "ProfesoresInactivos" },
                { "Aulas en estado Perfecto del sistema", "AulasPerfecto" },
                { "Aulas en estado Regular del sistema", "AulasRegular" },
                { "Aulas en estado Mal del sistema", "AulasMal" },
                { "Materias matriculadas por estudiante", "MateriasPorEstudiante" }
            };

            DataTable dt = new DataTable();
            dt.Columns.Add("NombreMostrar");
            dt.Columns.Add("Valor");

            foreach (var opcion in opcionesReporte)
            {
                dt.Rows.Add(opcion.Key, opcion.Value);
            }

            cmbConsultarReporte.DataSource = dt;
            cmbConsultarReporte.DisplayMember = "NombreMostrar";
            cmbConsultarReporte.ValueMember = "Valor";
            cmbConsultarReporte.Refresh();
        }

        private void cmbConsultarReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConsultarReporte.SelectedValue != null)
            {
                string valorSeleccionado = cmbConsultarReporte.SelectedValue.ToString();
                ManejarSeleccionCambio(valorSeleccionado);
            }
        }

        private void ManejarSeleccionCambio(string valorSeleccionado)
        {
            if (valorSeleccionado == "MateriasPorEstudiante")
            {
                MostrarComboBoxEstudiantes();
            }
            else
            {
                OcultarComboBoxEstudiantes();
            }
        }

        private void MostrarComboBoxEstudiantes()
        {
            if (cmbEstudiantes == null)
            {
                cmbEstudiantes = new ComboBox
                {
                    Location = new System.Drawing.Point(160, 60),
                    Size = new System.Drawing.Size(200, 21)
                };
                this.Controls.Add(cmbEstudiantes);

                List<Estudiantes> estudiantes = UsuarioLN.Consultar(new Estudiantes());
                cmbEstudiantes.DataSource = estudiantes;
                cmbEstudiantes.DisplayMember = "Nombre";
                cmbEstudiantes.ValueMember = "Nombre";
            }
            else
            {
                cmbEstudiantes.Visible = true;
            }

            if (lblEstudiante == null)
            {
                lblEstudiante = new Label
                {
                    Text = "Estudiante:",
                    Location = new System.Drawing.Point(60, 60),
                    Size = new System.Drawing.Size(100, 21)
                };
                this.Controls.Add(lblEstudiante);
            }
            else
            {
                lblEstudiante.Visible = true;
            }
        }

        private void OcultarComboBoxEstudiantes()
        {
            if (cmbEstudiantes != null)
            {
                cmbEstudiantes.Visible = false;
            }

            if (lblEstudiante != null)
            {
                lblEstudiante.Visible = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbConsultarReporte.SelectedValue != null)
            {
                string valorSeleccionado = cmbConsultarReporte.SelectedValue.ToString();
                List<object> resultado = ObtenerResultadoConsulta(valorSeleccionado);

                if (resultado != null)
                {
                    dgvReporteria.DataSource = null;
                    dgvReporteria.Columns.Clear();
                    dgvReporteria.DataSource = resultado;
                   
                }
            }
        }

        private List<object> ObtenerResultadoConsulta(string valorSeleccionado)
        {
            try
            {

                switch (valorSeleccionado)
                {
                    case "FuncionariosActivos":
                        return UsuarioLN.Consultar(new Funcionario()).Where(f => f.Estado).ToList<object>();

                    case "FuncionariosInactivos":
                        return UsuarioLN.Consultar(new Funcionario()).Where(f => !f.Estado).ToList<object>();

                    case "EstudiantesActivos":
                        return UsuarioLN.Consultar(new Estudiantes()).Where(es => es.Estado).ToList<object>();

                    case "EstudiantesInactivos":
                        return UsuarioLN.Consultar(new Estudiantes()).Where(es => !es.Estado).ToList<object>();

                    case "ProfesoresActivos":
                        return UsuarioLN.Consultar(new Profesor()).Where(p => p.Estado).ToList<object>();

                    case "ProfesoresInactivos":
                        return UsuarioLN.Consultar(new Profesor()).Where(p => !p.Estado).ToList<object>();

                    case "AulasPerfecto":
                        return UsuarioLN.Consultar(new Aula()).Where(a => a.Estado == "Perfecto").ToList<object>();

                    case "AulasRegular":
                        return UsuarioLN.Consultar(new Aula()).Where(a => a.Estado == "Regular").ToList<object>();

                    case "AulasMal":
                        return UsuarioLN.Consultar(new Aula()).Where(a => a.Estado == "Mal").ToList<object>();

                    case "MateriasPorEstudiante":
                        return ObtenerMateriasPorEstudiante();

                    default:
                        return new List<object>();
                }
            }
            catch (Exception ex)
            {
                return new List<object>(); 
            }
        }

        private List<object> ObtenerMateriasPorEstudiante()
        {
            if (cmbEstudiantes != null && cmbEstudiantes.SelectedValue != null)
            {
                Estudiantes estudianteSeleccionado = (Estudiantes)cmbEstudiantes.SelectedItem;
                Matricula matricula = new Matricula
                {
                    ID_Estudiante = estudianteSeleccionado.ID_Estudiante
                };
                return UsuarioLN.Consultar(matricula).ToList<object>();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un estudiante.");
                return null;
            }
        }
    }
}