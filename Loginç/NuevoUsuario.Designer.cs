namespace Loginç
{
    partial class NuevoUsuario
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
            this.components = new System.ComponentModel.Container();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbRol = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtVerificar = new System.Windows.Forms.TextBox();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.lbVerificar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbIdentidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnModificar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Red;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.Location = new System.Drawing.Point(487, 491);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 30);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbUsuario);
            this.groupBox2.Controls.Add(this.lbRol);
            this.groupBox2.Controls.Add(this.cbRol);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.txtContraseña);
            this.groupBox2.Controls.Add(this.txtVerificar);
            this.groupBox2.Controls.Add(this.lbContraseña);
            this.groupBox2.Controls.Add(this.lbVerificar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(16, 322);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(571, 161);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(21, 26);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(57, 17);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Location = new System.Drawing.Point(22, 79);
            this.lbRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(29, 17);
            this.lbRol.TabIndex = 20;
            this.lbRol.Text = "Rol";
            // 
            // cbRol
            // 
            this.cbRol.DisplayMember = "Descripcion_Rol";
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(25, 100);
            this.cbRol.Margin = new System.Windows.Forms.Padding(4);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(233, 24);
            this.cbRol.TabIndex = 19;
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.cbRol_SelectedIndexChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(25, 46);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(233, 22);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged_1);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtUsuario_MouseDown);
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(303, 46);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(233, 22);
            this.txtContraseña.TabIndex = 9;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged_1);
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            this.txtContraseña.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtContraseña_MouseDown);
            this.txtContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraseña_Validating);
            // 
            // txtVerificar
            // 
            this.txtVerificar.Location = new System.Drawing.Point(303, 101);
            this.txtVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerificar.Name = "txtVerificar";
            this.txtVerificar.PasswordChar = '*';
            this.txtVerificar.Size = new System.Drawing.Size(233, 22);
            this.txtVerificar.TabIndex = 10;
            this.txtVerificar.TextChanged += new System.EventHandler(this.txtVerificar_TextChanged_1);
            this.txtVerificar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerificar_KeyDown);
            this.txtVerificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVerificar_KeyPress);
            this.txtVerificar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtVerificar_MouseDown);
            this.txtVerificar.Validating += new System.ComponentModel.CancelEventHandler(this.txtVerificar_Validating);
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Location = new System.Drawing.Point(299, 26);
            this.lbContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(81, 17);
            this.lbContraseña.TabIndex = 13;
            this.lbContraseña.Text = "Contraseña";
            // 
            // lbVerificar
            // 
            this.lbVerificar.AutoSize = true;
            this.lbVerificar.Location = new System.Drawing.Point(299, 80);
            this.lbVerificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVerificar.Name = "lbVerificar";
            this.lbVerificar.Size = new System.Drawing.Size(137, 17);
            this.lbVerificar.TabIndex = 11;
            this.lbVerificar.Text = "Verificar Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 47);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged_1);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNombre_MouseDown);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(21, 27);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(121, 17);
            this.lbNombre.TabIndex = 7;
            this.lbNombre.Text = "Nombre Completo";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.rbF);
            this.groupBox3.Controls.Add(this.rbM);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbNombre);
            this.groupBox3.Controls.Add(this.txtCorreo);
            this.groupBox3.Controls.Add(this.lbCorreo);
            this.groupBox3.Controls.Add(this.txtDireccion);
            this.groupBox3.Controls.Add(this.lbDireccion);
            this.groupBox3.Controls.Add(this.txtIdentidad);
            this.groupBox3.Controls.Add(this.txtTelefono);
            this.groupBox3.Controls.Add(this.lbTelefono);
            this.groupBox3.Controls.Add(this.lbIdentidad);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(16, 95);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(571, 204);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Generales";
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(432, 146);
            this.rbF.Margin = new System.Windows.Forms.Padding(4);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(37, 21);
            this.rbF.TabIndex = 37;
            this.rbF.TabStop = true;
            this.rbF.Text = "F";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(379, 146);
            this.rbM.Margin = new System.Windows.Forms.Padding(4);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(40, 21);
            this.rbM.TabIndex = 36;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Genero";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(303, 98);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(233, 22);
            this.txtCorreo.TabIndex = 34;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged_1);
            this.txtCorreo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            this.txtCorreo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCorreo_MouseDown);
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Location = new System.Drawing.Point(299, 79);
            this.lbCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(51, 17);
            this.lbCorreo.TabIndex = 33;
            this.lbCorreo.Text = "Correo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(25, 143);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(233, 22);
            this.txtDireccion.TabIndex = 32;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDireccion_KeyDown);
            this.txtDireccion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtDireccion_MouseDown);
            this.txtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDireccion_Validating);
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(21, 123);
            this.lbDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(67, 17);
            this.lbDireccion.TabIndex = 31;
            this.lbDireccion.Text = "Direccion";
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Location = new System.Drawing.Point(25, 95);
            this.txtIdentidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(233, 22);
            this.txtIdentidad.TabIndex = 28;
            this.txtIdentidad.TextChanged += new System.EventHandler(this.txtIdentidad_TextChanged_1);
            this.txtIdentidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentidad_KeyDown);
            this.txtIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentidad_KeyPress_1);
            this.txtIdentidad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtIdentidad_MouseDown);
            this.txtIdentidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdentidad_Validating_1);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(303, 50);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(233, 22);
            this.txtTelefono.TabIndex = 30;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged_1);
            this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyDown);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTelefono_MouseDown);
            this.txtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefono_Validating);
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(299, 27);
            this.lbTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(64, 17);
            this.lbTelefono.TabIndex = 29;
            this.lbTelefono.Text = "Telefono";
            // 
            // lbIdentidad
            // 
            this.lbIdentidad.AutoSize = true;
            this.lbIdentidad.Location = new System.Drawing.Point(21, 75);
            this.lbIdentidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdentidad.Name = "lbIdentidad";
            this.lbIdentidad.Size = new System.Drawing.Size(70, 17);
            this.lbIdentidad.TabIndex = 27;
            this.lbIdentidad.Text = "Identidad ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(379, 491);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Lime;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(379, 492);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 30);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 496);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(27, 22);
            this.textBox1.TabIndex = 38;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(116, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 35);
            this.label1.TabIndex = 47;
            this.label1.Text = "A.Beltran.Copiadora S. de R.L.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Loginç.Properties.Resources.icon_account2;
            this.pictureBox2.Location = new System.Drawing.Point(20, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Loginç.Properties.Resources.black_difuminado;
            this.ClientSize = new System.Drawing.Size(604, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnRegresar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbIdentidad;
        private System.Windows.Forms.ErrorProvider epError;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtIdentidad;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.ComboBox cbRol;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.TextBox txtVerificar;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Label lbUsuario;
        public System.Windows.Forms.Label lbRol;
        public System.Windows.Forms.Label lbContraseña;
        public System.Windows.Forms.Label lbVerificar;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}