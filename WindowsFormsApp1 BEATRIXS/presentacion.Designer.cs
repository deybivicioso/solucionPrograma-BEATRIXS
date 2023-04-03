namespace WindowsFormsApp1_BEATRIXS
{
    partial class presentacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelPresentacion = new System.Windows.Forms.Panel();
            this.prgrbCarga = new System.Windows.Forms.ProgressBar();
            this.lblCargando = new System.Windows.Forms.Label();
            this.tmrPresentacion = new System.Windows.Forms.Timer(this.components);
            this.lblPocertajeCarga = new System.Windows.Forms.Label();
            this.lblLogoPorciento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptrbLogo1 = new System.Windows.Forms.PictureBox();
            this.panelPresentacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPresentacion
            // 
            this.panelPresentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(113)))));
            this.panelPresentacion.Controls.Add(this.ptrbLogo1);
            this.panelPresentacion.Location = new System.Drawing.Point(104, 41);
            this.panelPresentacion.Name = "panelPresentacion";
            this.panelPresentacion.Size = new System.Drawing.Size(422, 217);
            this.panelPresentacion.TabIndex = 0;
            // 
            // prgrbCarga
            // 
            this.prgrbCarga.Location = new System.Drawing.Point(128, 265);
            this.prgrbCarga.Name = "prgrbCarga";
            this.prgrbCarga.Size = new System.Drawing.Size(374, 23);
            this.prgrbCarga.TabIndex = 1;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCargando.Location = new System.Drawing.Point(219, 286);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(120, 28);
            this.lblCargando.TabIndex = 2;
            this.lblCargando.Text = "Cargando: ";
            // 
            // tmrPresentacion
            // 
            this.tmrPresentacion.Tick += new System.EventHandler(this.tmrPresentacion_Tick);
            // 
            // lblPocertajeCarga
            // 
            this.lblPocertajeCarga.AutoSize = true;
            this.lblPocertajeCarga.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPocertajeCarga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPocertajeCarga.Location = new System.Drawing.Point(331, 289);
            this.lblPocertajeCarga.Name = "lblPocertajeCarga";
            this.lblPocertajeCarga.Size = new System.Drawing.Size(28, 21);
            this.lblPocertajeCarga.TabIndex = 3;
            this.lblPocertajeCarga.Text = " h";
            // 
            // lblLogoPorciento
            // 
            this.lblLogoPorciento.AutoSize = true;
            this.lblLogoPorciento.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoPorciento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogoPorciento.Location = new System.Drawing.Point(365, 291);
            this.lblLogoPorciento.Name = "lblLogoPorciento";
            this.lblLogoPorciento.Size = new System.Drawing.Size(19, 21);
            this.lblLogoPorciento.TabIndex = 4;
            this.lblLogoPorciento.Text = "%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ptrbLogo1
            // 
            this.ptrbLogo1.Image = global::WindowsFormsApp1_BEATRIXS.Properties.Resources.logoPrincipal;
            this.ptrbLogo1.Location = new System.Drawing.Point(24, 27);
            this.ptrbLogo1.Name = "ptrbLogo1";
            this.ptrbLogo1.Size = new System.Drawing.Size(357, 168);
            this.ptrbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrbLogo1.TabIndex = 0;
            this.ptrbLogo1.TabStop = false;
            // 
            // presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(253)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(644, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLogoPorciento);
            this.Controls.Add(this.lblPocertajeCarga);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.prgrbCarga);
            this.Controls.Add(this.panelPresentacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "presentacion";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEATRIXS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.presentacion_FormClosing);
            this.Load += new System.EventHandler(this.presentacion_Load);
            this.panelPresentacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbLogo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPresentacion;
        private System.Windows.Forms.ProgressBar prgrbCarga;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.Timer tmrPresentacion;
        private System.Windows.Forms.Label lblPocertajeCarga;
        private System.Windows.Forms.Label lblLogoPorciento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptrbLogo1;
    }
}

