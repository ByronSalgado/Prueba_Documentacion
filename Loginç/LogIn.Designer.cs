namespace Loginç
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.TxtIdRol = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(202, 154);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
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
            this.TxtContraseña.Location = new System.Drawing.Point(202, 182);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(100, 20);
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
            this.btnIngresar.BackColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(167, 276);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_MouseLeave);
            this.btnIngresar.MouseHover += new System.EventHandler(this.btnIngresar_MouseHover);
            // 
            // TxtIdRol
            // 
            this.TxtIdRol.Location = new System.Drawing.Point(6, 307);
            this.TxtIdRol.Name = "TxtIdRol";
            this.TxtIdRol.Size = new System.Drawing.Size(17, 20);
            this.TxtIdRol.TabIndex = 5;
            this.TxtIdRol.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(148, 238);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvido su Contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtIdEstado
            // 
            this.txtIdEstado.Location = new System.Drawing.Point(27, 307);
            this.txtIdEstado.Name = "txtIdEstado";
            this.txtIdEstado.Size = new System.Drawing.Size(17, 20);
            this.txtIdEstado.TabIndex = 7;
            this.txtIdEstado.Visible = false;
            // 
            // txtIntentosErrores
            // 
            this.txtIntentosErrores.Location = new System.Drawing.Point(50, 307);
            this.txtIntentosErrores.Name = "txtIntentosErrores";
            this.txtIntentosErrores.Size = new System.Drawing.Size(17, 20);
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
            this.label3.Location = new System.Drawing.Point(103, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "A.Beltran Copiadora S. de R.L";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Loginç.Properties.Resources.icon_account2;
            this.pictureBox2.Location = new System.Drawing.Point(167, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Loginç.Properties.Resources.candado;
            this.pictureBox3.Location = new System.Drawing.Point(180, 154);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Loginç.Properties.Resources.Contraseña;
            this.pictureBox1.Location = new System.Drawing.Point(180, 182);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Loginç.Properties.Resources.black_difuminado;
            this.ClientSize = new System.Drawing.Size(414, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIntentosErrores);
            this.Controls.Add(this.txtIdEstado);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TxtIdRol);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "link";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.link_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtIdRol;
        private System.Windows.Forms.LinkLabel linkLabel1;
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

