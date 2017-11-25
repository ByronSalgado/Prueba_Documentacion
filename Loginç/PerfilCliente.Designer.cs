namespace Loginç
{
    partial class PerfilCliente
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
            this.txtEstadoArqueo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Identificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID_CLIENTE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._A_Beltran_CopiadoraDataSet10 = new Loginç._A_Beltran_CopiadoraDataSet10();
            this.facBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet10TableAdapters.facTableAdapter();
            this._A_Beltran_CopiadoraDataSet11 = new Loginç._A_Beltran_CopiadoraDataSet11();
            this.facBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facTableAdapter1 = new Loginç._A_Beltran_CopiadoraDataSet11TableAdapters.facTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.factBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet12 = new Loginç._A_Beltran_CopiadoraDataSet12();
            this.factTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet12TableAdapters.factTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iDArqueoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTipoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstadoArqueo
            // 
            this.txtEstadoArqueo.Location = new System.Drawing.Point(16, 480);
            this.txtEstadoArqueo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstadoArqueo.Name = "txtEstadoArqueo";
            this.txtEstadoArqueo.Size = new System.Drawing.Size(24, 22);
            this.txtEstadoArqueo.TabIndex = 38;
            this.txtEstadoArqueo.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(484, 480);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 37;
            this.button1.Text = "Facturar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(416, 162);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(167, 22);
            this.txtID.TabIndex = 36;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(412, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "ID";
            // 
            // txtRTN
            // 
            this.txtRTN.Enabled = false;
            this.txtRTN.Location = new System.Drawing.Point(416, 118);
            this.txtRTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.ReadOnly = true;
            this.txtRTN.Size = new System.Drawing.Size(167, 22);
            this.txtRTN.TabIndex = 34;
            this.txtRTN.TextChanged += new System.EventHandler(this.txtRTN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(412, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "RTN";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(215, 208);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(163, 22);
            this.txtCorreo.TabIndex = 32;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(211, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Correo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(215, 162);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(163, 22);
            this.txtDireccion.TabIndex = 30;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(211, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Direccion";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(215, 118);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(163, 22);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(211, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Telefono";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(16, 208);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(167, 22);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nombre";
            // 
            // txt_Identificacion
            // 
            this.txt_Identificacion.Enabled = false;
            this.txt_Identificacion.Location = new System.Drawing.Point(16, 162);
            this.txt_Identificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Identificacion.Name = "txt_Identificacion";
            this.txt_Identificacion.ReadOnly = true;
            this.txt_Identificacion.Size = new System.Drawing.Size(167, 22);
            this.txt_Identificacion.TabIndex = 24;
            this.txt_Identificacion.TextChanged += new System.EventHandler(this.txt_Identificacion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Identificacion";
            // 
            // txtID_CLIENTE
            // 
            this.txtID_CLIENTE.Location = new System.Drawing.Point(16, 118);
            this.txtID_CLIENTE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID_CLIENTE.Name = "txtID_CLIENTE";
            this.txtID_CLIENTE.ReadOnly = true;
            this.txtID_CLIENTE.Size = new System.Drawing.Size(167, 22);
            this.txtID_CLIENTE.TabIndex = 22;
            this.txtID_CLIENTE.TextChanged += new System.EventHandler(this.txtID_CLIENTE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID Cliente";
            // 
            // _A_Beltran_CopiadoraDataSet10
            // 
            this._A_Beltran_CopiadoraDataSet10.DataSetName = "_A_Beltran_CopiadoraDataSet10";
            this._A_Beltran_CopiadoraDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facBindingSource
            // 
            this.facBindingSource.DataMember = "fac";
            this.facBindingSource.DataSource = this._A_Beltran_CopiadoraDataSet10;
            // 
            // facTableAdapter
            // 
            this.facTableAdapter.ClearBeforeFill = true;
            // 
            // _A_Beltran_CopiadoraDataSet11
            // 
            this._A_Beltran_CopiadoraDataSet11.DataSetName = "_A_Beltran_CopiadoraDataSet11";
            this._A_Beltran_CopiadoraDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facBindingSource1
            // 
            this.facBindingSource1.DataMember = "fac";
            this.facBindingSource1.DataSource = this._A_Beltran_CopiadoraDataSet11;
            // 
            // facTableAdapter1
            // 
            this.facTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDArqueoDataGridViewTextBoxColumn,
            this.descripcionTipoPagoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.iDCAIDataGridViewTextBoxColumn,
            this.impuestoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.factBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 238);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(568, 223);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.Validating += new System.ComponentModel.CancelEventHandler(this.dataGridView1_Validating);
            // 
            // factBindingSource
            // 
            this.factBindingSource.DataMember = "fact";
            this.factBindingSource.DataSource = this._A_Beltran_CopiadoraDataSet12;
            // 
            // _A_Beltran_CopiadoraDataSet12
            // 
            this._A_Beltran_CopiadoraDataSet12.DataSetName = "_A_Beltran_CopiadoraDataSet12";
            this._A_Beltran_CopiadoraDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factTableAdapter
            // 
            this.factTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(484, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 40;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(376, 480);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 41;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(112, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(336, 27);
            this.label9.TabIndex = 43;
            this.label9.Text = "A.Beltran.Copiadora S. de R.L";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Loginç.Properties.Resources.icon_account2;
            this.pictureBox2.Location = new System.Drawing.Point(16, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // iDArqueoDataGridViewTextBoxColumn
            // 
            this.iDArqueoDataGridViewTextBoxColumn.DataPropertyName = "ID_Arqueo";
            this.iDArqueoDataGridViewTextBoxColumn.HeaderText = "ID Arqueo";
            this.iDArqueoDataGridViewTextBoxColumn.Name = "iDArqueoDataGridViewTextBoxColumn";
            this.iDArqueoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionTipoPagoDataGridViewTextBoxColumn
            // 
            this.descripcionTipoPagoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Tipo_Pago";
            this.descripcionTipoPagoDataGridViewTextBoxColumn.HeaderText = "Descripcion_Tipo_Pago";
            this.descripcionTipoPagoDataGridViewTextBoxColumn.Name = "descripcionTipoPagoDataGridViewTextBoxColumn";
            this.descripcionTipoPagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCAIDataGridViewTextBoxColumn
            // 
            this.iDCAIDataGridViewTextBoxColumn.DataPropertyName = "ID_CAI";
            this.iDCAIDataGridViewTextBoxColumn.HeaderText = "ID_CAI";
            this.iDCAIDataGridViewTextBoxColumn.Name = "iDCAIDataGridViewTextBoxColumn";
            this.iDCAIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // impuestoDataGridViewTextBoxColumn
            // 
            this.impuestoDataGridViewTextBoxColumn.DataPropertyName = "Impuesto";
            this.impuestoDataGridViewTextBoxColumn.HeaderText = "Impuesto";
            this.impuestoDataGridViewTextBoxColumn.Name = "impuestoDataGridViewTextBoxColumn";
            this.impuestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PerfilCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loginç.Properties.Resources.black_difuminado;
            this.ClientSize = new System.Drawing.Size(603, 521);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEstadoArqueo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Identificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID_CLIENTE);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PerfilCliente";
            this.Text = "PerfilCliente";
            this.Load += new System.EventHandler(this.PerfilCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtRTN;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Identificacion;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtID_CLIENTE;
        private System.Windows.Forms.Label label1;
        private _A_Beltran_CopiadoraDataSet10 _A_Beltran_CopiadoraDataSet10;
        private System.Windows.Forms.BindingSource facBindingSource;
        private _A_Beltran_CopiadoraDataSet10TableAdapters.facTableAdapter facTableAdapter;
        private _A_Beltran_CopiadoraDataSet11 _A_Beltran_CopiadoraDataSet11;
        private System.Windows.Forms.BindingSource facBindingSource1;
        private _A_Beltran_CopiadoraDataSet11TableAdapters.facTableAdapter facTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _A_Beltran_CopiadoraDataSet12 _A_Beltran_CopiadoraDataSet12;
        private System.Windows.Forms.BindingSource factBindingSource;
        private _A_Beltran_CopiadoraDataSet12TableAdapters.factTableAdapter factTableAdapter;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtEstadoArqueo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDArqueoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionTipoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuestoDataGridViewTextBoxColumn;
    }
}