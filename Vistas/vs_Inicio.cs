using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionControl.Vistas
{
    public partial class vs_Inicio : Form
    {
        public vs_Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new vs_Consultas();
            formulario.ShowDialog();
        }

        private void btnAgregarControl_Click(object sender, EventArgs e)
        {
            Form formulario=new vs_CrearControl();
            formulario.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbfecha.Text = DateTime.Now.ToLongDateString();

        }

        private void vs_Inicio_Load(object sender, EventArgs e)
        {
            
        }
    }
}
