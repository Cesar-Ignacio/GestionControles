﻿namespace GestionControl.Vistas
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
            this.cbxMarcaControl = new System.Windows.Forms.ComboBox();
            this.lbTituloNombreMarca = new System.Windows.Forms.Label();
            this.btInicio = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // btInicio
            // 
            this.btInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btInicio.Location = new System.Drawing.Point(697, 42);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(75, 37);
            this.btInicio.TabIndex = 5;
            this.btInicio.Text = "Inicio";
            this.btInicio.UseVisualStyleBackColor = false;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBuscar.Location = new System.Drawing.Point(471, 42);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 37);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 364);
            this.dataGridView1.TabIndex = 7;
            // 
            // vs_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btInicio);
            this.Controls.Add(this.lbTituloNombreMarca);
            this.Controls.Add(this.cbxMarcaControl);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "vs_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vs_Consultas";
            this.Load += new System.EventHandler(this.vs_Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMarcaControl;
        private System.Windows.Forms.Label lbTituloNombreMarca;
        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}