using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionControl.Negocio;
using GestionControl.Dao;
using System.IO;

namespace GestionControl.Vistas
{
    public partial class vs_CrearControl : Form
    {
        controlDAO oControlDAO;
        byte[] imagenByte;
        public vs_CrearControl()
        {
            InitializeComponent();
            oControlDAO = new controlDAO(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            Form formulario=new vs_Inicio();
            this.Close();   
            formulario.Show();
        }

        private void btGuardarControl_Click(object sender, EventArgs e)
        {
            recuperarInformacion();
            conexionDAO con=new conexionDAO();
            
            MessageBox.Show("Conexion:" + oControlDAO.obtencion());
        }

        private void recuperarInformacion()
        {
            ControlNEG oControl=new ControlNEG();

            int cantidad = 0; int.TryParse(tbCantidad.Text,out cantidad);

            oControl.codControl = tbCodControl.Text;
            oControl.cantidad = cantidad;
            oControl.imagenControl = imagenByte;
            MessageBox.Show(oControl.codControl);
            MessageBox.Show("Cantidad:"+oControl.cantidad);
            MessageBox.Show("Imagen:" + oControl.imagenControl);


        }

        private void btAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selección de Imagen";
           
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxImagenControl.Image = Image.FromStream(ofd.OpenFile());
                MemoryStream memoria = new MemoryStream();
                pbxImagenControl.Image.Save(memoria,System.Drawing.Imaging.ImageFormat.Jpeg);
                imagenByte = memoria.ToArray();
            }
        }
    }
}
