
namespace WindowsFormsApp1_BEATRIXS
{
    
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctrbLoginImagen = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnklblLogin = new System.Windows.Forms.LinkLabel();
            this.btnAceptarLogin = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.lblConstraseña = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pctrbMinimizar = new System.Windows.Forms.PictureBox();
            this.PCTRBCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbLoginImagen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCTRBCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.pctrbLoginImagen);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(300, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 337);
            this.panel1.TabIndex = 1;
            // 
            // pctrbLoginImagen
            // 
            this.pctrbLoginImagen.BackColor = System.Drawing.Color.MediumOrchid;
            this.pctrbLoginImagen.Image = global::WindowsFormsApp1_BEATRIXS.Properties.Resources.BEATRIXS_logo;
            this.pctrbLoginImagen.Location = new System.Drawing.Point(118, 3);
            this.pctrbLoginImagen.Name = "pctrbLoginImagen";
            this.pctrbLoginImagen.Size = new System.Drawing.Size(126, 76);
            this.pctrbLoginImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbLoginImagen.TabIndex = 4;
            this.pctrbLoginImagen.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.lnklblLogin);
            this.panel2.Controls.Add(this.btnAceptarLogin);
            this.panel2.Controls.Add(this.btnRegistrarse);
            this.panel2.Controls.Add(this.txtbContraseña);
            this.panel2.Controls.Add(this.lblConstraseña);
            this.panel2.Controls.Add(this.txtbNombre);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lblLogin);
            this.panel2.Location = new System.Drawing.Point(13, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 241);
            this.panel2.TabIndex = 3;
            // 
            // lnklblLogin
            // 
            this.lnklblLogin.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lnklblLogin.AutoSize = true;
            this.lnklblLogin.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblLogin.LinkColor = System.Drawing.Color.Black;
            this.lnklblLogin.Location = new System.Drawing.Point(138, 168);
            this.lnklblLogin.Name = "lnklblLogin";
            this.lnklblLogin.Size = new System.Drawing.Size(161, 15);
            this.lnklblLogin.TabIndex = 0;
            this.lnklblLogin.TabStop = true;
            this.lnklblLogin.Text = "Has olvidado tu contraseña ?\r\n";
            // 
            // btnAceptarLogin
            // 
            this.btnAceptarLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAceptarLogin.FlatAppearance.BorderSize = 0;
            this.btnAceptarLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarLogin.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarLogin.Location = new System.Drawing.Point(224, 130);
            this.btnAceptarLogin.Name = "btnAceptarLogin";
            this.btnAceptarLogin.Size = new System.Drawing.Size(75, 30);
            this.btnAceptarLogin.TabIndex = 6;
            this.btnAceptarLogin.Text = "Aceptar";
            this.btnAceptarLogin.UseVisualStyleBackColor = false;
            this.btnAceptarLogin.Click += new System.EventHandler(this.btnAceptLogin_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(138, 130);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 30);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbContraseña.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbContraseña.Location = new System.Drawing.Point(138, 92);
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.Size = new System.Drawing.Size(161, 19);
            this.txtbContraseña.TabIndex = 3;
            this.txtbContraseña.Text = "CONTRASEÑA";
            this.txtbContraseña.Enter += new System.EventHandler(this.txtbContraseña_Enter);            
            this.txtbContraseña.Leave += new System.EventHandler(this.txtbContraseña_Leave);
            // 
            // lblConstraseña
            // 
            this.lblConstraseña.AutoSize = true;
            this.lblConstraseña.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstraseña.Location = new System.Drawing.Point(20, 95);
            this.lblConstraseña.Name = "lblConstraseña";
            this.lblConstraseña.Size = new System.Drawing.Size(94, 18);
            this.lblConstraseña.TabIndex = 3;
            this.lblConstraseña.Text = "Contraseña:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.Location = new System.Drawing.Point(138, 63);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(161, 19);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.Text = "USUARIO";
            this.txtbNombre.Enter += new System.EventHandler(this.txtbNombre_Enter);
            this.txtbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombre_KeyPress);
            this.txtbNombre.Leave += new System.EventHandler(this.txtbNombre_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(24, 12);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(90, 31);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 402);
            this.panel3.TabIndex = 2;
            // 
            // pctrbMinimizar
            // 
            this.pctrbMinimizar.Image = global::WindowsFormsApp1_BEATRIXS.Properties.Resources.minimizar;
            this.pctrbMinimizar.Location = new System.Drawing.Point(721, 0);
            this.pctrbMinimizar.Name = "pctrbMinimizar";
            this.pctrbMinimizar.Size = new System.Drawing.Size(26, 27);
            this.pctrbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbMinimizar.TabIndex = 4;
            this.pctrbMinimizar.TabStop = false;
            this.pctrbMinimizar.Click += new System.EventHandler(this.pctrbMinimizar_Click);
            // 
            // PCTRBCerrar
            // 
            this.PCTRBCerrar.Image = global::WindowsFormsApp1_BEATRIXS.Properties.Resources.close_button;
            this.PCTRBCerrar.Location = new System.Drawing.Point(753, 0);
            this.PCTRBCerrar.Name = "PCTRBCerrar";
            this.PCTRBCerrar.Size = new System.Drawing.Size(26, 27);
            this.PCTRBCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCTRBCerrar.TabIndex = 3;
            this.PCTRBCerrar.TabStop = false;
            this.PCTRBCerrar.Click += new System.EventHandler(this.PCTRBCerrar_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(780, 402);
            this.Controls.Add(this.pctrbMinimizar);
            this.Controls.Add(this.PCTRBCerrar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbLoginImagen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCTRBCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.Label lblConstraseña;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnAceptarLogin;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel lnklblLogin;
        private System.Windows.Forms.PictureBox pctrbLoginImagen;
        private System.Windows.Forms.PictureBox PCTRBCerrar;
        private System.Windows.Forms.PictureBox pctrbMinimizar;
    }
}