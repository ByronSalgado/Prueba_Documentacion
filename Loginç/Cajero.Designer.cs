namespace Loginç
{
    partial class Cajero
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
            this.dgvDatosClientes = new System.Windows.Forms.DataGridView();
            this.cliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet17 = new Loginç._A_Beltran_CopiadoraDataSet17();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.rdb_Nombre = new System.Windows.Forms.RadioButton();
            this.rdb_ID = new System.Windows.Forms.RadioButton();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet9 = new Loginç._A_Beltran_CopiadoraDataSet9();
            this.cliTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet9TableAdapters.CliTableAdapter();
            this.cliTableAdapter1 = new Loginç._A_Beltran_CopiadoraDataSet17TableAdapters.CliTableAdapter();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet17)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosClientes
            // 
            this.dgvDatosClientes.AllowUserToAddRows = false;
            this.dgvDatosClientes.AllowUserToDeleteRows = false;
            this.dgvDatosClientes.AutoGenerateColumns = false;
            this.dgvDatosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.descripcionEstadoDataGridViewTextBoxColumn,
            this.descripcionIdentificacionDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.telefonoClienteDataGridViewTextBoxColumn,
            this.direccionClienteDataGridViewTextBoxColumn,
            this.correoClienteDataGridViewTextBoxColumn,
            this.identificacionDataGridViewTextBoxColumn});
            this.dgvDatosClientes.DataSource = this.cliBindingSource1;
            this.dgvDatosClientes.EnableHeadersVisualStyles = false;
            this.dgvDatosClientes.Location = new System.Drawing.Point(16, 142);
            this.dgvDatosClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatosClientes.MultiSelect = false;
            this.dgvDatosClientes.Name = "dgvDatosClientes";
            this.dgvDatosClientes.ReadOnly = true;
            this.dgvDatosClientes.Size = new System.Drawing.Size(725, 347);
            this.dgvDatosClientes.TabIndex = 23;
            this.dgvDatosClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvDatosClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cliBindingSource1
            // 
            this.cliBindingSource1.DataMember = "Cli";
            this.cliBindingSource1.DataSource = this._A_Beltran_CopiadoraDataSet17;
            // 
            // _A_Beltran_CopiadoraDataSet17
            // 
            this._A_Beltran_CopiadoraDataSet17.DataSetName = "_A_Beltran_CopiadoraDataSet17";
            this._A_Beltran_CopiadoraDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(155, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 45);
            this.label2.TabIndex = 22;
            this.label2.Text = "A.Beltran.Copiadora S. de R.L.";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Location = new System.Drawing.Point(955, 16);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 44);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::Loginç.Properties.Resources.black_difuminado;
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lblBusqueda);
            this.groupBox1.Controls.Add(this.rdb_Nombre);
            this.groupBox1.Controls.Add(this.rdb_ID);
            this.groupBox1.Controls.Add(this.txtfiltro);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(749, 142);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(325, 347);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Lime;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Location = new System.Drawing.Point(45, 220);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 43);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo Cliente";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(176, 220);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 43);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(41, 126);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(74, 17);
            this.lblBusqueda.TabIndex = 3;
            this.lblBusqueda.Text = "ID Usuario";
            this.lblBusqueda.Visible = false;
            // 
            // rdb_Nombre
            // 
            this.rdb_Nombre.AutoSize = true;
            this.rdb_Nombre.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rdb_Nombre.Location = new System.Drawing.Point(213, 57);
            this.rdb_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_Nombre.Name = "rdb_Nombre";
            this.rdb_Nombre.Size = new System.Drawing.Size(79, 21);
            this.rdb_Nombre.TabIndex = 2;
            this.rdb_Nombre.TabStop = true;
            this.rdb_Nombre.Text = "Nombre";
            this.rdb_Nombre.UseVisualStyleBackColor = true;
            this.rdb_Nombre.CheckedChanged += new System.EventHandler(this.rdb_Nombre_CheckedChanged);
            // 
            // rdb_ID
            // 
            this.rdb_ID.AutoSize = true;
            this.rdb_ID.BackColor = System.Drawing.Color.Transparent;
            this.rdb_ID.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rdb_ID.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_ID.Location = new System.Drawing.Point(45, 57);
            this.rdb_ID.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_ID.Name = "rdb_ID";
            this.rdb_ID.Size = new System.Drawing.Size(42, 21);
            this.rdb_ID.TabIndex = 1;
            this.rdb_ID.TabStop = true;
            this.rdb_ID.Text = "ID";
            this.rdb_ID.UseVisualStyleBackColor = false;
            this.rdb_ID.CheckedChanged += new System.EventHandler(this.rdb_ID_CheckedChanged);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(45, 158);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(249, 22);
            this.txtfiltro.TabIndex = 0;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            this.txtfiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfiltro_KeyDown);
            this.txtfiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiltro_KeyPress_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Loginç.Properties.Resources.icon_account2;
            this.pictureBox2.Location = new System.Drawing.Point(16, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // cliBindingSource
            // 
            this.cliBindingSource.DataMember = "Cli";
            this.cliBindingSource.DataSource = this._A_Beltran_CopiadoraDataSet9;
            // 
            // _A_Beltran_CopiadoraDataSet9
            // 
            this._A_Beltran_CopiadoraDataSet9.DataSetName = "_A_Beltran_CopiadoraDataSet9";
            this._A_Beltran_CopiadoraDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cliTableAdapter
            // 
            this.cliTableAdapter.ClearBeforeFill = true;
            // 
            // cliTableAdapter1
            // 
            this.cliTableAdapter1.ClearBeforeFill = true;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionEstadoDataGridViewTextBoxColumn
            // 
            this.descripcionEstadoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Estado";
            this.descripcionEstadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.descripcionEstadoDataGridViewTextBoxColumn.Name = "descripcionEstadoDataGridViewTextBoxColumn";
            this.descripcionEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionIdentificacionDataGridViewTextBoxColumn
            // 
            this.descripcionIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Identificacion";
            this.descripcionIdentificacionDataGridViewTextBoxColumn.HeaderText = "Tipo de Identificacion";
            this.descripcionIdentificacionDataGridViewTextBoxColumn.Name = "descripcionIdentificacionDataGridViewTextBoxColumn";
            this.descripcionIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoClienteDataGridViewTextBoxColumn
            // 
            this.telefonoClienteDataGridViewTextBoxColumn.DataPropertyName = "Telefono_Cliente";
            this.telefonoClienteDataGridViewTextBoxColumn.HeaderText = "Telefono Cliente";
            this.telefonoClienteDataGridViewTextBoxColumn.Name = "telefonoClienteDataGridViewTextBoxColumn";
            this.telefonoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionClienteDataGridViewTextBoxColumn
            // 
            this.direccionClienteDataGridViewTextBoxColumn.DataPropertyName = "Direccion_Cliente";
            this.direccionClienteDataGridViewTextBoxColumn.HeaderText = "Direccion Cliente";
            this.direccionClienteDataGridViewTextBoxColumn.Name = "direccionClienteDataGridViewTextBoxColumn";
            this.direccionClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoClienteDataGridViewTextBoxColumn
            // 
            this.correoClienteDataGridViewTextBoxColumn.DataPropertyName = "Correo_Cliente";
            this.correoClienteDataGridViewTextBoxColumn.HeaderText = "Correo Cliente";
            this.correoClienteDataGridViewTextBoxColumn.Name = "correoClienteDataGridViewTextBoxColumn";
            this.correoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            this.identificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Loginç.Properties.Resources.black_difuminado;
            this.ClientSize = new System.Drawing.Size(1105, 503);
            this.Controls.Add(this.dgvDatosClientes);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Cajero";
            this.Text = "Cajero";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cajero_FormClosed);
            this.Load += new System.EventHandler(this.Cajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet17)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.RadioButton rdb_Nombre;
        private System.Windows.Forms.RadioButton rdb_ID;
        private System.Windows.Forms.TextBox txtfiltro;
        private _A_Beltran_CopiadoraDataSet9 _A_Beltran_CopiadoraDataSet9;
        private System.Windows.Forms.BindingSource cliBindingSource;
        private _A_Beltran_CopiadoraDataSet9TableAdapters.CliTableAdapter cliTableAdapter;
        private _A_Beltran_CopiadoraDataSet17 _A_Beltran_CopiadoraDataSet17;
        private System.Windows.Forms.BindingSource cliBindingSource1;
        private _A_Beltran_CopiadoraDataSet17TableAdapters.CliTableAdapter cliTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
    }
}