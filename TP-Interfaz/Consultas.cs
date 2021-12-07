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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void CargarListaEspera()
        {
            dgvEspera.DataSource = Logica.ListaPaciente.FindAll(x => x.Estado == true);
            dgvEspera.Columns["Estado"].Visible = false;
            dgvEspera.ClearSelection();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            cboEspecialidades.DataSource = Logica.MostrarEspecialidades();
            cboEspecialidades.SelectedIndex = -1;
            cboEspecialidades.Text = null;

            cboMedicos.DataSource = Logica.MostrarNombres();
            cboMedicos.SelectedIndex = -1;
            cboMedicos.Text = null;

            CargarListaEspera();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string especialidad = (string)cboEspecialidades.SelectedItem;
            string nombre = (string)cboMedicos.SelectedItem;

            if (especialidad != null || nombre != null)
            {
                MessageBox.Show(Logica.MedicoDisponible(especialidad, nombre), "Consultas");                                   
                CargarListaEspera();               
            }
            else
            {
                MessageBox.Show("Debes seleccionar una especialidad o un médico.", "Consultas");
            }
        }

        private void btnConsultasActivas_Click(object sender, EventArgs e)
        {
            frmConsultasActivas frm = new();
            frm.Show();
        }

        private void btnConsultasFinalizadas_Click(object sender, EventArgs e)
        {
            frmConsultasFinalizadas frm = new();
            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
