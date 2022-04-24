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
using System.Data.SqlClient;

namespace GestionControl.Vistas
{
    public partial class vs_CrearControl : Form
    {
        controlDAO oControlDAO;
        byte[] imagenByte;
        ControlNEG oControlNEG;
        MemoryStream memoria;
        MarcaControlNEG oMarcaControlNEG;
        MarcaNEG oMarcaNEG;
        MarcaDAO oMarcaDAO;
        marca_X_ControlDAO oMarcaControlDAO;
       
        public vs_CrearControl()
        {
            InitializeComponent();
            oControlDAO = new controlDAO();
            oControlNEG = new ControlNEG();
            memoria = new MemoryStream();
            oMarcaControlNEG = new MarcaControlNEG();
            oMarcaNEG = new MarcaNEG();
            oMarcaDAO=new MarcaDAO();
            oMarcaControlDAO = new marca_X_ControlDAO();
        }

        
        private void vs_CrearControl_Load(object sender, EventArgs e)
        {

            cargarListaDeMarcas();
            cargarControles();
            estadoBotones(false);
           
        }

        public void cargarListaDeMarcas()
        {
            SqlDataReader oDtR = oMarcaDAO.obtencionDeMarcas();

            while (oDtR.Read())
            {
                lbxListaMarca.Items.Add(oDtR["nombreMarca"]);
            }

            oMarcaDAO.cerrarConexion();

        }

        public void cargarControles()
        {
            dgvListaControles.DataSource = oControlDAO.obtenerControles();
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
       

            MessageBox.Show("Se pudo escribir:"+oControlDAO.insertarControl(oControlNEG));

            cargarControlMarca();


            cargarControles();



        }

        private void cargarControlMarca()
        {
            oMarcaControlNEG.codControl = tbCodControl.Text;

            if(lbxListaMarca.SelectedIndices.Count>0)
            {
                foreach (String item in lbxListaMarca.SelectedItems)
                {
                    oMarcaNEG.nombreMarca = item.ToString();
                    oMarcaControlNEG.codMarca = oMarcaDAO.obtenerCodMarca1(oMarcaNEG);
                    MessageBox.Show("Se agrego control " + item.ToString() + " : " + oMarcaControlDAO.guaradarControlMarca1(oMarcaControlNEG));
                }

            }
            else
            {
                MessageBox.Show("No se agrego marcas");
            }

            
        }

        private void recuperarInformacion()
        {
           
            int cantidad = 0; int.TryParse(tbCantidad.Text,out cantidad);

            oControlNEG.codControl = tbCodControl.Text;
            oControlNEG.cantidad = cantidad;
            oControlNEG.imagenControl = imagenByte;
            MessageBox.Show(oControlNEG.codControl);
            MessageBox.Show("Cantidad:"+oControlNEG.cantidad);
            MessageBox.Show("Imagen:" + oControlNEG.imagenControl);

        }

        private void btAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selección de Imagen";
           
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxImagenControl.Image = Image.FromStream(ofd.OpenFile());
                memoria = new MemoryStream();
                pbxImagenControl.Image.Save(memoria,System.Drawing.Imaging.ImageFormat.Jpeg);
                imagenByte = memoria.ToArray();
            }
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
             
            int indice = e.RowIndex;


            estadoBotones(true);
            btGuardarControl.Enabled = false;
            tbCodControl.Enabled = false;
            
            tbCodControl.Text = dgvListaControles.Rows[indice].Cells[0].Value.ToString();
            tbCantidad.Text = dgvListaControles.Rows[indice].Cells[1].Value.ToString();

            memoria = new MemoryStream((byte[])dgvListaControles.Rows[indice].Cells[2].Value);
            Bitmap btp = new Bitmap(memoria);
            pbxImagenControl.Image= btp;
            
            imagenByte = memoria.ToArray();



        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            btGuardarControl.Enabled = true;
            tbCodControl.Enabled = true;
            estadoBotones(false);
            limpiarContenido();
            
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            btGuardarControl.Enabled = true;
            
            estadoBotones(false);
           
            oMarcaControlNEG.codControl = tbCodControl.Text;

            MessageBox.Show("ddd:"+ oMarcaControlNEG.codControl +"_"+ oMarcaControlDAO.actualizarDatos(oMarcaControlNEG));

            cargarControlMarca();

            actualizarControl();

            recargarVentana();

        }
        private void recargarVentana()
        {
            Form ve = new vs_CrearControl();
            
            this.Close();
            ve.Show();

        }

        private void actualizarControl()
        {
            recuperarInformacion();

            MessageBox.Show("Se pudo actualizar:"+oControlDAO.actualizarControl(oControlNEG));

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

            oControlNEG.codControl=tbCodControl.Text;
            MessageBox.Show("Se eliminno el registro:"+ oControlDAO.eliminarControl(oControlNEG));
  
            recargarVentana();
           
        }
        public void limpiarContenido()
        {
            tbCodControl.Clear();
            tbCantidad.Clear();
            lbxListaMarca.ClearSelected();
            pbxImagenControl.Image = null;          
        }

        public void estadoBotones(bool estado)
        {
            btCancelar.Enabled = estado;
            btModificar.Enabled = estado;
            btEliminar.Enabled = estado;
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48 || e.KeyChar>57) && e.KeyChar!=8)
            {
                MessageBox.Show("Solo números","Atención");
                e.Handled = true;
            }
        }
    }
}
