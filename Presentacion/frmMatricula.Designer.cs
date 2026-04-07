namespace Presentacion
{
    partial class frmMatriculaN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProfesorMatricula = new System.Windows.Forms.TextBox();
            this.txtAulaMatricula = new System.Windows.Forms.TextBox();
            this.txtHorarioMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminarAsociacion = new System.Windows.Forms.Button();
            this.btnEditarAsociacion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bntAgregarAsociacion = new System.Windows.Forms.Button();
            this.cbNoAsociacion = new System.Windows.Forms.CheckBox();
            this.cbSiAsociacion = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstudianteAsociacion = new System.Windows.Forms.ComboBox();
            this.cmbMateriaAsociacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAsociacionPerfilUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsociacionPerfilUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProfesorMatricula);
            this.groupBox1.Controls.Add(this.txtAulaMatricula);
            this.groupBox1.Controls.Add(this.txtHorarioMatricula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnEliminarAsociacion);
            this.groupBox1.Controls.Add(this.btnEditarAsociacion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bntAgregarAsociacion);
            this.groupBox1.Controls.Add(this.cbNoAsociacion);
            this.groupBox1.Controls.Add(this.cbSiAsociacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbEstudianteAsociacion);
            this.groupBox1.Controls.Add(this.cmbMateriaAsociacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtProfesorMatricula
            // 
            this.txtProfesorMatricula.Location = new System.Drawing.Point(450, 109);
            this.txtProfesorMatricula.Name = "txtProfesorMatricula";
            this.txtProfesorMatricula.ReadOnly = true;
            this.txtProfesorMatricula.Size = new System.Drawing.Size(194, 20);
            this.txtProfesorMatricula.TabIndex = 17;
            // 
            // txtAulaMatricula
            // 
            this.txtAulaMatricula.Location = new System.Drawing.Point(128, 157);
            this.txtAulaMatricula.Name = "txtAulaMatricula";
            this.txtAulaMatricula.ReadOnly = true;
            this.txtAulaMatricula.Size = new System.Drawing.Size(174, 20);
            this.txtAulaMatricula.TabIndex = 16;
            // 
            // txtHorarioMatricula
            // 
            this.txtHorarioMatricula.Location = new System.Drawing.Point(128, 109);
            this.txtHorarioMatricula.Name = "txtHorarioMatricula";
            this.txtHorarioMatricula.ReadOnly = true;
            this.txtHorarioMatricula.Size = new System.Drawing.Size(174, 20);
            this.txtHorarioMatricula.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Aula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Profesor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "No";
            // 
            // btnEliminarAsociacion
            // 
            this.btnEliminarAsociacion.Location = new System.Drawing.Point(387, 233);
            this.btnEliminarAsociacion.Name = "btnEliminarAsociacion";
            this.btnEliminarAsociacion.Size = new System.Drawing.Size(54, 46);
            this.btnEliminarAsociacion.TabIndex = 8;
            this.btnEliminarAsociacion.Text = "Eliminar";
            this.btnEliminarAsociacion.UseVisualStyleBackColor = true;
            this.btnEliminarAsociacion.Click += new System.EventHandler(this.btnEliminarAsociacion_Click);
            // 
            // btnEditarAsociacion
            // 
            this.btnEditarAsociacion.Location = new System.Drawing.Point(299, 233);
            this.btnEditarAsociacion.Name = "btnEditarAsociacion";
            this.btnEditarAsociacion.Size = new System.Drawing.Size(54, 46);
            this.btnEditarAsociacion.TabIndex = 7;
            this.btnEditarAsociacion.Text = "Editar";
            this.btnEditarAsociacion.UseVisualStyleBackColor = true;
            this.btnEditarAsociacion.Click += new System.EventHandler(this.btnEditarAsociacion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Si";
            // 
            // bntAgregarAsociacion
            // 
            this.bntAgregarAsociacion.Location = new System.Drawing.Point(209, 233);
            this.bntAgregarAsociacion.Name = "bntAgregarAsociacion";
            this.bntAgregarAsociacion.Size = new System.Drawing.Size(54, 46);
            this.bntAgregarAsociacion.TabIndex = 6;
            this.bntAgregarAsociacion.Text = "Crear";
            this.bntAgregarAsociacion.UseVisualStyleBackColor = true;
            this.bntAgregarAsociacion.Click += new System.EventHandler(this.bntAgregarAsociacion_Click);
            // 
            // cbNoAsociacion
            // 
            this.cbNoAsociacion.AutoSize = true;
            this.cbNoAsociacion.Location = new System.Drawing.Point(197, 197);
            this.cbNoAsociacion.Name = "cbNoAsociacion";
            this.cbNoAsociacion.Size = new System.Drawing.Size(15, 14);
            this.cbNoAsociacion.TabIndex = 3;
            this.cbNoAsociacion.UseVisualStyleBackColor = true;
            this.cbNoAsociacion.CheckedChanged += new System.EventHandler(this.cbNoAsociacion_CheckedChanged);
            // 
            // cbSiAsociacion
            // 
            this.cbSiAsociacion.AutoSize = true;
            this.cbSiAsociacion.Location = new System.Drawing.Point(129, 197);
            this.cbSiAsociacion.Name = "cbSiAsociacion";
            this.cbSiAsociacion.Size = new System.Drawing.Size(15, 14);
            this.cbSiAsociacion.TabIndex = 2;
            this.cbSiAsociacion.UseVisualStyleBackColor = true;
            this.cbSiAsociacion.CheckedChanged += new System.EventHandler(this.cbSiAsociacion_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado Congelado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Horario:";
            // 
            // cmbEstudianteAsociacion
            // 
            this.cmbEstudianteAsociacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudianteAsociacion.FormattingEnabled = true;
            this.cmbEstudianteAsociacion.Location = new System.Drawing.Point(128, 47);
            this.cmbEstudianteAsociacion.Name = "cmbEstudianteAsociacion";
            this.cmbEstudianteAsociacion.Size = new System.Drawing.Size(174, 21);
            this.cmbEstudianteAsociacion.TabIndex = 0;
            this.cmbEstudianteAsociacion.SelectedIndexChanged += new System.EventHandler(this.cmbEstudianteAsociacion_SelectedIndexChanged);
            // 
            // cmbMateriaAsociacion
            // 
            this.cmbMateriaAsociacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaAsociacion.FormattingEnabled = true;
            this.cmbMateriaAsociacion.Location = new System.Drawing.Point(450, 47);
            this.cmbMateriaAsociacion.Name = "cmbMateriaAsociacion";
            this.cmbMateriaAsociacion.Size = new System.Drawing.Size(194, 21);
            this.cmbMateriaAsociacion.TabIndex = 4;
            this.cmbMateriaAsociacion.SelectedIndexChanged += new System.EventHandler(this.cmbMateriaAsociacion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante:";
            // 
            // dgvAsociacionPerfilUsuario
            // 
            this.dgvAsociacionPerfilUsuario.AllowUserToAddRows = false;
            this.dgvAsociacionPerfilUsuario.AllowUserToDeleteRows = false;
            this.dgvAsociacionPerfilUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsociacionPerfilUsuario.Location = new System.Drawing.Point(12, 333);
            this.dgvAsociacionPerfilUsuario.Name = "dgvAsociacionPerfilUsuario";
            this.dgvAsociacionPerfilUsuario.ReadOnly = true;
            this.dgvAsociacionPerfilUsuario.RowHeadersVisible = false;
            this.dgvAsociacionPerfilUsuario.RowHeadersWidth = 62;
            this.dgvAsociacionPerfilUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsociacionPerfilUsuario.Size = new System.Drawing.Size(668, 260);
            this.dgvAsociacionPerfilUsuario.TabIndex = 1;
            this.dgvAsociacionPerfilUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsociacionPerfilUsuario_CellClick);
            // 
            // frmMatriculaN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(693, 618);
            this.Controls.Add(this.dgvAsociacionPerfilUsuario);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMatriculaN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Matricula";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsociacionPerfilUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMateriaAsociacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAsociacionPerfilUsuario;
        private System.Windows.Forms.ComboBox cmbEstudianteAsociacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbNoAsociacion;
        private System.Windows.Forms.CheckBox cbSiAsociacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEliminarAsociacion;
        private System.Windows.Forms.Button btnEditarAsociacion;
        private System.Windows.Forms.Button bntAgregarAsociacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfesorMatricula;
        private System.Windows.Forms.TextBox txtAulaMatricula;
        private System.Windows.Forms.TextBox txtHorarioMatricula;
    }
}