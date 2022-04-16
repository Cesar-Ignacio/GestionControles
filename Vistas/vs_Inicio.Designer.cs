namespace GestionControl.Vistas
{
    partial class vs_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vs_Inicio));
            this.btnAgregarControl = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarControl
            // 
            this.btnAgregarControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarControl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarControl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarControl.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarControl.Image")));
            this.btnAgregarControl.Location = new System.Drawing.Point(327, 83);
            this.btnAgregarControl.Name = "btnAgregarControl";
            this.btnAgregarControl.Size = new System.Drawing.Size(179, 156);
            this.btnAgregarControl.TabIndex = 1;
            this.btnAgregarControl.Text = "Agregar Control";
            this.btnAgregarControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarControl.UseVisualStyleBackColor = true;
            this.btnAgregarControl.Click += new System.EventHandler(this.btnAgregarControl_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.Location = new System.Drawing.Point(85, 83);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(179, 156);
            this.btnConsultas.TabIndex = 0;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.button1_Click);
            // 
            // vs_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnAgregarControl);
            this.Controls.Add(this.btnConsultas);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "vs_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vs_Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnAgregarControl;
    }
}