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
    public partial class frmConsultasActivas : Form
    {
        public frmConsultasActivas()
        {
            InitializeComponent();
        }

        public void CargarListaConsultas()
        {
            dgvConsultasActivas.DataSource = Logica.MostrarConsultas(true);
            dgvConsultasActivas.Columns["Estado"].Visible = false;
            dgvConsultasActivas.ClearSelection();
        }

        private void frmConsultasActivas_Load(object sender, EventArgs e)
        {
            cboResultadoConsulta.DataSource = Enum.GetValues(typeof(Logica.Resultado));
            cboResultadoConsulta.SelectedIndex = -1;
            cboResultadoConsulta.Text = null;
            CargarListaConsultas();
        }


        private void btnFinalizarConsulta_Click(object sender, EventArgs e)
        {
            if (dgvConsultasActivas.CurrentRow != null)
            {
                if (cboResultadoConsulta.SelectedItem != null)
                {
                    Consulta consulta = (Consulta)dgvConsultasActivas.CurrentRow.DataBoundItem;
                    Logica.FinalizarConsulta(consulta, cboResultadoConsulta.SelectedItem.ToString());
                    MessageBox.Show("Consulta finalizada correctamente.", "Finalizar Consulta");

                    CargarListaConsultas();
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un resultado para finalizar la consulta.", "Finalizar Consulta");
                }
            }
            else
            {
                MessageBox.Show("Debes tener consultas activas para poder finalizarlas.", "Finalizar Consulta");
            }
        }
    }
}
