namespace Presentacion
{
    partial class frmReporteria
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConsultarReporte = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvReporteria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Reporte:";
            // 
            // cmbConsultarReporte
            // 
            this.cmbConsultarReporte.FormattingEnabled = true;
            this.cmbConsultarReporte.Location = new System.Drawing.Point(161, 32);
            this.cmbConsultarReporte.Margin = new System.Windows.Forms.Padding(2);
            this.cmbConsultarReporte.Name = "cmbConsultarReporte";
            this.cmbConsultarReporte.Size = new System.Drawing.Size(227, 21);
            this.cmbConsultarReporte.TabIndex = 0;
            this.cmbConsultarReporte.SelectedIndexChanged += new System.EventHandler(this.cmbConsultarReporte_SelectedIndexChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(411, 25);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(79, 34);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvReporteria
            // 
            this.dgvReporteria.AllowUserToAddRows = false;
            this.dgvReporteria.AllowUserToDeleteRows = false;
            this.dgvReporteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteria.Location = new System.Drawing.Point(59, 88);
            this.dgvReporteria.Name = "dgvReporteria";
            this.dgvReporteria.ReadOnly = true;
            this.dgvReporteria.RowHeadersVisible = false;
            this.dgvReporteria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporteria.Size = new System.Drawing.Size(471, 315);
            this.dgvReporteria.TabIndex = 33;
            this.dgvReporteria.TabStop = false;
            // 
            // frmReporteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(583, 434);
            this.Controls.Add(this.dgvReporteria);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cmbConsultarReporte);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporteria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConsultarReporte;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvReporteria;
    }
}