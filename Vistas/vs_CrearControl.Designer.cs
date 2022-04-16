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
            this.tbCodControl = new System.Windows.Forms.TextBox();
            this.clbxListaDeMarcas = new System.Windows.Forms.CheckedListBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.pbxImagenControl = new System.Windows.Forms.PictureBox();
            this.lbCondigoControl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMarcasCompatibles = new System.Windows.Forms.Label();
            this.btAgregarImagen = new System.Windows.Forms.Button();
            this.btGuardarControl = new System.Windows.Forms.Button();
            this.btInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCodControl
            // 
            this.tbCodControl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodControl.Location = new System.Drawing.Point(12, 65);
            this.tbCodControl.Name = "tbCodControl";
            this.tbCodControl.Size = new System.Drawing.Size(145, 30);
            this.tbCodControl.TabIndex = 0;
            // 
            // clbxListaDeMarcas
            // 
            this.clbxListaDeMarcas.FormattingEnabled = true;
            this.clbxListaDeMarcas.Location = new System.Drawing.Point(12, 195);
            this.clbxListaDeMarcas.Name = "clbxListaDeMarcas";
            this.clbxListaDeMarcas.Size = new System.Drawing.Size(155, 154);
            this.clbxListaDeMarcas.TabIndex = 1;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(12, 135);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(145, 29);
            this.tbCantidad.TabIndex = 2;
            // 
            // pbxImagenControl
            // 
            this.pbxImagenControl.Location = new System.Drawing.Point(221, 12);
            this.pbxImagenControl.Name = "pbxImagenControl";
            this.pbxImagenControl.Size = new System.Drawing.Size(221, 279);
            this.pbxImagenControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenControl.TabIndex = 3;
            this.pbxImagenControl.TabStop = false;
            // 
            // lbCondigoControl
            // 
            this.lbCondigoControl.AutoSize = true;
            this.lbCondigoControl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbCondigoControl.Location = new System.Drawing.Point(12, 49);
            this.lbCondigoControl.Name = "lbCondigoControl";
            this.lbCondigoControl.Size = new System.Drawing.Size(94, 13);
            this.lbCondigoControl.TabIndex = 4;
            this.lbCondigoControl.Text = "Codigo de Control:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMarcasCompatibles
            // 
            this.lbMarcasCompatibles.AutoSize = true;
            this.lbMarcasCompatibles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbMarcasCompatibles.Location = new System.Drawing.Point(12, 179);
            this.lbMarcasCompatibles.Name = "lbMarcasCompatibles";
            this.lbMarcasCompatibles.Size = new System.Drawing.Size(102, 13);
            this.lbMarcasCompatibles.TabIndex = 6;
            this.lbMarcasCompatibles.Text = "Marcas Compatibles";
            // 
            // btAgregarImagen
            // 
            this.btAgregarImagen.Location = new System.Drawing.Point(292, 297);
            this.btAgregarImagen.Name = "btAgregarImagen";
            this.btAgregarImagen.Size = new System.Drawing.Size(94, 23);
            this.btAgregarImagen.TabIndex = 7;
            this.btAgregarImagen.Text = "Subir Imagen";
            this.btAgregarImagen.UseVisualStyleBackColor = true;
            this.btAgregarImagen.Click += new System.EventHandler(this.btAgregarImagen_Click);
            // 
            // btGuardarControl
            // 
            this.btGuardarControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btGuardarControl.Location = new System.Drawing.Point(221, 326);
            this.btGuardarControl.Name = "btGuardarControl";
            this.btGuardarControl.Size = new System.Drawing.Size(91, 23);
            this.btGuardarControl.TabIndex = 8;
            this.btGuardarControl.Text = "Guardar Control";
            this.btGuardarControl.UseVisualStyleBackColor = false;
            this.btGuardarControl.Click += new System.EventHandler(this.btGuardarControl_Click);
            // 
            // btInicio
            // 
            this.btInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btInicio.Location = new System.Drawing.Point(367, 326);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(75, 23);
            this.btInicio.TabIndex = 9;
            this.btInicio.Text = "Inicio";
            this.btInicio.UseVisualStyleBackColor = false;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // vs_CrearControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btInicio);
            this.Controls.Add(this.btGuardarControl);
            this.Controls.Add(this.btAgregarImagen);
            this.Controls.Add(this.lbMarcasCompatibles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCondigoControl);
            this.Controls.Add(this.pbxImagenControl);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.clbxListaDeMarcas);
            this.Controls.Add(this.tbCodControl);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "vs_CrearControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vs_CrearControl";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodControl;
        private System.Windows.Forms.CheckedListBox clbxListaDeMarcas;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.PictureBox pbxImagenControl;
        private System.Windows.Forms.Label lbCondigoControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMarcasCompatibles;
        private System.Windows.Forms.Button btAgregarImagen;
        private System.Windows.Forms.Button btGuardarControl;
        private System.Windows.Forms.Button btInicio;
    }
}