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
            this.idFactura = new System.Windows.Forms.TextBox();
            this.precioUni = new System.Windows.Forms.TextBox();
            this.idProducto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.InventrioSerie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtCAI = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet15 = new Loginç._A_Beltran_CopiadoraDataSet15();
            this.proBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet13 = new Loginç._A_Beltran_CopiadoraDataSet13();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.proTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet13TableAdapters.ProTableAdapter();
            this._A_Beltran_CopiadoraDataSet14 = new Loginç._A_Beltran_CopiadoraDataSet14();
            this.detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet14TableAdapters.detalleTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSubT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.proTableAdapter1 = new Loginç._A_Beltran_CopiadoraDataSet15TableAdapters.ProTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet13)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId_Cliente
            // 
            this.txtId_Cliente.Enabled = false;
            this.txtId_Cliente.Location = new System.Drawing.Point(82, 19);
            this.txtId_Cliente.Name = "txtId_Cliente";
            this.txtId_Cliente.ReadOnly = true;
            this.txtId_Cliente.Size = new System.Drawing.Size(131, 20);
            this.txtId_Cliente.TabIndex = 24;
            this.txtId_Cliente.Text = "0";
            this.txtId_Cliente.TextChanged += new System.EventHandler(this.txtID_CLIENTE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID Cliente";
            // 
            // txtArqueo
            // 
            this.txtArqueo.Enabled = false;
            this.txtArqueo.Location = new System.Drawing.Point(430, 45);
            this.txtArqueo.Name = "txtArqueo";
            this.txtArqueo.ReadOnly = true;
            this.txtArqueo.Size = new System.Drawing.Size(115, 20);
            this.txtArqueo.TabIndex = 28;
            this.txtArqueo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "ID Arqueo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "ID CAI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idFactura);
            this.groupBox1.Controls.Add(this.precioUni);
            this.groupBox1.Controls.Add(this.idProducto);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.InventrioSerie);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtCAI);
            this.groupBox1.Controls.Add(this.txtId_Cliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtArqueo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 81);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Factura";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // idFactura
            // 
            this.idFactura.Location = new System.Drawing.Point(296, 48);
            this.idFactura.Name = "idFactura";
            this.idFactura.Size = new System.Drawing.Size(57, 20);
            this.idFactura.TabIndex = 36;
            this.idFactura.Visible = false;
            // 
            // precioUni
            // 
            this.precioUni.Location = new System.Drawing.Point(296, 19);
            this.precioUni.Name = "precioUni";
            this.precioUni.Size = new System.Drawing.Size(57, 20);
            this.precioUni.TabIndex = 35;
            this.precioUni.Visible = false;
            // 
            // idProducto
            // 
            this.idProducto.Location = new System.Drawing.Point(219, 48);
            this.idProducto.Name = "idProducto";
            this.idProducto.Size = new System.Drawing.Size(63, 20);
            this.idProducto.TabIndex = 34;
            this.idProducto.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 51;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // InventrioSerie
            // 
            this.InventrioSerie.Location = new System.Drawing.Point(219, 19);
            this.InventrioSerie.Name = "InventrioSerie";
            this.InventrioSerie.Size = new System.Drawing.Size(63, 20);
            this.InventrioSerie.TabIndex = 33;
            this.InventrioSerie.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "ID Usuario";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(82, 45);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(131, 20);
            this.txtUser.TabIndex = 31;
            this.txtUser.Text = "0";
            // 
            // txtCAI
            // 
            this.txtCAI.Enabled = false;
            this.txtCAI.Location = new System.Drawing.Point(429, 19);
            this.txtCAI.Name = "txtCAI";
            this.txtCAI.ReadOnly = true;
            this.txtCAI.Size = new System.Drawing.Size(115, 20);
            this.txtCAI.TabIndex = 30;
            this.txtCAI.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descripcionEstadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 18);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(336, 199);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
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
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNomP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtCant);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 354);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 224);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 62;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(257, 282);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 34);
            this.btnBorrar.TabIndex = 61;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 60;
            this.textBox1.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(17, 224);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(25, 20);
            this.textBox9.TabIndex = 59;
            this.textBox9.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Nombre Producto";
            // 
            // txtNomP
            // 
            this.txtNomP.Enabled = false;
            this.txtNomP.Location = new System.Drawing.Point(111, 244);
            this.txtNomP.Name = "txtNomP";
            this.txtNomP.ReadOnly = true;
            this.txtNomP.Size = new System.Drawing.Size(131, 20);
            this.txtNomP.TabIndex = 53;
            this.txtNomP.TextChanged += new System.EventHandler(this.txtNomP_TextChanged);
            this.txtNomP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomP_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(111, 270);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(131, 20);
            this.txtPrecio.TabIndex = 55;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 57;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(111, 296);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(131, 20);
            this.txtCant.TabIndex = 58;
            this.txtCant.TextChanged += new System.EventHandler(this.txtCant_TextChanged);
            this.txtCant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCant_KeyDown);
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(283, 198);
            this.dataGridView2.TabIndex = 34;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
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
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtImp);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.txtSubT);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(389, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 354);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Producto";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(77, 296);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(198, 20);
            this.txtTotal.TabIndex = 58;
            this.txtTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Total";
            // 
            // txtImp
            // 
            this.txtImp.Enabled = false;
            this.txtImp.Location = new System.Drawing.Point(77, 270);
            this.txtImp.Name = "txtImp";
            this.txtImp.ReadOnly = true;
            this.txtImp.Size = new System.Drawing.Size(198, 20);
            this.txtImp.TabIndex = 56;
            this.txtImp.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Impuesto";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 52;
            this.button3.Text = "Facturar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtSubT
            // 
            this.txtSubT.Enabled = false;
            this.txtSubT.Location = new System.Drawing.Point(76, 244);
            this.txtSubT.Name = "txtSubT";
            this.txtSubT.ReadOnly = true;
            this.txtSubT.Size = new System.Drawing.Size(199, 20);
            this.txtSubT.TabIndex = 54;
            this.txtSubT.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Facturar";
            this.Text = "Facturar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Facturar_FormClosing);
            this.Load += new System.EventHandler(this.Facturar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet13)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtCAI;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNomP;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtImp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtSubT;
        private System.Windows.Forms.Label label9;
        private _A_Beltran_CopiadoraDataSet15 _A_Beltran_CopiadoraDataSet15;
        private System.Windows.Forms.BindingSource proBindingSource1;
        private _A_Beltran_CopiadoraDataSet15TableAdapters.ProTableAdapter proTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox idFactura;
        private System.Windows.Forms.TextBox precioUni;
        private System.Windows.Forms.TextBox idProducto;
        private System.Windows.Forms.TextBox InventrioSerie;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox textBox2;
    }
}