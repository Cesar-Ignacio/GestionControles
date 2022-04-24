using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionControl.Dao;
using GestionControl.Negocio;
using System.Data.SqlClient;


namespace GestionControl.Vistas
{
    public partial class vs_Consultas : Form
    {

        MarcaDAO oMarcaDAO;
        SqlDataReader dtr;
        MarcaNEG oMarcaNEG;
        
        public vs_Consultas()
        {
            InitializeComponent();
            oMarcaDAO = new MarcaDAO(); 
            oMarcaNEG=new MarcaNEG();
        }
        
        private void vs_Consultas_Load(object sender, EventArgs e)
        {

            caragarMarcasComboBox();

        }

        public void caragarMarcasComboBox()
        {
            dtr = oMarcaDAO.obtencionDeMarcas();
            while(dtr.Read())
            {
                cbxMarcaControl.Items.Add(dtr["nombreMarca"]);
            }

        }


        private void btInicio_Click(object sender, EventArgs e)
        {
            Form formulario = new vs_Inicio();
            this.Close();
            formulario.Show();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

           
            oMarcaNEG.nombreMarca= cbxMarcaControl.Text;
            MessageBox.Show("Indice:" + cbxMarcaControl.Text);
           
            dataGridView1.DataSource=oMarcaDAO.controlesDeMarca(oMarcaNEG);
            
            // dataGridView1.DataSource= oMarcaDAO.controlesDeMarca(oMarcaNEG);
        }
    }
}
