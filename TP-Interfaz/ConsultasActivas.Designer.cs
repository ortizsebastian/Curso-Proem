
namespace TP_Interfaz
{
    partial class frmConsultasActivas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultasActivas));
            this.btnFinalizarConsulta = new System.Windows.Forms.Button();
            this.lblResultadoConsulta = new System.Windows.Forms.Label();
            this.cboResultadoConsulta = new System.Windows.Forms.ComboBox();
            this.dgvConsultasActivas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasActivas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinalizarConsulta
            // 
            this.btnFinalizarConsulta.Location = new System.Drawing.Point(463, 21);
            this.btnFinalizarConsulta.Name = "btnFinalizarConsulta";
            this.btnFinalizarConsulta.Size = new System.Drawing.Size(142, 35);
            this.btnFinalizarConsulta.TabIndex = 1;
            this.btnFinalizarConsulta.Text = "Finalizar Consulta";
            this.btnFinalizarConsulta.UseVisualStyleBackColor = true;
            this.btnFinalizarConsulta.Click += new System.EventHandler(this.btnFinalizarConsulta_Click);
            // 
            // lblResultadoConsulta
            // 
            this.lblResultadoConsulta.AutoSize = true;
            this.lblResultadoConsulta.Location = new System.Drawing.Point(43, 29);
            this.lblResultadoConsulta.Name = "lblResultadoConsulta";
            this.lblResultadoConsulta.Size = new System.Drawing.Size(163, 19);
            this.lblResultadoConsulta.TabIndex = 2;
            this.lblResultadoConsulta.Text = "Resultado de la Consulta:";
            // 
            // cboResultadoConsulta
            // 
            this.cboResultadoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResultadoConsulta.FormattingEnabled = true;
            this.cboResultadoConsulta.Location = new System.Drawing.Point(212, 26);
            this.cboResultadoConsulta.Name = "cboResultadoConsulta";
            this.cboResultadoConsulta.Size = new System.Drawing.Size(181, 27);
            this.cboResultadoConsulta.TabIndex = 4;
            // 
            // dgvConsultasActivas
            // 
            this.dgvConsultasActivas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultasActivas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultasActivas.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvConsultasActivas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultasActivas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultasActivas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultasActivas.EnableHeadersVisualStyles = false;
            this.dgvConsultasActivas.Location = new System.Drawing.Point(36, 104);
            this.dgvConsultasActivas.Name = "dgvConsultasActivas";
            this.dgvConsultasActivas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultasActivas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultasActivas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultasActivas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsultasActivas.RowTemplate.Height = 28;
            this.dgvConsultasActivas.Size = new System.Drawing.Size(586, 252);
            this.dgvConsultasActivas.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnFinalizarConsulta);
            this.panel1.Controls.Add(this.cboResultadoConsulta);
            this.panel1.Controls.Add(this.lblResultadoConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 78);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(394, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 298);
            this.panel2.TabIndex = 14;
            // 
            // frmConsultasActivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(667, 376);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvConsultasActivas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultasActivas";
            this.Text = "Consultas Activas";
            this.Load += new System.EventHandler(this.frmConsultasActivas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasActivas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizarConsulta;
        private System.Windows.Forms.Label lblResultadoConsulta;
        private System.Windows.Forms.ComboBox cboResultadoConsulta;
        private System.Windows.Forms.DataGridView dgvConsultasActivas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}