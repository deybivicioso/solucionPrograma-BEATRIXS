
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
            this.pctrbLogo2 = new System.Windows.Forms.PictureBox();
            this.pctrbCerrar2 = new System.Windows.Forms.PictureBox();
            this.pctrbMinimizar2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbCerrar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbMinimizar2)).BeginInit();
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
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.lnklblLogin);
            this.panel2.Controls.Add(this.btnAceptarLogin);
            this.panel2.Controls.Add(this.btnRegistrarse);
            this.panel2.Controls.Add(this.txtbContraseña);
            this.panel2.Controls.Add(this.lblConstraseña);
            this.panel2.Controls.Add(this.txtbNombre);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lblLogin);
            this.panel2.Location = new System.Drawing.Point(287, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 333);
            this.panel2.TabIndex = 3;
            // 
            // lnklblLogin
            // 
            this.lnklblLogin.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lnklblLogin.AutoSize = true;
            this.lnklblLogin.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblLogin.LinkColor = System.Drawing.Color.Black;
            this.lnklblLogin.Location = new System.Drawing.Point(152, 218);
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
            this.btnAceptarLogin.Location = new System.Drawing.Point(238, 168);
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
            this.btnRegistrarse.Location = new System.Drawing.Point(152, 168);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 30);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(253)))), ((int)(((byte)(235)))));
            this.txtbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbContraseña.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbContraseña.Location = new System.Drawing.Point(152, 118);
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
            this.lblConstraseña.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstraseña.Location = new System.Drawing.Point(20, 118);
            this.lblConstraseña.Name = "lblConstraseña";
            this.lblConstraseña.Size = new System.Drawing.Size(106, 24);
            this.lblConstraseña.TabIndex = 3;
            this.lblConstraseña.Text = "Contraseña:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(253)))), ((int)(((byte)(235)))));
            this.txtbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.Location = new System.Drawing.Point(152, 68);
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
            this.lblNombre.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 24);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(157, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(97, 34);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(113)))));
            this.panel3.Controls.Add(this.pctrbLogo2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 392);
            this.panel3.TabIndex = 2;
            // 
            // pctrbLogo2
            // 
            this.pctrbLogo2.Image = global::WindowsFormsApp1_BEATRIXS.Properties.Resources.logoPrincipal;
            this.pctrbLogo2.Location = new System.Drawing.Point(3, 33);
            this.pctrbLogo2.Name = "pctrbLogo2";
            this.pctrbLogo2.Size = new System.Drawing.Size(213, 123);
            this.pctrbLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbLogo2.TabIndex = 0;
            this.pctrbLogo2.TabStop = false;
            // 
            // pctrbCerrar2
            // 
            this.pctrbCerrar2.Image = global::WindowsFormsApp1_BEATRIXS.Properties.Resources.closse;
            this.pctrbCerrar2.Location = new System.Drawing.Point(780, 0);
            this.pctrbCerrar2.Name = "pctrbCerrar2";
            this.pctrbCerrar2.Size = new System.Drawing.Size(30, 30);
            this.pctrbCerrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbCerrar2.TabIndex = 7;
            this.pctrbCerrar2.TabStop = false;
            this.pctrbCerrar2.Click += new System.EventHandler(this.pctrbCerrar2_Click);
            // 
            // pctrbMinimizar2
            // 
            this.pctrbMinimizar2.Image = global::WindowsFormsApp1_BEATRIXS.Properties.Resources.minuss;
            this.pctrbMinimizar2.Location = new System.Drawing.Point(753, 0);
            this.pctrbMinimizar2.Name = "pctrbMinimizar2";
            this.pctrbMinimizar2.Size = new System.Drawing.Size(30, 30);
            this.pctrbMinimizar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbMinimizar2.TabIndex = 8;
            this.pctrbMinimizar2.TabStop = false;
            this.pctrbMinimizar2.Click += new System.EventHandler(this.pctrbMinimizar2_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(253)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(812, 392);
            this.Controls.Add(this.pctrbMinimizar2);
            this.Controls.Add(this.pctrbCerrar2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbCerrar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbMinimizar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.PictureBox pctrbLogo2;
        private System.Windows.Forms.PictureBox pctrbCerrar2;
        private System.Windows.Forms.PictureBox pctrbMinimizar2;
    }
}