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
using System.IO;

namespace GestionControl.Vistas
{
    public partial class vs_Consultas : Form
    {

        MarcaDAO oMarcaDAO;
        SqlDataReader dtr;
        MarcaNEG oMarcaNEG;
        ControlNEG oControlNEG;
        controlDAO oControlDAO;
        public vs_Consultas()
        {
            InitializeComponent();
            oMarcaDAO = new MarcaDAO(); 
            oMarcaNEG=new MarcaNEG();
            oControlNEG=new ControlNEG();  
            oControlDAO=new controlDAO();
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
            MessageBox.Show("Buscar marca:" + cbxMarcaControl.Text);
           
            dataGridView1.DataSource=oMarcaDAO.controlesDeMarca(oMarcaNEG);
            
            // dataGridView1.DataSource= oMarcaDAO.controlesDeMarca(oMarcaNEG);
        }

        private void Seleccion(object sender, DataGridViewCellMouseEventArgs e)
        {


            int indice = e.RowIndex;
            try
            {
               
                oControlNEG.codControl =dataGridView1.Rows[indice].Cells[0].Value.ToString();
                oControlNEG.cantidad =Convert.ToInt16(dataGridView1.Rows[indice].Cells[1].Value.ToString());
                MemoryStream memoria = new MemoryStream((byte[])dataGridView1.Rows[indice].Cells[3].Value);
                Bitmap btp = new Bitmap(memoria);
                pictureBox1.Image = btp;
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR","Atención");
            }
           
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48 || e.KeyChar>57) && e.KeyChar!=8)
            {
                e.Handled = true;
                MessageBox.Show("Solo números","Atención");
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            int def= 0; int.TryParse(txtCantidad.Text, out def);

            int cantidadRequerida = Convert.ToInt16(txtCantidad.Text);

            if(cantidadRequerida<=oControlNEG.cantidad)
            {
                oControlNEG.cantidad = cantidadRequerida;
                MessageBox.Show("Codigo COntorl:" + oControlNEG.codControl + ", cantidad:" + oControlNEG.cantidad);
                MessageBox.Show("Ejecucion :"+ oControlDAO.actualizarControlStock(oControlNEG));
                dataGridView1.DataSource = oMarcaDAO.controlesDeMarca(oMarcaNEG);
                oControlNEG.cantidad = 0;
            }
            else
            {
                MessageBox.Show("Cantidad requerida no disponibles", "Atención");
            }
          
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbfecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
