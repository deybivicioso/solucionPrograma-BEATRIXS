namespace WindowsFormsApp1_BEATRIXS
{
    partial class registroUsuario
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
            this.pnlRegistro1 = new System.Windows.Forms.Panel();
            this.pctrbRegistroLogo = new System.Windows.Forms.PictureBox();
            this.pnlRegistro2 = new System.Windows.Forms.Panel();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblRegistroContraseña = new System.Windows.Forms.Label();
            this.txtbRegistroContraseña = new System.Windows.Forms.TextBox();
            this.txtbRegistroEmail = new System.Windows.Forms.TextBox();
            this.lblRegistroEmail = new System.Windows.Forms.Label();
            this.txtbRegistroTelefono = new System.Windows.Forms.TextBox();
            this.lblRegistroTelefono = new System.Windows.Forms.Label();
            this.txtbRegistroApellido = new System.Windows.Forms.TextBox();
            this.lblRegistroApellido = new System.Windows.Forms.Label();
            this.txtbRegistroNombre = new System.Windows.Forms.TextBox();
            this.lblRegistorNombre = new System.Windows.Forms.Label();
            this.lblTituloRegistro = new System.Windows.Forms.Label();
            this.pnlRegistro1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbRegistroLogo)).BeginInit();
            this.pnlRegistro2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegistro1
            // 
            this.pnlRegistro1.BackColor = System.Drawing.Color.White;
            this.pnlRegistro1.Controls.Add(this.pctrbRegistroLogo);
            this.pnlRegistro1.Controls.Add(this.pnlRegistro2);
            this.pnlRegistro1.Location = new System.Drawing.Point(58, 4);
            this.pnlRegistro1.Name = "pnlRegistro1";
            this.pnlRegistro1.Size = new System.Drawing.Size(668, 434);
            this.pnlRegistro1.TabIndex = 0;
            // 
            // pctrbRegistroLogo
            // 
            this.pctrbRegistroLogo.BackColor = System.Drawing.Color.MediumOrchid;
            this.pctrbRegistroLogo.Image = global::WindowsFormsApp1_BEATRIXS.Properties.Resources.BEATRIXS_logo;
            this.pctrbRegistroLogo.Location = new System.Drawing.Point(201, 3);
            this.pctrbRegistroLogo.Name = "pctrbRegistroLogo";
            this.pctrbRegistroLogo.Size = new System.Drawing.Size(212, 135);
            this.pctrbRegistroLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbRegistroLogo.TabIndex = 2;
            this.pctrbRegistroLogo.TabStop = false;
            // 
            // pnlRegistro2
            // 
            this.pnlRegistro2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlRegistro2.Controls.Add(this.btnRegistro);
            this.pnlRegistro2.Controls.Add(this.lblRegistroContraseña);
            this.pnlRegistro2.Controls.Add(this.txtbRegistroContraseña);
            this.pnlRegistro2.Controls.Add(this.txtbRegistroEmail);
            this.pnlRegistro2.Controls.Add(this.lblRegistroEmail);
            this.pnlRegistro2.Controls.Add(this.txtbRegistroTelefono);
            this.pnlRegistro2.Controls.Add(this.lblRegistroTelefono);
            this.pnlRegistro2.Controls.Add(this.txtbRegistroApellido);
            this.pnlRegistro2.Controls.Add(this.lblRegistroApellido);
            this.pnlRegistro2.Controls.Add(this.txtbRegistroNombre);
            this.pnlRegistro2.Controls.Add(this.lblRegistorNombre);
            this.pnlRegistro2.Controls.Add(this.lblTituloRegistro);
            this.pnlRegistro2.Location = new System.Drawing.Point(29, 149);
            this.pnlRegistro2.Name = "pnlRegistro2";
            this.pnlRegistro2.Size = new System.Drawing.Size(596, 264);
            this.pnlRegistro2.TabIndex = 1;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(225, 210);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(88, 32);
            this.btnRegistro.TabIndex = 0;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblRegistroContraseña
            // 
            this.lblRegistroContraseña.AutoSize = true;
            this.lblRegistroContraseña.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroContraseña.Location = new System.Drawing.Point(17, 169);
            this.lblRegistroContraseña.Name = "lblRegistroContraseña";
            this.lblRegistroContraseña.Size = new System.Drawing.Size(94, 18);
            this.lblRegistroContraseña.TabIndex = 10;
            this.lblRegistroContraseña.Text = "Contraseña:";
            // 
            // txtbRegistroContraseña
            // 
            this.txtbRegistroContraseña.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbRegistroContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbRegistroContraseña.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRegistroContraseña.Location = new System.Drawing.Point(117, 169);
            this.txtbRegistroContraseña.Name = "txtbRegistroContraseña";
            this.txtbRegistroContraseña.Size = new System.Drawing.Size(151, 19);
            this.txtbRegistroContraseña.TabIndex = 5;
            this.txtbRegistroContraseña.Text = "CONTRASEÑA";
            this.txtbRegistroContraseña.Enter += new System.EventHandler(this.txtbRegistroContraseña_Enter);
            this.txtbRegistroContraseña.Leave += new System.EventHandler(this.txtbRegistroContraseña_Leave);
            // 
            // txtbRegistroEmail
            // 
            this.txtbRegistroEmail.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbRegistroEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbRegistroEmail.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRegistroEmail.Location = new System.Drawing.Point(100, 141);
            this.txtbRegistroEmail.Name = "txtbRegistroEmail";
            this.txtbRegistroEmail.Size = new System.Drawing.Size(168, 19);
            this.txtbRegistroEmail.TabIndex = 4;
            this.txtbRegistroEmail.Text = "E-MAIL";
            this.txtbRegistroEmail.Enter += new System.EventHandler(this.txtbRegistroEmail_Enter);
            this.txtbRegistroEmail.Leave += new System.EventHandler(this.txtbRegistroEmail_Leave);
            // 
            // lblRegistroEmail
            // 
            this.lblRegistroEmail.AutoSize = true;
            this.lblRegistroEmail.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroEmail.Location = new System.Drawing.Point(17, 141);
            this.lblRegistroEmail.Name = "lblRegistroEmail";
            this.lblRegistroEmail.Size = new System.Drawing.Size(70, 18);
            this.lblRegistroEmail.TabIndex = 7;
            this.lblRegistroEmail.Text = "E-mail: ";
            // 
            // txtbRegistroTelefono
            // 
            this.txtbRegistroTelefono.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbRegistroTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbRegistroTelefono.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRegistroTelefono.Location = new System.Drawing.Point(126, 113);
            this.txtbRegistroTelefono.Name = "txtbRegistroTelefono";
            this.txtbRegistroTelefono.Size = new System.Drawing.Size(142, 19);
            this.txtbRegistroTelefono.TabIndex = 3;
            this.txtbRegistroTelefono.Text = "TELEFONO";
            this.txtbRegistroTelefono.Enter += new System.EventHandler(this.txtbRegistroTelefono_Enter);
            this.txtbRegistroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbRegistroTelefono_KeyPress);
            this.txtbRegistroTelefono.Leave += new System.EventHandler(this.txtbRegistroTelefono_Leave);
            // 
            // lblRegistroTelefono
            // 
            this.lblRegistroTelefono.AutoSize = true;
            this.lblRegistroTelefono.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroTelefono.Location = new System.Drawing.Point(17, 113);
            this.lblRegistroTelefono.Name = "lblRegistroTelefono";
            this.lblRegistroTelefono.Size = new System.Drawing.Size(102, 18);
            this.lblRegistroTelefono.TabIndex = 5;
            this.lblRegistroTelefono.Text = "No.Telefono:";
            // 
            // txtbRegistroApellido
            // 
            this.txtbRegistroApellido.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbRegistroApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbRegistroApellido.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRegistroApellido.Location = new System.Drawing.Point(100, 85);
            this.txtbRegistroApellido.Name = "txtbRegistroApellido";
            this.txtbRegistroApellido.Size = new System.Drawing.Size(168, 19);
            this.txtbRegistroApellido.TabIndex = 2;
            this.txtbRegistroApellido.Text = "APELLIDO";
            this.txtbRegistroApellido.Enter += new System.EventHandler(this.txtbRegistroApellido_Enter);
            this.txtbRegistroApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbRegistroApellido_KeyPress);
            this.txtbRegistroApellido.Leave += new System.EventHandler(this.txtbRegistroApellido_Leave);
            // 
            // lblRegistroApellido
            // 
            this.lblRegistroApellido.AutoSize = true;
            this.lblRegistroApellido.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroApellido.Location = new System.Drawing.Point(17, 85);
            this.lblRegistroApellido.Name = "lblRegistroApellido";
            this.lblRegistroApellido.Size = new System.Drawing.Size(76, 18);
            this.lblRegistroApellido.TabIndex = 3;
            this.lblRegistroApellido.Text = "Apellido:";
            // 
            // txtbRegistroNombre
            // 
            this.txtbRegistroNombre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbRegistroNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbRegistroNombre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRegistroNombre.Location = new System.Drawing.Point(100, 57);
            this.txtbRegistroNombre.Name = "txtbRegistroNombre";
            this.txtbRegistroNombre.Size = new System.Drawing.Size(168, 19);
            this.txtbRegistroNombre.TabIndex = 1;
            this.txtbRegistroNombre.Text = "NOMBRE";
            this.txtbRegistroNombre.Enter += new System.EventHandler(this.txtbRegistroNombre_Enter);
            this.txtbRegistroNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbRegistroNombre_KeyPress);
            this.txtbRegistroNombre.Leave += new System.EventHandler(this.txtbRegistroNombre_Leave);
            // 
            // lblRegistorNombre
            // 
            this.lblRegistorNombre.AutoSize = true;
            this.lblRegistorNombre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistorNombre.Location = new System.Drawing.Point(17, 57);
            this.lblRegistorNombre.Name = "lblRegistorNombre";
            this.lblRegistorNombre.Size = new System.Drawing.Size(69, 18);
            this.lblRegistorNombre.TabIndex = 1;
            this.lblRegistorNombre.Text = "Nombre:";
            // 
            // lblTituloRegistro
            // 
            this.lblTituloRegistro.AutoSize = true;
            this.lblTituloRegistro.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRegistro.Location = new System.Drawing.Point(219, 13);
            this.lblTituloRegistro.Name = "lblTituloRegistro";
            this.lblTituloRegistro.Size = new System.Drawing.Size(146, 31);
            this.lblTituloRegistro.TabIndex = 0;
            this.lblTituloRegistro.Text = "Registro..";
            // 
            // registroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRegistro1);
            this.Name = "registroUsuario";
            this.Text = "Registro de Nuevo Usuario";
            this.pnlRegistro1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbRegistroLogo)).EndInit();
            this.pnlRegistro2.ResumeLayout(false);
            this.pnlRegistro2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistro1;
        private System.Windows.Forms.Panel pnlRegistro2;
        private System.Windows.Forms.Label lblTituloRegistro;
        private System.Windows.Forms.Label lblRegistorNombre;
        private System.Windows.Forms.TextBox txtbRegistroNombre;
        private System.Windows.Forms.Label lblRegistroApellido;
        private System.Windows.Forms.TextBox txtbRegistroApellido;
        private System.Windows.Forms.Label lblRegistroTelefono;
        private System.Windows.Forms.TextBox txtbRegistroTelefono;
        private System.Windows.Forms.Label lblRegistroEmail;
        private System.Windows.Forms.TextBox txtbRegistroEmail;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label lblRegistroContraseña;
        private System.Windows.Forms.TextBox txtbRegistroContraseña;
        private System.Windows.Forms.PictureBox pctrbRegistroLogo;
    }
}