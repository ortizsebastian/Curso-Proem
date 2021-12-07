using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Entidades;

namespace TP_Interfaz
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// Método para poder mover la ventana manteniendo el click en el borde superior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private Form frmActivo = null;

        /// <summary>
        /// Método para poder mostrar los formularios dentro del main.
        /// Recibe como parámetro el formulario que se quiere abrir.
        /// Se ajusta el tamaño del formulario y se le sacan los bordes.
        /// Se trae al frente el dicho formulario contenido dentro del componente "pnlContenedor".
        /// </summary>
        /// <param name="frm"></param>
        private void Contenedor(Form frm)
        {
            if (frmActivo != null)
                frmActivo.Close();
            frmActivo = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(frm);
            pnlContenedor.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        /// <summary>
        /// Hardcodeo de datos en el load de la aplicación.
        /// Los datos serán guardados en listas dentro de la clase Logica.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCore_Load(object sender, EventArgs e)
        {
            Logica.AgregarPaciente(new Paciente("Sebastian","Ortiz","11111111", "CoberturaCompleta", 27));
            Logica.AgregarPaciente(new Paciente("Ezequiel","Ortega","22222222", "CoberturaBasica",22));
            Logica.AgregarPaciente(new Paciente("Maria", "Garcia","33333333", "NoTiene",16));
            Logica.AgregarPaciente(new Paciente("Juan","Carlos","44444444", "CoberturaCompleta", 34));
            Logica.AgregarPaciente(new Paciente("Julieta","Gomez","55555555", "NoTiene",24));
            
            Logica.AgregarMedico(new Medico("Juan","Perez","Odontólogo"));
            Logica.AgregarMedico(new Medico("Daniela","Gutierrez","Traumatólogo"));
            Logica.AgregarMedico(new Medico("Estefania","Fernandez","Odontólogo"));
            Logica.AgregarMedico(new Medico("Nicolas","Sferra","Radiólogo"));
            Logica.AgregarMedico(new Medico("Ivan","Galeano","Kinesiólogo"));
        }
        private void btnMedicos_Click(object sender, EventArgs e)
        {
            Contenedor(new frmListarMedicos());
        }
        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Contenedor(new frmListarPacientes());
        }
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Contenedor(new frmConsultas());
        }
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Contenedor(new frmEstadisticas());
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
