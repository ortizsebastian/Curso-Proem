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
    public partial class frmConsultasFinalizadas : Form
    {
        public frmConsultasFinalizadas()
        {
            InitializeComponent();
        }

        private void frmConsultasFinalizadas_Load(object sender, EventArgs e)
        {
            dgvConsultasFinalizadas.DataSource = Logica.MostrarConsultas(false);
            dgvConsultasFinalizadas.Columns["Estado"].Visible = false;
        }
    }
}
