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
            this.btInicio = new System.Windows.Forms.Button();
            this.btGuardarControl = new System.Windows.Forms.Button();
            this.pbxImagenControl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaControles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCodControl
            // 
            this.tbCodControl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodControl.Location = new System.Drawing.Point(45, 86);
            this.tbCodControl.Name = "tbCodControl";
            this.tbCodControl.Size = new System.Drawing.Size(145, 30);
            this.tbCodControl.TabIndex = 0;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(45, 156);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(145, 29);
            this.tbCantidad.TabIndex = 2;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // lbCondigoControl
            // 
            this.lbCondigoControl.AutoSize = true;
            this.lbCondigoControl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbCondigoControl.Location = new System.Drawing.Point(45, 70);
            this.lbCondigoControl.Name = "lbCondigoControl";
            this.lbCondigoControl.Size = new System.Drawing.Size(94, 13);
            this.lbCondigoControl.TabIndex = 4;
            this.lbCondigoControl.Text = "Codigo de Control:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(45, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad:";
            // 
            // lbMarcasCompatibles
            // 
            this.lbMarcasCompatibles.AutoSize = true;
            this.lbMarcasCompatibles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbMarcasCompatibles.Location = new System.Drawing.Point(45, 200);
            this.lbMarcasCompatibles.Name = "lbMarcasCompatibles";
            this.lbMarcasCompatibles.Size = new System.Drawing.Size(102, 13);
            this.lbMarcasCompatibles.TabIndex = 6;
            this.lbMarcasCompatibles.Text = "Marcas Compatibles";
            // 
            // btAgregarImagen
            // 
            this.btAgregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregarImagen.Location = new System.Drawing.Point(477, 237);
            this.btAgregarImagen.Name = "btAgregarImagen";
            this.btAgregarImagen.Size = new System.Drawing.Size(94, 23);
            this.btAgregarImagen.TabIndex = 7;
            this.btAgregarImagen.Text = "Subir Imagen";
            this.btAgregarImagen.UseVisualStyleBackColor = true;
            this.btAgregarImagen.Click += new System.EventHandler(this.btAgregarImagen_Click);
            // 
            // lbxListaMarca
            // 
            this.lbxListaMarca.FormattingEnabled = true;
            this.lbxListaMarca.Location = new System.Drawing.Point(247, 67);
            this.lbxListaMarca.Name = "lbxListaMarca";
            this.lbxListaMarca.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxListaMarca.Size = new System.Drawing.Size(145, 160);
            this.lbxListaMarca.Sorted = true;
            this.lbxListaMarca.TabIndex = 10;
            // 
            // dgvListaControles
            // 
            this.dgvListaControles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaControles.Location = new System.Drawing.Point(45, 299);
            this.dgvListaControles.Name = "dgvListaControles";
            this.dgvListaControles.ReadOnly = true;
            this.dgvListaControles.Size = new System.Drawing.Size(584, 150);
            this.dgvListaControles.TabIndex = 11;
            this.dgvListaControles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.Image = global::GestionControl.Properties.Resources.prohibicion;
            this.btCancelar.Location = new System.Drawing.Point(309, 253);
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
            this.btModificar.Location = new System.Drawing.Point(220, 253);
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
            this.btEliminar.Location = new System.Drawing.Point(131, 253);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(59, 40);
            this.btEliminar.TabIndex = 12;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btInicio
            // 
            this.btInicio.BackColor = System.Drawing.Color.Transparent;
            this.btInicio.Image = global::GestionControl.Properties.Resources.hogar;
            this.btInicio.Location = new System.Drawing.Point(45, 12);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(52, 43);
            this.btInicio.TabIndex = 9;
            this.btInicio.UseVisualStyleBackColor = false;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // btGuardarControl
            // 
            this.btGuardarControl.BackColor = System.Drawing.Color.Transparent;
            this.btGuardarControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardarControl.Image = ((System.Drawing.Image)(resources.GetObject("btGuardarControl.Image")));
            this.btGuardarControl.Location = new System.Drawing.Point(48, 253);
            this.btGuardarControl.Name = "btGuardarControl";
            this.btGuardarControl.Size = new System.Drawing.Size(58, 40);
            this.btGuardarControl.TabIndex = 8;
            this.btGuardarControl.UseVisualStyleBackColor = false;
            this.btGuardarControl.Click += new System.EventHandler(this.btGuardarControl_Click);
            // 
            // pbxImagenControl
            // 
            this.pbxImagenControl.Location = new System.Drawing.Point(408, 12);
            this.pbxImagenControl.Name = "pbxImagenControl";
            this.pbxImagenControl.Size = new System.Drawing.Size(221, 219);
            this.pbxImagenControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenControl.TabIndex = 3;
            this.pbxImagenControl.TabStop = false;
            // 
            // vs_CrearControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.dgvListaControles);
            this.Controls.Add(this.lbxListaMarca);
            this.Controls.Add(this.btInicio);
            this.Controls.Add(this.btGuardarControl);
            this.Controls.Add(this.btAgregarImagen);
            this.Controls.Add(this.lbMarcasCompatibles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCondigoControl);
            this.Controls.Add(this.pbxImagenControl);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbCodControl);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "vs_CrearControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vs_CrearControl";
            this.Load += new System.EventHandler(this.vs_CrearControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaControles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenControl)).EndInit();
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
        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.ListBox lbxListaMarca;
        private System.Windows.Forms.DataGridView dgvListaControles;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btCancelar;
    }
}