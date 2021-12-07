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
    public partial class frmListarPacientes : Form
    {
        public frmListarPacientes()
        {
            InitializeComponent();
        }

        private void frmListarPacientes_Load(object sender, EventArgs e)
        {
            dgvListaPacientes.DataSource = Logica.ListaPaciente;
            dgvListaPacientes.Columns[6].HeaderText = "Sin Atender";
            dgvListaPacientes.ClearSelection();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
