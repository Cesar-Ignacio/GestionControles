namespace GestionControl.Vistas
{
    partial class vs_CrearControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vs_CrearControl));
            this.tbCodControl = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lbCondigoControl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMarcasCompatibles = new System.Windows.Forms.Label();
            this.btAgregarImagen = new System.Windows.Forms.Button();
            this.lbxListaMarca = new System.Windows.Forms.ListBox();
            this.dgvListaControles = new System.Windows.Forms.DataGridView();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btGuardarControl = new System.Windows.Forms.Button();
            this.pbxImagenControl = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaControles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenControl)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCodControl
            // 
            this.tbCodControl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodControl.Location = new System.Drawing.Point(44, 86);
            this.tbCodControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbCodControl.Name = "tbCodControl";
            this.tbCodControl.Size = new System.Drawing.Size(144, 30);
            this.tbCodControl.TabIndex = 0;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(44, 156);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(144, 29);
            this.tbCantidad.TabIndex = 2;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // lbCondigoControl
            // 
            this.lbCondigoControl.AutoSize = true;
            this.lbCondigoControl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbCondigoControl.Location = new System.Drawing.Point(44, 70);
            this.lbCondigoControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCondigoControl.Name = "lbCondigoControl";
            this.lbCondigoControl.Size = new System.Drawing.Size(94, 13);
            this.lbCondigoControl.TabIndex = 4;
            this.lbCondigoControl.Text = "Codigo de Control:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(44, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad:";
            // 
            // lbMarcasCompatibles
            // 
            this.lbMarcasCompatibles.AutoSize = true;
            this.lbMarcasCompatibles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbMarcasCompatibles.Location = new System.Drawing.Point(44, 200);
            this.lbMarcasCompatibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMarcasCompatibles.Name = "lbMarcasCompatibles";
            this.lbMarcasCompatibles.Size = new System.Drawing.Size(102, 13);
            this.lbMarcasCompatibles.TabIndex = 6;
            this.lbMarcasCompatibles.Text = "Marcas Compatibles";
            // 
            // btAgregarImagen
            // 
            this.btAgregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregarImagen.Location = new System.Drawing.Point(476, 236);
            this.btAgregarImagen.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btAgregarImagen.Name = "btAgregarImagen";
            this.btAgregarImagen.Size = new System.Drawing.Size(94, 24);
            this.btAgregarImagen.TabIndex = 7;
            this.btAgregarImagen.Text = "Subir Imagen";
            this.btAgregarImagen.UseVisualStyleBackColor = true;
            this.btAgregarImagen.Click += new System.EventHandler(this.btAgregarImagen_Click);
            // 
            // lbxListaMarca
            // 
            this.lbxListaMarca.FormattingEnabled = true;
            this.lbxListaMarca.Location = new System.Drawing.Point(247, 67);
            this.lbxListaMarca.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbxListaMarca.Name = "lbxListaMarca";
            this.lbxListaMarca.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxListaMarca.Size = new System.Drawing.Size(144, 160);
            this.lbxListaMarca.Sorted = true;
            this.lbxListaMarca.TabIndex = 10;
            // 
            // dgvListaControles
            // 
            this.dgvListaControles.AllowUserToOrderColumns = true;
            this.dgvListaControles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaControles.ColumnHeadersHeight = 20;
            this.dgvListaControles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaControles.Location = new System.Drawing.Point(43, 285);
            this.dgvListaControles.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvListaControles.Name = "dgvListaControles";
            this.dgvListaControles.ReadOnly = true;
            this.dgvListaControles.Size = new System.Drawing.Size(588, 127);
            this.dgvListaControles.TabIndex = 11;
            this.dgvListaControles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.Image = global::GestionControl.Properties.Resources.prohibicion;
            this.btCancelar.Location = new System.Drawing.Point(304, 236);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(58, 40);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModificar.Image = global::GestionControl.Properties.Resources.lapiz;
            this.btModificar.Location = new System.Drawing.Point(216, 236);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(58, 40);
            this.btModificar.TabIndex = 13;
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.Image = global::GestionControl.Properties.Resources.borrar__1_;
            this.btEliminar.Location = new System.Drawing.Point(127, 236);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(59, 40);
            this.btEliminar.TabIndex = 12;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btGuardarControl
            // 
            this.btGuardarControl.BackColor = System.Drawing.Color.Transparent;
            this.btGuardarControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardarControl.Image = ((System.Drawing.Image)(resources.GetObject("btGuardarControl.Image")));
            this.btGuardarControl.Location = new System.Drawing.Point(44, 236);
            this.btGuardarControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btGuardarControl.Name = "btGuardarControl";
            this.btGuardarControl.Size = new System.Drawing.Size(58, 40);
            this.btGuardarControl.TabIndex = 8;
            this.btGuardarControl.UseVisualStyleBackColor = false;
            this.btGuardarControl.Click += new System.EventHandler(this.btGuardarControl_Click);
            // 
            // pbxImagenControl
            // 
            this.pbxImagenControl.Location = new System.Drawing.Point(-1, -1);
            this.pbxImagenControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbxImagenControl.Name = "pbxImagenControl";
            this.pbxImagenControl.Size = new System.Drawing.Size(221, 219);
            this.pbxImagenControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenControl.TabIndex = 3;
            this.pbxImagenControl.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbxImagenControl);
            this.panel1.Location = new System.Drawing.Point(410, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 219);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.Silver;
            this.lbfecha.Location = new System.Drawing.Point(12, 9);
            this.lbfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(38, 16);
            this.lbfecha.TabIndex = 16;
            this.lbfecha.Text = "fecha";
            this.lbfecha.Click += new System.EventHandler(this.lbfecha_Click);
            // 
            // lbhora
            // 
            this.lbhora.AutoSize = true;
            this.lbhora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.Silver;
            this.lbhora.Location = new System.Drawing.Point(257, 9);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(33, 16);
            this.lbhora.TabIndex = 17;
            this.lbhora.Tag = "";
            this.lbhora.Text = "hora";
            this.lbhora.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vs_CrearControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 423);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.dgvListaControles);
            this.Controls.Add(this.lbxListaMarca);
            this.Controls.Add(this.btGuardarControl);
            this.Controls.Add(this.btAgregarImagen);
            this.Controls.Add(this.lbMarcasCompatibles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCondigoControl);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbCodControl);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 422);
            this.Name = "vs_CrearControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vs_CrearControl";
            this.Load += new System.EventHandler(this.vs_CrearControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaControles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodControl;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.PictureBox pbxImagenControl;
        private System.Windows.Forms.Label lbCondigoControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMarcasCompatibles;
        private System.Windows.Forms.Button btAgregarImagen;
        private System.Windows.Forms.Button btGuardarControl;
        private System.Windows.Forms.ListBox lbxListaMarca;
        private System.Windows.Forms.DataGridView dgvListaControles;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Timer timer1;
    }
}