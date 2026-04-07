namespace Presentacion
{
    partial class frmAula
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
            this.dgvAula = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtUbicacionAula = new System.Windows.Forms.TextBox();
            this.lemail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numNumeroAula = new System.Windows.Forms.NumericUpDown();
            this.cmbEstadoAula = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroAula)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAula
            // 
            this.dgvAula.AllowUserToAddRows = false;
            this.dgvAula.AllowUserToDeleteRows = false;
            this.dgvAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAula.Location = new System.Drawing.Point(444, 66);
            this.dgvAula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAula.Name = "dgvAula";
            this.dgvAula.ReadOnly = true;
            this.dgvAula.RowHeadersVisible = false;
            this.dgvAula.RowHeadersWidth = 62;
            this.dgvAula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAula.Size = new System.Drawing.Size(513, 309);
            this.dgvAula.TabIndex = 26;
            this.dgvAula.TabStop = false;
            this.dgvAula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAula_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(330, 334);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 57);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(238, 335);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 57);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 334);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 57);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(44, 334);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 57);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtUbicacionAula
            // 
            this.txtUbicacionAula.Location = new System.Drawing.Point(122, 88);
            this.txtUbicacionAula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUbicacionAula.Name = "txtUbicacionAula";
            this.txtUbicacionAula.Size = new System.Drawing.Size(208, 26);
            this.txtUbicacionAula.TabIndex = 2;
            // 
            // lemail
            // 
            this.lemail.AutoSize = true;
            this.lemail.Location = new System.Drawing.Point(14, 25);
            this.lemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lemail.Name = "lemail";
            this.lemail.Size = new System.Drawing.Size(69, 20);
            this.lemail.TabIndex = 1;
            this.lemail.Text = "Numero:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numNumeroAula);
            this.groupBox1.Controls.Add(this.cmbEstadoAula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUbicacionAula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lemail);
            this.groupBox1.Location = new System.Drawing.Point(42, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(372, 257);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // numNumeroAula
            // 
            this.numNumeroAula.Location = new System.Drawing.Point(122, 22);
            this.numNumeroAula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numNumeroAula.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numNumeroAula.Name = "numNumeroAula";
            this.numNumeroAula.Size = new System.Drawing.Size(210, 26);
            this.numNumeroAula.TabIndex = 27;
            // 
            // cmbEstadoAula
            // 
            this.cmbEstadoAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoAula.FormattingEnabled = true;
            this.cmbEstadoAula.Location = new System.Drawing.Point(122, 160);
            this.cmbEstadoAula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEstadoAula.Name = "cmbEstadoAula";
            this.cmbEstadoAula.Size = new System.Drawing.Size(208, 28);
            this.cmbEstadoAula.TabIndex = 6;
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ubicacion:";
            // 
            // frmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1008, 451);
            this.Controls.Add(this.dgvAula);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroAula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAula;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtUbicacionAula;
        private System.Windows.Forms.Label lemail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstadoAula;
        private System.Windows.Forms.NumericUpDown numNumeroAula;
    }
}