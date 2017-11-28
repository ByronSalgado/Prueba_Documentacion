namespace Loginç
{
    partial class IngresoModificacionProducto
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaProductoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet6 = new Loginç._A_Beltran_CopiadoraDataSet6();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.estadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet7 = new Loginç._A_Beltran_CopiadoraDataSet7();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNomProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._A_Beltran_CopiadoraDataSet3 = new Loginç._A_Beltran_CopiadoraDataSet3();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet3TableAdapters.EstadoTableAdapter();
            this._A_Beltran_CopiadoraDataSet4 = new Loginç._A_Beltran_CopiadoraDataSet4();
            this.categoriaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoria_ProductoTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet4TableAdapters.Categoria_ProductoTableAdapter();
            this._A_Beltran_CopiadoraDataSet5 = new Loginç._A_Beltran_CopiadoraDataSet5();
            this.categoriaProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoria_ProductoTableAdapter1 = new Loginç._A_Beltran_CopiadoraDataSet5TableAdapters.Categoria_ProductoTableAdapter();
            this.obtenerIdProducto = new System.Windows.Forms.TextBox();
            this.categoria_ProductoTableAdapter2 = new Loginç._A_Beltran_CopiadoraDataSet6TableAdapters.Categoria_ProductoTableAdapter();
            this.estadoTableAdapter1 = new Loginç._A_Beltran_CopiadoraDataSet7TableAdapters.EstadoTableAdapter();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Lime;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(436, 444);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Red;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.Location = new System.Drawing.Point(544, 444);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 28);
            this.btnRegresar.TabIndex = 34;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(435, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DataSource = this.categoriaProductoBindingSource2;
            this.cmbCategoria.DisplayMember = "Nombre_Categoria";
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(333, 202);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(249, 24);
            this.cmbCategoria.TabIndex = 17;
            this.cmbCategoria.ValueMember = "ID_Categoria";
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // categoriaProductoBindingSource2
            // 
            this.categoriaProductoBindingSource2.DataMember = "Categoria_Producto";
            this.categoriaProductoBindingSource2.DataSource = this._A_Beltran_CopiadoraDataSet6;
            // 
            // _A_Beltran_CopiadoraDataSet6
            // 
            this._A_Beltran_CopiadoraDataSet6.DataSetName = "_A_Beltran_CopiadoraDataSet6";
            this._A_Beltran_CopiadoraDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estado";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Categoria";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DataSource = this.estadoBindingSource1;
            this.cmbEstado.DisplayMember = "Descripcion_Estado";
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(48, 251);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(249, 24);
            this.cmbEstado.TabIndex = 1;
            this.cmbEstado.ValueMember = "ID_Estado";
            this.cmbEstado.Visible = false;
            // 
            // estadoBindingSource1
            // 
            this.estadoBindingSource1.DataMember = "Estado";
            this.estadoBindingSource1.DataSource = this._A_Beltran_CopiadoraDataSet7;
            // 
            // _A_Beltran_CopiadoraDataSet7
            // 
            this._A_Beltran_CopiadoraDataSet7.DataSetName = "_A_Beltran_CopiadoraDataSet7";
            this._A_Beltran_CopiadoraDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cantidad Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Descripcion del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Codigo de Barra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Numero de Serie";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(48, 203);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(249, 22);
            this.txtCantidad.TabIndex = 26;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantidad_Validating);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(333, 155);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(249, 22);
            this.txtPrecio.TabIndex = 25;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecio_Validating);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(48, 155);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(249, 22);
            this.txtDescripcion.TabIndex = 24;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            this.txtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcion_Validating);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(333, 107);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(249, 22);
            this.txtCodigo.TabIndex = 23;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(48, 107);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(249, 22);
            this.txtNum.TabIndex = 22;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyDown);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            this.txtNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtNum_Validating);
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.Location = new System.Drawing.Point(333, 59);
            this.txtNomProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(249, 22);
            this.txtNomProducto.TabIndex = 21;
            this.txtNomProducto.TextChanged += new System.EventHandler(this.txtNomProducto_TextChanged);
            this.txtNomProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomProducto_KeyDown);
            this.txtNomProducto.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomProducto_Validating);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Enabled = false;
            this.txtCodigoProducto.Location = new System.Drawing.Point(48, 59);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(249, 22);
            this.txtCodigoProducto.TabIndex = 20;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo Producto";
            // 
            // _A_Beltran_CopiadoraDataSet3
            // 
            this._A_Beltran_CopiadoraDataSet3.DataSetName = "_A_Beltran_CopiadoraDataSet3";
            this._A_Beltran_CopiadoraDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this._A_Beltran_CopiadoraDataSet3;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // _A_Beltran_CopiadoraDataSet4
            // 
            this._A_Beltran_CopiadoraDataSet4.DataSetName = "_A_Beltran_CopiadoraDataSet4";
            this._A_Beltran_CopiadoraDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaProductoBindingSource
            // 
            this.categoriaProductoBindingSource.DataMember = "Categoria_Producto";
            this.categoriaProductoBindingSource.DataSource = this._A_Beltran_CopiadoraDataSet4;
            // 
            // categoria_ProductoTableAdapter
            // 
            this.categoria_ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // _A_Beltran_CopiadoraDataSet5
            // 
            this._A_Beltran_CopiadoraDataSet5.DataSetName = "_A_Beltran_CopiadoraDataSet5";
            this._A_Beltran_CopiadoraDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaProductoBindingSource1
            // 
            this.categoriaProductoBindingSource1.DataMember = "Categoria_Producto";
            this.categoriaProductoBindingSource1.DataSource = this._A_Beltran_CopiadoraDataSet5;
            // 
            // categoria_ProductoTableAdapter1
            // 
            this.categoria_ProductoTableAdapter1.ClearBeforeFill = true;
            // 
            // obtenerIdProducto
            // 
            this.obtenerIdProducto.Location = new System.Drawing.Point(16, 444);
            this.obtenerIdProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.obtenerIdProducto.Name = "obtenerIdProducto";
            this.obtenerIdProducto.Size = new System.Drawing.Size(27, 22);
            this.obtenerIdProducto.TabIndex = 36;
            this.obtenerIdProducto.Visible = false;
            // 
            // categoria_ProductoTableAdapter2
            // 
            this.categoria_ProductoTableAdapter2.ClearBeforeFill = true;
            // 
            // estadoTableAdapter1
            // 
            this.estadoTableAdapter1.ClearBeforeFill = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbEstado);
            this.groupBox2.Controls.Add(this.cmbCategoria);
            this.groupBox2.Controls.Add(this.txtCodigoProducto);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNomProducto);
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(15, 113);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(628, 324);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(131, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(421, 35);
            this.label10.TabIndex = 47;
            this.label10.Text = "A.Beltran.Copiadora S. de R.L.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Loginç.Properties.Resources.icon_account2;
            this.pictureBox2.Location = new System.Drawing.Point(15, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // IngresoModificacionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Loginç.Properties.Resources.black_difuminado;
            this.ClientSize = new System.Drawing.Size(660, 480);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.obtenerIdProducto);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "IngresoModificacionProducto";
            this.Text = "IngresoModificacionProducto";
            this.Load += new System.EventHandler(this.IngresoModificacionProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtNum;
        public System.Windows.Forms.TextBox txtNomProducto;
        public System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private _A_Beltran_CopiadoraDataSet3 _A_Beltran_CopiadoraDataSet3;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private _A_Beltran_CopiadoraDataSet3TableAdapters.EstadoTableAdapter estadoTableAdapter;
        private _A_Beltran_CopiadoraDataSet4 _A_Beltran_CopiadoraDataSet4;
        private System.Windows.Forms.BindingSource categoriaProductoBindingSource;
        private _A_Beltran_CopiadoraDataSet4TableAdapters.Categoria_ProductoTableAdapter categoria_ProductoTableAdapter;
        private _A_Beltran_CopiadoraDataSet5 _A_Beltran_CopiadoraDataSet5;
        private System.Windows.Forms.BindingSource categoriaProductoBindingSource1;
        private _A_Beltran_CopiadoraDataSet5TableAdapters.Categoria_ProductoTableAdapter categoria_ProductoTableAdapter1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox obtenerIdProducto;
        public System.Windows.Forms.ComboBox cmbCategoria;
        private _A_Beltran_CopiadoraDataSet6 _A_Beltran_CopiadoraDataSet6;
        private System.Windows.Forms.BindingSource categoriaProductoBindingSource2;
        private _A_Beltran_CopiadoraDataSet6TableAdapters.Categoria_ProductoTableAdapter categoria_ProductoTableAdapter2;
        private _A_Beltran_CopiadoraDataSet7 _A_Beltran_CopiadoraDataSet7;
        private System.Windows.Forms.BindingSource estadoBindingSource1;
        private _A_Beltran_CopiadoraDataSet7TableAdapters.EstadoTableAdapter estadoTableAdapter1;
        private System.Windows.Forms.ErrorProvider epError;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}