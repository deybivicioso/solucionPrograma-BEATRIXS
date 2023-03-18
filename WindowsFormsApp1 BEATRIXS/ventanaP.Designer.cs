namespace WindowsFormsApp1_BEATRIXS
{
    partial class ventanaP
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
            this.pnlVentanaP1 = new System.Windows.Forms.Panel();
            this.btnVentanaPAceptar = new System.Windows.Forms.Button();
            this.pnlVentanaP3 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbCodePostal = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.txtbNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccionRemitente = new System.Windows.Forms.Label();
            this.txtbDestinatario = new System.Windows.Forms.TextBox();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.pnlVentanaP2 = new System.Windows.Forms.Panel();
            this.chckbxToxico = new System.Windows.Forms.CheckBox();
            this.chckbxInflamable = new System.Windows.Forms.CheckBox();
            this.lbltipoMaterial = new System.Windows.Forms.Label();
            this.lblLibras = new System.Windows.Forms.Label();
            this.cmbbMaterialProucto = new System.Windows.Forms.ComboBox();
            this.txtbPesomaterial = new System.Windows.Forms.TextBox();
            this.lblPesoProducto = new System.Windows.Forms.Label();
            this.lblMaterialProducto = new System.Windows.Forms.Label();
            this.txtbNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblVentanaPTitulo = new System.Windows.Forms.Label();
            this.pnlVentanaP1.SuspendLayout();
            this.pnlVentanaP3.SuspendLayout();
            this.pnlVentanaP2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVentanaP1
            // 
            this.pnlVentanaP1.BackColor = System.Drawing.Color.MediumBlue;
            this.pnlVentanaP1.Controls.Add(this.btnVentanaPAceptar);
            this.pnlVentanaP1.Controls.Add(this.pnlVentanaP3);
            this.pnlVentanaP1.Controls.Add(this.pnlVentanaP2);
            this.pnlVentanaP1.Location = new System.Drawing.Point(13, 58);
            this.pnlVentanaP1.Name = "pnlVentanaP1";
            this.pnlVentanaP1.Size = new System.Drawing.Size(634, 437);
            this.pnlVentanaP1.TabIndex = 0;
            // 
            // btnVentanaPAceptar
            // 
            this.btnVentanaPAceptar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVentanaPAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVentanaPAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVentanaPAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentanaPAceptar.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentanaPAceptar.Location = new System.Drawing.Point(276, 384);
            this.btnVentanaPAceptar.Name = "btnVentanaPAceptar";
            this.btnVentanaPAceptar.Size = new System.Drawing.Size(85, 28);
            this.btnVentanaPAceptar.TabIndex = 0;
            this.btnVentanaPAceptar.Text = "Guardar";
            this.btnVentanaPAceptar.UseVisualStyleBackColor = false;
            this.btnVentanaPAceptar.Click += new System.EventHandler(this.btnVentanaPAceptar_Click);
            // 
            // pnlVentanaP3
            // 
            this.pnlVentanaP3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlVentanaP3.Controls.Add(this.txtEmail);
            this.pnlVentanaP3.Controls.Add(this.lblEmail);
            this.pnlVentanaP3.Controls.Add(this.txtbCodePostal);
            this.pnlVentanaP3.Controls.Add(this.lblCodePostal);
            this.pnlVentanaP3.Controls.Add(this.txtbNumeroTelefonico);
            this.pnlVentanaP3.Controls.Add(this.lblNumeroTelefono);
            this.pnlVentanaP3.Controls.Add(this.txtbDireccion);
            this.pnlVentanaP3.Controls.Add(this.lblDireccionRemitente);
            this.pnlVentanaP3.Controls.Add(this.txtbDestinatario);
            this.pnlVentanaP3.Controls.Add(this.lblRemitente);
            this.pnlVentanaP3.Location = new System.Drawing.Point(366, 15);
            this.pnlVentanaP3.Name = "pnlVentanaP3";
            this.pnlVentanaP3.Size = new System.Drawing.Size(253, 352);
            this.pnlVentanaP3.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(18, 291);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 18);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "E-MAIL";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(18, 261);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtbCodePostal
            // 
            this.txtbCodePostal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbCodePostal.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCodePostal.Location = new System.Drawing.Point(18, 171);
            this.txtbCodePostal.Name = "txtbCodePostal";
            this.txtbCodePostal.Size = new System.Drawing.Size(165, 17);
            this.txtbCodePostal.TabIndex = 7;
            this.txtbCodePostal.Text = "CODE";
            this.txtbCodePostal.Enter += new System.EventHandler(this.txtbCodePostal_Enter);
            this.txtbCodePostal.Leave += new System.EventHandler(this.txtbCodePostal_Leave);
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostal.Location = new System.Drawing.Point(18, 141);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(114, 18);
            this.lblCodePostal.TabIndex = 6;
            this.lblCodePostal.Text = "Codigo Postal:";
            // 
            // txtbNumeroTelefonico
            // 
            this.txtbNumeroTelefonico.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbNumeroTelefonico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNumeroTelefonico.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNumeroTelefonico.Location = new System.Drawing.Point(18, 231);
            this.txtbNumeroTelefonico.Name = "txtbNumeroTelefonico";
            this.txtbNumeroTelefonico.Size = new System.Drawing.Size(165, 18);
            this.txtbNumeroTelefonico.TabIndex = 5;
            this.txtbNumeroTelefonico.Text = "TELEFONO";
            this.txtbNumeroTelefonico.Enter += new System.EventHandler(this.txtbNumeroTelefonico_Enter);
            this.txtbNumeroTelefonico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNumeroTelefonico_KeyPress);
            this.txtbNumeroTelefonico.Leave += new System.EventHandler(this.txtbNumeroTelefonico_Leave);
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefono.Location = new System.Drawing.Point(18, 201);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(121, 18);
            this.lblNumeroTelefono.TabIndex = 4;
            this.lblNumeroTelefono.Text = "No. Telefonico:";
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbDireccion.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDireccion.Location = new System.Drawing.Point(15, 111);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(165, 18);
            this.txtbDireccion.TabIndex = 3;
            this.txtbDireccion.Text = "DIRRECCION";
            this.txtbDireccion.Enter += new System.EventHandler(this.txtbDireccion_Enter);
            this.txtbDireccion.Leave += new System.EventHandler(this.txtbDireccion_Leave);
            // 
            // lblDireccionRemitente
            // 
            this.lblDireccionRemitente.AutoSize = true;
            this.lblDireccionRemitente.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionRemitente.Location = new System.Drawing.Point(15, 81);
            this.lblDireccionRemitente.Name = "lblDireccionRemitente";
            this.lblDireccionRemitente.Size = new System.Drawing.Size(97, 18);
            this.lblDireccionRemitente.TabIndex = 2;
            this.lblDireccionRemitente.Text = "Dirreccion: ";
            // 
            // txtbDestinatario
            // 
            this.txtbDestinatario.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbDestinatario.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDestinatario.Location = new System.Drawing.Point(15, 51);
            this.txtbDestinatario.Name = "txtbDestinatario";
            this.txtbDestinatario.Size = new System.Drawing.Size(165, 18);
            this.txtbDestinatario.TabIndex = 1;
            this.txtbDestinatario.Text = "DESTINATARIO";
            this.txtbDestinatario.Enter += new System.EventHandler(this.txtbDestinatario_Enter);
            this.txtbDestinatario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbDestinatario_KeyPress);
            this.txtbDestinatario.Leave += new System.EventHandler(this.txtbDestinatario_Leave);
            // 
            // lblRemitente
            // 
            this.lblRemitente.AutoSize = true;
            this.lblRemitente.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemitente.Location = new System.Drawing.Point(15, 21);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(169, 18);
            this.lblRemitente.TabIndex = 0;
            this.lblRemitente.Text = "Destino del Producto:\r\n";
            // 
            // pnlVentanaP2
            // 
            this.pnlVentanaP2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlVentanaP2.Controls.Add(this.chckbxToxico);
            this.pnlVentanaP2.Controls.Add(this.chckbxInflamable);
            this.pnlVentanaP2.Controls.Add(this.lbltipoMaterial);
            this.pnlVentanaP2.Controls.Add(this.lblLibras);
            this.pnlVentanaP2.Controls.Add(this.cmbbMaterialProucto);
            this.pnlVentanaP2.Controls.Add(this.txtbPesomaterial);
            this.pnlVentanaP2.Controls.Add(this.lblPesoProducto);
            this.pnlVentanaP2.Controls.Add(this.lblMaterialProducto);
            this.pnlVentanaP2.Controls.Add(this.txtbNombreProducto);
            this.pnlVentanaP2.Controls.Add(this.lblNombreProducto);
            this.pnlVentanaP2.Location = new System.Drawing.Point(17, 15);
            this.pnlVentanaP2.Name = "pnlVentanaP2";
            this.pnlVentanaP2.Size = new System.Drawing.Size(253, 352);
            this.pnlVentanaP2.TabIndex = 0;
            // 
            // chckbxToxico
            // 
            this.chckbxToxico.AutoSize = true;
            this.chckbxToxico.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbxToxico.Location = new System.Drawing.Point(18, 261);
            this.chckbxToxico.Name = "chckbxToxico";
            this.chckbxToxico.Size = new System.Drawing.Size(70, 22);
            this.chckbxToxico.TabIndex = 12;
            this.chckbxToxico.Text = "Toxico";
            this.chckbxToxico.UseVisualStyleBackColor = true;
            // 
            // chckbxInflamable
            // 
            this.chckbxInflamable.AutoSize = true;
            this.chckbxInflamable.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbxInflamable.Location = new System.Drawing.Point(18, 231);
            this.chckbxInflamable.Name = "chckbxInflamable";
            this.chckbxInflamable.Size = new System.Drawing.Size(99, 22);
            this.chckbxInflamable.TabIndex = 11;
            this.chckbxInflamable.Text = "Inflamable";
            this.chckbxInflamable.UseVisualStyleBackColor = true;
            // 
            // lbltipoMaterial
            // 
            this.lbltipoMaterial.AutoSize = true;
            this.lbltipoMaterial.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoMaterial.Location = new System.Drawing.Point(18, 201);
            this.lbltipoMaterial.Name = "lbltipoMaterial";
            this.lbltipoMaterial.Size = new System.Drawing.Size(194, 18);
            this.lbltipoMaterial.TabIndex = 10;
            this.lbltipoMaterial.Text = "precaucion de materiales:";
            // 
            // lblLibras
            // 
            this.lblLibras.AutoSize = true;
            this.lblLibras.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibras.Location = new System.Drawing.Point(93, 171);
            this.lblLibras.Name = "lblLibras";
            this.lblLibras.Size = new System.Drawing.Size(32, 18);
            this.lblLibras.TabIndex = 9;
            this.lblLibras.Text = "LB";
            // 
            // cmbbMaterialProucto
            // 
            this.cmbbMaterialProucto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbbMaterialProucto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbbMaterialProucto.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbMaterialProucto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbbMaterialProucto.FormattingEnabled = true;
            this.cmbbMaterialProucto.Location = new System.Drawing.Point(15, 111);
            this.cmbbMaterialProucto.Name = "cmbbMaterialProucto";
            this.cmbbMaterialProucto.Size = new System.Drawing.Size(165, 24);
            this.cmbbMaterialProucto.TabIndex = 8;
            this.cmbbMaterialProucto.Text = "None";
            this.cmbbMaterialProucto.Enter += new System.EventHandler(this.cmbbMaterialProucto_Enter);
            this.cmbbMaterialProucto.Leave += new System.EventHandler(this.cmbbMaterialProucto_Leave);
            // 
            // txtbPesomaterial
            // 
            this.txtbPesomaterial.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbPesomaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPesomaterial.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPesomaterial.Location = new System.Drawing.Point(18, 171);
            this.txtbPesomaterial.Name = "txtbPesomaterial";
            this.txtbPesomaterial.Size = new System.Drawing.Size(69, 18);
            this.txtbPesomaterial.TabIndex = 5;
            this.txtbPesomaterial.Text = "PESO";
            this.txtbPesomaterial.Enter += new System.EventHandler(this.txtbPesomaterial_Enter);
            this.txtbPesomaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPesomaterial_KeyPress);
            this.txtbPesomaterial.Leave += new System.EventHandler(this.txtbPesomaterial_Leave);
            // 
            // lblPesoProducto
            // 
            this.lblPesoProducto.AutoSize = true;
            this.lblPesoProducto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoProducto.Location = new System.Drawing.Point(18, 141);
            this.lblPesoProducto.Name = "lblPesoProducto";
            this.lblPesoProducto.Size = new System.Drawing.Size(143, 18);
            this.lblPesoProducto.TabIndex = 4;
            this.lblPesoProducto.Text = "Peso del Material:";
            // 
            // lblMaterialProducto
            // 
            this.lblMaterialProducto.AutoSize = true;
            this.lblMaterialProducto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialProducto.Location = new System.Drawing.Point(15, 81);
            this.lblMaterialProducto.Name = "lblMaterialProducto";
            this.lblMaterialProducto.Size = new System.Drawing.Size(173, 18);
            this.lblMaterialProducto.TabIndex = 2;
            this.lblMaterialProducto.Text = "material del Producto:";
            // 
            // txtbNombreProducto
            // 
            this.txtbNombreProducto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombreProducto.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombreProducto.Location = new System.Drawing.Point(15, 51);
            this.txtbNombreProducto.Name = "txtbNombreProducto";
            this.txtbNombreProducto.Size = new System.Drawing.Size(165, 18);
            this.txtbNombreProducto.TabIndex = 1;
            this.txtbNombreProducto.Text = "NOMBRE";
            this.txtbNombreProducto.Enter += new System.EventHandler(this.txtbNombreProducto_Enter);
            this.txtbNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombreProducto_KeyPress);
            this.txtbNombreProducto.Leave += new System.EventHandler(this.txtbNombreProducto_Leave);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(15, 21);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(168, 18);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre del Producto:";
            // 
            // lblVentanaPTitulo
            // 
            this.lblVentanaPTitulo.AutoSize = true;
            this.lblVentanaPTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentanaPTitulo.Location = new System.Drawing.Point(30, 26);
            this.lblVentanaPTitulo.Name = "lblVentanaPTitulo";
            this.lblVentanaPTitulo.Size = new System.Drawing.Size(377, 29);
            this.lblVentanaPTitulo.TabIndex = 1;
            this.lblVentanaPTitulo.Text = "Solicitud de Envio de Paquete";
            // 
            // ventanaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(659, 507);
            this.Controls.Add(this.lblVentanaPTitulo);
            this.Controls.Add(this.pnlVentanaP1);
            this.Name = "ventanaP";
            this.Text = "Solicitud de envio";
            this.Load += new System.EventHandler(this.ventanaP_Load);
            this.pnlVentanaP1.ResumeLayout(false);
            this.pnlVentanaP3.ResumeLayout(false);
            this.pnlVentanaP3.PerformLayout();
            this.pnlVentanaP2.ResumeLayout(false);
            this.pnlVentanaP2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVentanaP1;
        private System.Windows.Forms.Panel pnlVentanaP2;
        private System.Windows.Forms.Label lblMaterialProducto;
        private System.Windows.Forms.TextBox txtbNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblPesoProducto;
        private System.Windows.Forms.TextBox txtbPesomaterial;
        private System.Windows.Forms.ComboBox cmbbMaterialProucto;
        private System.Windows.Forms.Label lblLibras;
        private System.Windows.Forms.Label lbltipoMaterial;
        private System.Windows.Forms.Panel pnlVentanaP3;
        private System.Windows.Forms.CheckBox chckbxToxico;
        private System.Windows.Forms.CheckBox chckbxInflamable;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.Label lblDireccionRemitente;
        private System.Windows.Forms.TextBox txtbDestinatario;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbCodePostal;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.TextBox txtbNumeroTelefonico;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.Button btnVentanaPAceptar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblVentanaPTitulo;
    }
}