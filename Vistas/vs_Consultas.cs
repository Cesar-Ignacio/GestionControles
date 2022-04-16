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
    public partial class vs_Consultas : Form
    {
        public vs_Consultas()
        {
            InitializeComponent();
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            Form formulario = new vs_Inicio();
            this.Close();
            formulario.Show();
;
        }
    }
}
