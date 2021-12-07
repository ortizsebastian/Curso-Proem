using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Entidades;

namespace TP_Interfaz
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            dgvMedicos.DataSource = Logica.ListaMedico.OrderByDescending(x => x.PacientesAtendidos).ToList();
            dgvMedicos.Columns["Estado"].Visible = false;

            List<string> especialidadesSolicitadas = Logica.EspecialidadMasSolicitada();
            if (especialidadesSolicitadas != null)
            {
                dgvEspecialidades.DataSource = especialidadesSolicitadas.Select(x => new { Especialidad = x }).ToList();
                dgvEspecialidades.Update();
                dgvEspecialidades.Refresh();
                dgvEspecialidades.Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
