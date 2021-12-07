
namespace TP_Interfaz
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.pnlBajo = new System.Windows.Forms.Panel();
            this.lblAutor = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlLateral.SuspendLayout();
            this.pnlBajo.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.pnlLateral.Controls.Add(this.btnEstadisticas);
            this.pnlLateral.Controls.Add(this.btnConsultas);
            this.pnlLateral.Controls.Add(this.btnPacientes);
            this.pnlLateral.Controls.Add(this.btnMedicos);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(226, 572);
            this.pnlLateral.TabIndex = 9;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstadisticas.Image = global::TP_Interfaz.Properties.Resources.filter;
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 301);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstadisticas.Size = new System.Drawing.Size(226, 47);
            this.btnEstadisticas.TabIndex = 3;
            this.btnEstadisticas.Tag = "";
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(0, 251);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConsultas.Size = new System.Drawing.Size(226, 47);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPacientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPacientes.Image = global::TP_Interfaz.Properties.Resources.perfil;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 201);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPacientes.Size = new System.Drawing.Size(226, 47);
            this.btnPacientes.TabIndex = 1;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.btnMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMedicos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicos.Image = global::TP_Interfaz.Properties.Resources.doctor;
            this.btnMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicos.Location = new System.Drawing.Point(0, 151);
            this.btnMedicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMedicos.Size = new System.Drawing.Size(226, 47);
            this.btnMedicos.TabIndex = 0;
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.UseVisualStyleBackColor = false;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // pnlBajo
            // 
            this.pnlBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.pnlBajo.Controls.Add(this.lblAutor);
            this.pnlBajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBajo.Location = new System.Drawing.Point(0, 502);
            this.pnlBajo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBajo.Name = "pnlBajo";
            this.pnlBajo.Size = new System.Drawing.Size(721, 70);
            this.pnlBajo.TabIndex = 11;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(612, 44);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(101, 19);
            this.lblAutor.TabIndex = 0;
            this.lblAutor.Text = "Ortiz Sebastián";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(721, 74);
            this.pnlSuperior.TabIndex = 12;
            this.pnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::TP_Interfaz.Properties.Resources.cross;
            this.btnCerrar.Location = new System.Drawing.Point(667, 8);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 46);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Silver;
            this.pnlContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlContenedor.Controls.Add(this.pbxLogo);
            this.pnlContenedor.Controls.Add(this.pnlSuperior);
            this.pnlContenedor.Controls.Add(this.pnlBajo);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.ForeColor = System.Drawing.Color.White;
            this.pnlContenedor.Location = new System.Drawing.Point(226, 0);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(721, 572);
            this.pnlContenedor.TabIndex = 12;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxLogo.BackgroundImage = global::TP_Interfaz.Properties.Resources.logo;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxLogo.InitialImage = null;
            this.pbxLogo.Location = new System.Drawing.Point(156, 81);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(400, 414);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogo.TabIndex = 13;
            this.pbxLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 572);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "App";
            this.Load += new System.EventHandler(this.frmCore_Load);
            this.pnlLateral.ResumeLayout(false);
            this.pnlBajo.ResumeLayout(false);
            this.pnlBajo.PerformLayout();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Panel pnlBajo;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}

