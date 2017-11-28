namespace Loginç
{
    partial class Facturar
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
            this.txtId_Cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArqueo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidFactura = new System.Windows.Forms.TextBox();
            this.txtprecioUni = new System.Windows.Forms.TextBox();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtInventrioSerie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtCAI = new System.Windows.Forms.TextBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet15 = new Loginç._A_Beltran_CopiadoraDataSet15();
            this.proBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet13 = new Loginç._A_Beltran_CopiadoraDataSet13();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.proTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet13TableAdapters.ProTableAdapter();
            this._A_Beltran_CopiadoraDataSet14 = new Loginç._A_Beltran_CopiadoraDataSet14();
            this.detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet14TableAdapters.detalleTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.txtSubT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.proTableAdapter1 = new Loginç._A_Beltran_CopiadoraDataSet15TableAdapters.ProTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet13)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId_Cliente
            // 
            this.txtId_Cliente.Enabled = false;
            this.txtId_Cliente.Location = new System.Drawing.Point(109, 23);
            this.txtId_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtId_Cliente.Name = "txtId_Cliente";
            this.txtId_Cliente.ReadOnly = true;
            this.txtId_Cliente.Size = new System.Drawing.Size(173, 22);
            this.txtId_Cliente.TabIndex = 24;
            this.txtId_Cliente.Text = "0";
            this.txtId_Cliente.TextChanged += new System.EventHandler(this.txtID_CLIENTE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID Cliente";
            // 
            // txtArqueo
            // 
            this.txtArqueo.Enabled = false;
            this.txtArqueo.Location = new System.Drawing.Point(573, 55);
            this.txtArqueo.Margin = new System.Windows.Forms.Padding(4);
            this.txtArqueo.Name = "txtArqueo";
            this.txtArqueo.ReadOnly = true;
            this.txtArqueo.Size = new System.Drawing.Size(152, 22);
            this.txtArqueo.TabIndex = 28;
            this.txtArqueo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "ID Arqueo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "ID CAI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtidFactura);
            this.groupBox1.Controls.Add(this.txtprecioUni);
            this.groupBox1.Controls.Add(this.txtidProducto);
            this.groupBox1.Controls.Add(this.btnRegresar);
            this.groupBox1.Controls.Add(this.txtInventrioSerie);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtCAI);
            this.groupBox1.Controls.Add(this.txtId_Cliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtArqueo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(911, 100);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Factura";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtidFactura
            // 
            this.txtidFactura.Location = new System.Drawing.Point(395, 55);
            this.txtidFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtidFactura.Name = "txtidFactura";
            this.txtidFactura.Size = new System.Drawing.Size(75, 22);
            this.txtidFactura.TabIndex = 36;
            this.txtidFactura.Visible = false;
            // 
            // txtprecioUni
            // 
            this.txtprecioUni.Location = new System.Drawing.Point(395, 23);
            this.txtprecioUni.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecioUni.Name = "txtprecioUni";
            this.txtprecioUni.Size = new System.Drawing.Size(75, 22);
            this.txtprecioUni.TabIndex = 35;
            this.txtprecioUni.Visible = false;
            // 
            // txtidProducto
            // 
            this.txtidProducto.Location = new System.Drawing.Point(292, 55);
            this.txtidProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.Size = new System.Drawing.Size(83, 22);
            this.txtidProducto.TabIndex = 34;
            this.txtidProducto.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Red;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Location = new System.Drawing.Point(788, 14);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 42);
            this.btnRegresar.TabIndex = 51;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtInventrioSerie
            // 
            this.txtInventrioSerie.Location = new System.Drawing.Point(292, 23);
            this.txtInventrioSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtInventrioSerie.Name = "txtInventrioSerie";
            this.txtInventrioSerie.Size = new System.Drawing.Size(83, 22);
            this.txtInventrioSerie.TabIndex = 33;
            this.txtInventrioSerie.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "ID Usuario";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(109, 55);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(173, 22);
            this.txtUser.TabIndex = 31;
            this.txtUser.Text = "0";
            // 
            // txtCAI
            // 
            this.txtCAI.Enabled = false;
            this.txtCAI.Location = new System.Drawing.Point(572, 23);
            this.txtCAI.Margin = new System.Windows.Forms.Padding(4);
            this.txtCAI.Name = "txtCAI";
            this.txtCAI.ReadOnly = true;
            this.txtCAI.Size = new System.Drawing.Size(152, 22);
            this.txtCAI.TabIndex = 30;
            this.txtCAI.Text = "0";
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AutoGenerateColumns = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descripcionEstadoDataGridViewTextBoxColumn});
            this.dgvInventario.DataSource = this.proBindingSource1;
            this.dgvInventario.Location = new System.Drawing.Point(23, 23);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.Size = new System.Drawing.Size(448, 245);
            this.dgvInventario.TabIndex = 33;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvInventario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dgvInventario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Producto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Nombre_Producto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionEstadoDataGridViewTextBoxColumn
            // 
            this.descripcionEstadoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Estado";
            this.descripcionEstadoDataGridViewTextBoxColumn.HeaderText = "Descripcion_Estado";
            this.descripcionEstadoDataGridViewTextBoxColumn.Name = "descripcionEstadoDataGridViewTextBoxColumn";
            this.descripcionEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proBindingSource1
            // 
            this.proBindingSource1.DataMember = "Pro";
            this.proBindingSource1.DataSource = this._A_Beltran_CopiadoraDataSet15;
            // 
            // _A_Beltran_CopiadoraDataSet15
            // 
            this._A_Beltran_CopiadoraDataSet15.DataSetName = "_A_Beltran_CopiadoraDataSet15";
            this._A_Beltran_CopiadoraDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proBindingSource
            // 
            this.proBindingSource.DataMember = "Pro";
            this.proBindingSource.DataSource = this._A_Beltran_CopiadoraDataSet13;
            // 
            // _A_Beltran_CopiadoraDataSet13
            // 
            this._A_Beltran_CopiadoraDataSet13.DataSetName = "_A_Beltran_CopiadoraDataSet13";
            this._A_Beltran_CopiadoraDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::Loginç.Properties.Resources.black_difuminado;
            this.groupBox2.Controls.Add(this.txtn3);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.txtn2);
            this.groupBox2.Controls.Add(this.txtn1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNomP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.dgvInventario);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.txtCant);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(16, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(495, 453);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(105, 276);
            this.txtn3.Margin = new System.Windows.Forms.Padding(4);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(32, 22);
            this.txtn3.TabIndex = 62;
            this.txtn3.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrar.Location = new System.Drawing.Point(371, 347);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 42);
            this.btnBorrar.TabIndex = 61;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(64, 276);
            this.txtn2.Margin = new System.Windows.Forms.Padding(4);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(32, 22);
            this.txtn2.TabIndex = 60;
            this.txtn2.Visible = false;
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(23, 276);
            this.txtn1.Margin = new System.Windows.Forms.Padding(4);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(32, 22);
            this.txtn1.TabIndex = 59;
            this.txtn1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(20, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Nombre Producto";
            // 
            // txtNomP
            // 
            this.txtNomP.Enabled = false;
            this.txtNomP.Location = new System.Drawing.Point(148, 300);
            this.txtNomP.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomP.Name = "txtNomP";
            this.txtNomP.ReadOnly = true;
            this.txtNomP.Size = new System.Drawing.Size(213, 22);
            this.txtNomP.TabIndex = 53;
            this.txtNomP.TextChanged += new System.EventHandler(this.txtNomP_TextChanged);
            this.txtNomP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomP_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(20, 336);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(148, 332);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(213, 22);
            this.txtPrecio.TabIndex = 55;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(20, 364);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(371, 298);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 42);
            this.btnAgregar.TabIndex = 57;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(148, 364);
            this.txtCant.Margin = new System.Windows.Forms.Padding(4);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(213, 22);
            this.txtCant.TabIndex = 58;
            this.txtCant.TextChanged += new System.EventHandler(this.txtCant_TextChanged);
            this.txtCant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCant_KeyDown);
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(8, 23);
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCarrito.MultiSelect = false;
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(377, 244);
            this.dgvCarrito.TabIndex = 34;
            this.dgvCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // proTableAdapter
            // 
            this.proTableAdapter.ClearBeforeFill = true;
            // 
            // _A_Beltran_CopiadoraDataSet14
            // 
            this._A_Beltran_CopiadoraDataSet14.DataSetName = "_A_Beltran_CopiadoraDataSet14";
            this._A_Beltran_CopiadoraDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleBindingSource
            // 
            this.detalleBindingSource.DataMember = "detalle";
            this.detalleBindingSource.DataSource = this._A_Beltran_CopiadoraDataSet14;
            // 
            // detalleTableAdapter
            // 
            this.detalleTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImage = global::Loginç.Properties.Resources.black_difuminado;
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtImp);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnFacturar);
            this.groupBox3.Controls.Add(this.txtSubT);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dgvCarrito);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(519, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(409, 453);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Producto";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(171, 364);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(213, 22);
            this.txtTotal.TabIndex = 58;
            this.txtTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(65, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Total";
            // 
            // txtImp
            // 
            this.txtImp.Enabled = false;
            this.txtImp.Location = new System.Drawing.Point(171, 332);
            this.txtImp.Margin = new System.Windows.Forms.Padding(4);
            this.txtImp.Name = "txtImp";
            this.txtImp.ReadOnly = true;
            this.txtImp.Size = new System.Drawing.Size(213, 22);
            this.txtImp.TabIndex = 56;
            this.txtImp.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(65, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Impuesto";
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Lime;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacturar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFacturar.Location = new System.Drawing.Point(285, 404);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(100, 42);
            this.btnFacturar.TabIndex = 52;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtSubT
            // 
            this.txtSubT.Enabled = false;
            this.txtSubT.Location = new System.Drawing.Point(171, 300);
            this.txtSubT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubT.Name = "txtSubT";
            this.txtSubT.ReadOnly = true;
            this.txtSubT.Size = new System.Drawing.Size(213, 22);
            this.txtSubT.TabIndex = 54;
            this.txtSubT.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(67, 304);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "Sub Total";
            // 
            // proTableAdapter1
            // 
            this.proTableAdapter1.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Loginç.Properties.Resources.black_difuminado;
            this.ClientSize = new System.Drawing.Size(944, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Facturar";
            this.Text = "Facturar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Facturar_FormClosing);
            this.Load += new System.EventHandler(this.Facturar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet13)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtId_Cliente;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtArqueo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.GroupBox groupBox2;
        private _A_Beltran_CopiadoraDataSet13 _A_Beltran_CopiadoraDataSet13;
        private System.Windows.Forms.BindingSource proBindingSource;
        private _A_Beltran_CopiadoraDataSet13TableAdapters.ProTableAdapter proTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionEstadoDataGridViewTextBoxColumn;
        private _A_Beltran_CopiadoraDataSet14 _A_Beltran_CopiadoraDataSet14;
        private System.Windows.Forms.BindingSource detalleBindingSource;
        private _A_Beltran_CopiadoraDataSet14TableAdapters.detalleTableAdapter detalleTableAdapter;
        public System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtCAI;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNomP;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtImp;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFacturar;
        public System.Windows.Forms.TextBox txtSubT;
        private System.Windows.Forms.Label label9;
        private _A_Beltran_CopiadoraDataSet15 _A_Beltran_CopiadoraDataSet15;
        private System.Windows.Forms.BindingSource proBindingSource1;
        private _A_Beltran_CopiadoraDataSet15TableAdapters.ProTableAdapter proTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtidFactura;
        private System.Windows.Forms.TextBox txtprecioUni;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.TextBox txtInventrioSerie;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtn3;
    }
}