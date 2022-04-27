namespace GestionControl.Vistas
{
    partial class vs_Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbxMarcaControl = new System.Windows.Forms.ComboBox();
            this.lbTituloNombreMarca = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.lbCantidadDescontar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbhora = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxMarcaControl
            // 
            this.cbxMarcaControl.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarcaControl.FormattingEnabled = true;
            this.cbxMarcaControl.Location = new System.Drawing.Point(12, 42);
            this.cbxMarcaControl.Name = "cbxMarcaControl";
            this.cbxMarcaControl.Size = new System.Drawing.Size(435, 37);
            this.cbxMarcaControl.Sorted = true;
            this.cbxMarcaControl.TabIndex = 0;
            // 
            // lbTituloNombreMarca
            // 
            this.lbTituloNombreMarca.AutoSize = true;
            this.lbTituloNombreMarca.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTituloNombreMarca.Location = new System.Drawing.Point(12, 26);
            this.lbTituloNombreMarca.Name = "lbTituloNombreMarca";
            this.lbTituloNombreMarca.Size = new System.Drawing.Size(90, 13);
            this.lbTituloNombreMarca.TabIndex = 1;
            this.lbTituloNombreMarca.Text = "Marca de control:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 154);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccion);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(172, 325);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(104, 20);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(172, 351);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(104, 42);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // lbCantidadDescontar
            // 
            this.lbCantidadDescontar.AutoSize = true;
            this.lbCantidadDescontar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCantidadDescontar.Location = new System.Drawing.Point(172, 299);
            this.lbCantidadDescontar.Name = "lbCantidadDescontar";
            this.lbCantidadDescontar.Size = new System.Drawing.Size(104, 13);
            this.lbCantidadDescontar.TabIndex = 11;
            this.lbCantidadDescontar.Text = "Cantidad Requerida:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBuscar.Image = global::GestionControl.Properties.Resources.buscar;
            this.btBuscar.Location = new System.Drawing.Point(471, 42);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 37);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(317, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 204);
            this.panel1.TabIndex = 12;
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.Silver;
            this.lbfecha.Location = new System.Drawing.Point(226, 9);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(38, 16);
            this.lbfecha.TabIndex = 13;
            this.lbfecha.Text = "fecha";
            // 
            // lbhora
            // 
            this.lbhora.AutoSize = true;
            this.lbhora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.Silver;
            this.lbhora.Location = new System.Drawing.Point(535, 9);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(33, 16);
            this.lbhora.TabIndex = 14;
            this.lbhora.Text = "hora";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // vs_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCantidadDescontar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lbTituloNombreMarca);
            this.Controls.Add(this.cbxMarcaControl);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "vs_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vs_Consultas";
            this.Load += new System.EventHandler(this.vs_Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMarcaControl;
        private System.Windows.Forms.Label lbTituloNombreMarca;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label lbCantidadDescontar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Timer timer;
    }
}