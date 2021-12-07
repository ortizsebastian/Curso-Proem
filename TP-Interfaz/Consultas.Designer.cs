
namespace TP_Interfaz
{
    partial class frmConsultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboEspecialidades = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblEspecialidades = new System.Windows.Forms.Label();
            this.gboMedicosDisponibles = new System.Windows.Forms.GroupBox();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.cboMedicos = new System.Windows.Forms.ComboBox();
            this.btnConsultasActivas = new System.Windows.Forms.Button();
            this.btnConsultasFinalizadas = new System.Windows.Forms.Button();
            this.dgvEspera = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPacientesEspera = new System.Windows.Forms.Label();
            this.gboMedicosDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspera)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboEspecialidades
            // 
            this.cboEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidades.FormattingEnabled = true;
            this.cboEspecialidades.Items.AddRange(new object[] {
            "Seleccionar"});
            this.cboEspecialidades.Location = new System.Drawing.Point(12, 72);
            this.cboEspecialidades.Name = "cboEspecialidades";
            this.cboEspecialidades.Size = new System.Drawing.Size(181, 28);
            this.cboEspecialidades.TabIndex = 0;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAsignar.Location = new System.Drawing.Point(0, 116);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(161, 38);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lblEspecialidades
            // 
            this.lblEspecialidades.AutoSize = true;
            this.lblEspecialidades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEspecialidades.Location = new System.Drawing.Point(12, 50);
            this.lblEspecialidades.Name = "lblEspecialidades";
            this.lblEspecialidades.Size = new System.Drawing.Size(111, 20);
            this.lblEspecialidades.TabIndex = 5;
            this.lblEspecialidades.Text = "Especialidades:";
            // 
            // gboMedicosDisponibles
            // 
            this.gboMedicosDisponibles.Controls.Add(this.lblMedicos);
            this.gboMedicosDisponibles.Controls.Add(this.cboMedicos);
            this.gboMedicosDisponibles.Controls.Add(this.cboEspecialidades);
            this.gboMedicosDisponibles.Controls.Add(this.lblEspecialidades);
            this.gboMedicosDisponibles.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboMedicosDisponibles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gboMedicosDisponibles.Location = new System.Drawing.Point(66, 15);
            this.gboMedicosDisponibles.Name = "gboMedicosDisponibles";
            this.gboMedicosDisponibles.Size = new System.Drawing.Size(398, 122);
            this.gboMedicosDisponibles.TabIndex = 6;
            this.gboMedicosDisponibles.TabStop = false;
            this.gboMedicosDisponibles.Text = "Seleccionar";
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMedicos.Location = new System.Drawing.Point(202, 50);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(70, 20);
            this.lblMedicos.TabIndex = 7;
            this.lblMedicos.Text = "Médicos:";
            // 
            // cboMedicos
            // 
            this.cboMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedicos.FormattingEnabled = true;
            this.cboMedicos.Location = new System.Drawing.Point(202, 72);
            this.cboMedicos.Name = "cboMedicos";
            this.cboMedicos.Size = new System.Drawing.Size(181, 28);
            this.cboMedicos.TabIndex = 6;
            // 
            // btnConsultasActivas
            // 
            this.btnConsultasActivas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.btnConsultasActivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultasActivas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultasActivas.Location = new System.Drawing.Point(0, 156);
            this.btnConsultasActivas.Name = "btnConsultasActivas";
            this.btnConsultasActivas.Size = new System.Drawing.Size(161, 38);
            this.btnConsultasActivas.TabIndex = 8;
            this.btnConsultasActivas.Text = "Consultas Activas";
            this.btnConsultasActivas.UseVisualStyleBackColor = false;
            this.btnConsultasActivas.Click += new System.EventHandler(this.btnConsultasActivas_Click);
            // 
            // btnConsultasFinalizadas
            // 
            this.btnConsultasFinalizadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.btnConsultasFinalizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultasFinalizadas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultasFinalizadas.Location = new System.Drawing.Point(0, 196);
            this.btnConsultasFinalizadas.Name = "btnConsultasFinalizadas";
            this.btnConsultasFinalizadas.Size = new System.Drawing.Size(161, 38);
            this.btnConsultasFinalizadas.TabIndex = 9;
            this.btnConsultasFinalizadas.Text = "Consultas Finalizadas";
            this.btnConsultasFinalizadas.UseVisualStyleBackColor = false;
            this.btnConsultasFinalizadas.Click += new System.EventHandler(this.btnConsultasFinalizadas_Click);
            // 
            // dgvEspera
            // 
            this.dgvEspera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEspera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEspera.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvEspera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspera.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEspera.EnableHeadersVisualStyles = false;
            this.dgvEspera.Location = new System.Drawing.Point(18, 203);
            this.dgvEspera.Name = "dgvEspera";
            this.dgvEspera.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspera.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEspera.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEspera.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEspera.RowTemplate.Height = 28;
            this.dgvEspera.Size = new System.Drawing.Size(482, 176);
            this.dgvEspera.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnAsignar);
            this.panel1.Controls.Add(this.btnConsultasFinalizadas);
            this.panel1.Controls.Add(this.btnConsultasActivas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(506, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 376);
            this.panel1.TabIndex = 12;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::TP_Interfaz.Properties.Resources.cross;
            this.btnCerrar.Location = new System.Drawing.Point(0, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 46);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.gboMedicosDisponibles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 156);
            this.panel2.TabIndex = 13;
            // 
            // lblPacientesEspera
            // 
            this.lblPacientesEspera.AutoSize = true;
            this.lblPacientesEspera.BackColor = System.Drawing.Color.Transparent;
            this.lblPacientesEspera.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPacientesEspera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPacientesEspera.Location = new System.Drawing.Point(18, 180);
            this.lblPacientesEspera.Name = "lblPacientesEspera";
            this.lblPacientesEspera.Size = new System.Drawing.Size(187, 20);
            this.lblPacientesEspera.TabIndex = 14;
            this.lblPacientesEspera.Text = "Pacientes en lista de Espera.";
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(667, 376);
            this.Controls.Add(this.lblPacientesEspera);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEspera);
            this.Name = "frmConsultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.gboMedicosDisponibles.ResumeLayout(false);
            this.gboMedicosDisponibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspera)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEspecialidades;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblEspecialidades;
        private System.Windows.Forms.GroupBox gboMedicosDisponibles;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.ComboBox cboMedicos;
        private System.Windows.Forms.Button btnConsultasActivas;
        private System.Windows.Forms.Button btnConsultasFinalizadas;
        private System.Windows.Forms.DataGridView dgvEspera;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblPacientesEspera;
    }
}