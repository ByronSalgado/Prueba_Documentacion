﻿namespace Loginç
{
    partial class link
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.TxtIdRol = new System.Windows.Forms.TextBox();
            this.llbVinculo = new System.Windows.Forms.LinkLabel();
            this.txtIdEstado = new System.Windows.Forms.TextBox();
            this.txtIntentosErrores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(109, 192);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 24);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.Transparent;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblContra.ForeColor = System.Drawing.Color.White;
            this.lblContra.Location = new System.Drawing.Point(109, 224);
            this.lblContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(111, 24);
            this.lblContra.TabIndex = 1;
            this.lblContra.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(269, 190);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(132, 22);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            this.TxtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsuario_KeyDown);
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            this.TxtUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtUsuario_MouseDown);
            this.TxtUsuario.MouseLeave += new System.EventHandler(this.TxtUsuario_MouseLeave);
            this.TxtUsuario.MouseHover += new System.EventHandler(this.TxtUsuario_MouseHover);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(269, 224);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(132, 22);
            this.TxtContraseña.TabIndex = 3;
            this.TxtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtContraseña_KeyDown);
            this.TxtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContraseña_KeyPress);
            this.TxtContraseña.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtContraseña_MouseDown);
            this.TxtContraseña.MouseLeave += new System.EventHandler(this.TxtContraseña_MouseLeave);
            this.TxtContraseña.MouseHover += new System.EventHandler(this.TxtContraseña_MouseHover);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Lime;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.Location = new System.Drawing.Point(223, 340);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 28);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_MouseLeave);
            this.btnIngresar.MouseHover += new System.EventHandler(this.btnIngresar_MouseHover);
            // 
            // TxtIdRol
            // 
            this.TxtIdRol.Location = new System.Drawing.Point(8, 378);
            this.TxtIdRol.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdRol.Name = "TxtIdRol";
            this.TxtIdRol.Size = new System.Drawing.Size(21, 22);
            this.TxtIdRol.TabIndex = 5;
            this.TxtIdRol.Visible = false;
            // 
            // llbVinculo
            // 
            this.llbVinculo.AutoSize = true;
            this.llbVinculo.BackColor = System.Drawing.Color.Transparent;
            this.llbVinculo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.llbVinculo.Location = new System.Drawing.Point(197, 293);
            this.llbVinculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbVinculo.Name = "llbVinculo";
            this.llbVinculo.Size = new System.Drawing.Size(160, 17);
            this.llbVinculo.TabIndex = 6;
            this.llbVinculo.TabStop = true;
            this.llbVinculo.Text = "¿Olvido su Contraseña?";
            this.llbVinculo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtIdEstado
            // 
            this.txtIdEstado.Location = new System.Drawing.Point(36, 378);
            this.txtIdEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEstado.Name = "txtIdEstado";
            this.txtIdEstado.Size = new System.Drawing.Size(21, 22);
            this.txtIdEstado.TabIndex = 7;
            this.txtIdEstado.Visible = false;
            // 
            // txtIntentosErrores
            // 
            this.txtIntentosErrores.Location = new System.Drawing.Point(67, 378);
            this.txtIntentosErrores.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntentosErrores.Name = "txtIntentosErrores";
            this.txtIntentosErrores.Size = new System.Drawing.Size(21, 22);
            this.txtIntentosErrores.TabIndex = 8;
            this.txtIntentosErrores.Visible = false;
            this.txtIntentosErrores.TextChanged += new System.EventHandler(this.txtIntentosErrores_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.15F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(137, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "A.Beltran Copiadora S. de R.L.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Loginç.Properties.Resources.icon_account2;
            this.pictureBox2.Location = new System.Drawing.Point(223, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Loginç.Properties.Resources.candado;
            this.pictureBox3.Location = new System.Drawing.Point(240, 190);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Loginç.Properties.Resources.Contraseña;
            this.pictureBox1.Location = new System.Drawing.Point(240, 224);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Loginç.Properties.Resources.black_difuminado;
            this.ClientSize = new System.Drawing.Size(552, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIntentosErrores);
            this.Controls.Add(this.txtIdEstado);
            this.Controls.Add(this.llbVinculo);
            this.Controls.Add(this.TxtIdRol);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "link";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.link_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtIdRol;
        private System.Windows.Forms.LinkLabel llbVinculo;
        private System.Windows.Forms.TextBox txtIdEstado;
        private System.Windows.Forms.TextBox txtIntentosErrores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnIngresar;
        public System.Windows.Forms.TextBox TxtUsuario;
    }
}

