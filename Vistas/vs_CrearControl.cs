﻿using System;
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

        public vs_CrearControl()
        {
            InitializeComponent();
            oControlDAO = new controlDAO();
            oControlNEG = new ControlNEG();
            memoria = new MemoryStream();
        }

        
        private void vs_CrearControl_Load(object sender, EventArgs e)
        {

            cargarListaDeMarcas();
            cargarControles();
           
        }

        public void cargarListaDeMarcas()
        {
            SqlDataReader oDtR = oControlDAO.obtencionDeMarcas();

            while (oDtR.Read())
            {
                lbxListaMarca.Items.Add(oDtR["nombreMarca"]);
            }

            oControlDAO.cerrarConexion();

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

            cargarControles();
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

            tbCodControl.Text = dgvListaControles.Rows[indice].Cells[0].Value.ToString();
            tbCantidad.Text = dgvListaControles.Rows[indice].Cells[1].Value.ToString();

            memoria = new MemoryStream((byte[])dgvListaControles.Rows[indice].Cells[2].Value);
            Bitmap btp = new Bitmap(memoria);
            pbxImagenControl.Image= btp;
            imagenByte = memoria.ToArray();

        }
    }
}