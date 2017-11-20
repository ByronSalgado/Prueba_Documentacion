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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet9 = new Loginç._A_Beltran_CopiadoraDataSet9();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rdb_Nombre = new System.Windows.Forms.RadioButton();
            this.rdb_ID = new System.Windows.Forms.RadioButton();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.cliTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet9TableAdapters.CliTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet9)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.identificacionDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.telefonoClienteDataGridViewTextBoxColumn,
            this.direccionClienteDataGridViewTextBoxColumn,
            this.correoClienteDataGridViewTextBoxColumn,
            this.rTNDataGridViewTextBoxColumn,
            this.descripcionEstadoDataGridViewTextBoxColumn,
            this.descripcionIdentificacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cliBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 235);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            this.identificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre_Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoClienteDataGridViewTextBoxColumn
            // 
            this.telefonoClienteDataGridViewTextBoxColumn.DataPropertyName = "Telefono_Cliente";
            this.telefonoClienteDataGridViewTextBoxColumn.HeaderText = "Telefono_Cliente";
            this.telefonoClienteDataGridViewTextBoxColumn.Name = "telefonoClienteDataGridViewTextBoxColumn";
            this.telefonoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionClienteDataGridViewTextBoxColumn
            // 
            this.direccionClienteDataGridViewTextBoxColumn.DataPropertyName = "Direccion_Cliente";
            this.direccionClienteDataGridViewTextBoxColumn.HeaderText = "Direccion_Cliente";
            this.direccionClienteDataGridViewTextBoxColumn.Name = "direccionClienteDataGridViewTextBoxColumn";
            this.direccionClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoClienteDataGridViewTextBoxColumn
            // 
            this.correoClienteDataGridViewTextBoxColumn.DataPropertyName = "Correo_Cliente";
            this.correoClienteDataGridViewTextBoxColumn.HeaderText = "Correo_Cliente";
            this.correoClienteDataGridViewTextBoxColumn.Name = "correoClienteDataGridViewTextBoxColumn";
            this.correoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rTNDataGridViewTextBoxColumn
            // 
            this.rTNDataGridViewTextBoxColumn.DataPropertyName = "RTN";
            this.rTNDataGridViewTextBoxColumn.HeaderText = "RTN";
            this.rTNDataGridViewTextBoxColumn.Name = "rTNDataGridViewTextBoxColumn";
            this.rTNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionEstadoDataGridViewTextBoxColumn
            // 
            this.descripcionEstadoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Estado";
            this.descripcionEstadoDataGridViewTextBoxColumn.HeaderText = "Descripcion_Estado";
            this.descripcionEstadoDataGridViewTextBoxColumn.Name = "descripcionEstadoDataGridViewTextBoxColumn";
            this.descripcionEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionIdentificacionDataGridViewTextBoxColumn
            // 
            this.descripcionIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Identificacion";
            this.descripcionIdentificacionDataGridViewTextBoxColumn.HeaderText = "Descripcion_Identificacion";
            this.descripcionIdentificacionDataGridViewTextBoxColumn.Name = "descripcionIdentificacionDataGridViewTextBoxColumn";
            this.descripcionIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(104, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 36);
            this.label2.TabIndex = 22;
            this.label2.Text = "A.Beltran.Copiadora S. de R.L";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(710, 314);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 35);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.rdb_Nombre);
            this.groupBox1.Controls.Add(this.rdb_ID);
            this.groupBox1.Controls.Add(this.txtfiltro);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(562, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 165);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.Location = new System.Drawing.Point(132, 91);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 35);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo Cliente";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(20, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rdb_Nombre
            // 
            this.rdb_Nombre.AutoSize = true;
            this.rdb_Nombre.Location = new System.Drawing.Point(71, 19);
            this.rdb_Nombre.Name = "rdb_Nombre";
            this.rdb_Nombre.Size = new System.Drawing.Size(62, 17);
            this.rdb_Nombre.TabIndex = 2;
            this.rdb_Nombre.TabStop = true;
            this.rdb_Nombre.Text = "Nombre";
            this.rdb_Nombre.UseVisualStyleBackColor = true;
            this.rdb_Nombre.CheckedChanged += new System.EventHandler(this.rdb_Nombre_CheckedChanged);
            // 
            // rdb_ID
            // 
            this.rdb_ID.AutoSize = true;
            this.rdb_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdb_ID.Location = new System.Drawing.Point(16, 19);
            this.rdb_ID.Name = "rdb_ID";
            this.rdb_ID.Size = new System.Drawing.Size(36, 17);
            this.rdb_ID.TabIndex = 1;
            this.rdb_ID.TabStop = true;
            this.rdb_ID.Text = "ID";
            this.rdb_ID.UseVisualStyleBackColor = true;
            this.rdb_ID.CheckedChanged += new System.EventHandler(this.rdb_ID_CheckedChanged);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(20, 42);
            this.txtfiltro.Multiline = true;
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(195, 24);
            this.txtfiltro.TabIndex = 0;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            this.txtfiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfiltro_KeyDown);
            this.txtfiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiltro_KeyPress_1);
            // 
            // cliTableAdapter
            // 
            this.cliTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = global::Loginç.Properties.Resources.icon_account2;
            this.pictureBox2.Location = new System.Drawing.Point(11, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loginç.Properties.Resources.black_difuminado;
            this.ClientSize = new System.Drawing.Size(829, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cajero";
            this.Text = "Cajero";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cajero_FormClosed);
            this.Load += new System.EventHandler(this.Cajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rdb_Nombre;
        private System.Windows.Forms.RadioButton rdb_ID;
        private System.Windows.Forms.TextBox txtfiltro;
        private _A_Beltran_CopiadoraDataSet9 _A_Beltran_CopiadoraDataSet9;
        private System.Windows.Forms.BindingSource cliBindingSource;
        private _A_Beltran_CopiadoraDataSet9TableAdapters.CliTableAdapter cliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionIdentificacionDataGridViewTextBoxColumn;
    }
}