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
    public partial class frmListarMedicos : Form
    {
        public frmListarMedicos()
        {
            InitializeComponent();
        }
        private void frmListarMedicos_Load(object sender, EventArgs e)
        {
            dgvListaMedicos.DataSource = Logica.ListaMedico;
            dgvListaMedicos.Columns[4].HeaderText = "Disponible";  
            dgvListaMedicos.ClearSelection();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
