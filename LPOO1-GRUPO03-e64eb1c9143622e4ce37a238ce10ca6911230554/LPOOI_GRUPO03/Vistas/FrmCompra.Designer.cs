﻿namespace Vistas
{
    partial class FrmCompra
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetallesItems = new System.Windows.Forms.DataGridView();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.cmbProv_ID = new System.Windows.Forms.ComboBox();
            this.lblTotal_Pagado = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtArt_Costo = new System.Windows.Forms.TextBox();
            this.lblArt_Costo = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchArt = new System.Windows.Forms.Button();
            this.lblArt_ID = new System.Windows.Forms.Label();
            this.txtArt_Descrip = new System.Windows.Forms.TextBox();
            this.lblOc_Pagada = new System.Windows.Forms.Label();
            this.dtOc_Fecha = new System.Windows.Forms.DateTimePicker();
            this.lblOc_Fecha = new System.Windows.Forms.Label();
            this.lblProv_ID = new System.Windows.Forms.Label();
            this.btnCancelOC = new System.Windows.Forms.Button();
            this.btnSaveOC = new System.Windows.Forms.Button();
            this.btnNewOC = new System.Windows.Forms.Button();
            this.txtOc_ID = new System.Windows.Forms.TextBox();
            this.lblOc_ID = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnProveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 51);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 373);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataListado);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(707, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Location = new System.Drawing.Point(10, 87);
            this.dataListado.Margin = new System.Windows.Forms.Padding(2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(670, 241);
            this.dataListado.TabIndex = 7;
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(375, 64);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(707, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDetallesItems);
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.Controls.Add(this.cmbProv_ID);
            this.groupBox1.Controls.Add(this.lblTotal_Pagado);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblOc_Pagada);
            this.groupBox1.Controls.Add(this.dtOc_Fecha);
            this.groupBox1.Controls.Add(this.lblOc_Fecha);
            this.groupBox1.Controls.Add(this.lblProv_ID);
            this.groupBox1.Controls.Add(this.btnCancelOC);
            this.groupBox1.Controls.Add(this.btnSaveOC);
            this.groupBox1.Controls.Add(this.btnNewOC);
            this.groupBox1.Controls.Add(this.txtOc_ID);
            this.groupBox1.Controls.Add(this.lblOc_ID);
            this.groupBox1.Location = new System.Drawing.Point(10, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(673, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos Almacén";
            // 
            // dgvDetallesItems
            // 
            this.dgvDetallesItems.AllowUserToAddRows = false;
            this.dgvDetallesItems.AllowUserToDeleteRows = false;
            this.dgvDetallesItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesItems.Location = new System.Drawing.Point(11, 175);
            this.dgvDetallesItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetallesItems.MultiSelect = false;
            this.dgvDetallesItems.Name = "dgvDetallesItems";
            this.dgvDetallesItems.ReadOnly = true;
            this.dgvDetallesItems.RowTemplate.Height = 24;
            this.dgvDetallesItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallesItems.Size = new System.Drawing.Size(637, 104);
            this.dgvDetallesItems.TabIndex = 32;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(351, 65);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 46;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(311, 65);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(34, 17);
            this.rbYes.TabIndex = 45;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Si";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // cmbProv_ID
            // 
            this.cmbProv_ID.FormattingEnabled = true;
            this.cmbProv_ID.Location = new System.Drawing.Point(265, 31);
            this.cmbProv_ID.Name = "cmbProv_ID";
            this.cmbProv_ID.Size = new System.Drawing.Size(121, 21);
            this.cmbProv_ID.TabIndex = 44;
            // 
            // lblTotal_Pagado
            // 
            this.lblTotal_Pagado.AutoSize = true;
            this.lblTotal_Pagado.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_Pagado.ForeColor = System.Drawing.Color.Red;
            this.lblTotal_Pagado.Location = new System.Drawing.Point(90, 274);
            this.lblTotal_Pagado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal_Pagado.Name = "lblTotal_Pagado";
            this.lblTotal_Pagado.Size = new System.Drawing.Size(66, 41);
            this.lblTotal_Pagado.TabIndex = 43;
            this.lblTotal_Pagado.Text = "0.0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 290);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Total Pagado: $ ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtArt_Costo);
            this.groupBox2.Controls.Add(this.lblArt_Costo);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.lblSubTotal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSearchArt);
            this.groupBox2.Controls.Add(this.lblArt_ID);
            this.groupBox2.Controls.Add(this.txtArt_Descrip);
            this.groupBox2.Location = new System.Drawing.Point(116, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(461, 76);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::Vistas.Properties.Resources.remove;
            this.btnRemove.Location = new System.Drawing.Point(417, 10);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(40, 30);
            this.btnRemove.TabIndex = 41;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Vistas.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(417, 44);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 30);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtArt_Costo
            // 
            this.txtArt_Costo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtArt_Costo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArt_Costo.Location = new System.Drawing.Point(288, 10);
            this.txtArt_Costo.Margin = new System.Windows.Forms.Padding(2);
            this.txtArt_Costo.Name = "txtArt_Costo";
            this.txtArt_Costo.Size = new System.Drawing.Size(94, 20);
            this.txtArt_Costo.TabIndex = 35;
            this.txtArt_Costo.TextChanged += new System.EventHandler(this.txtArt_Costo_TextChanged);
            // 
            // lblArt_Costo
            // 
            this.lblArt_Costo.AutoSize = true;
            this.lblArt_Costo.Location = new System.Drawing.Point(247, 14);
            this.lblArt_Costo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArt_Costo.Name = "lblArt_Costo";
            this.lblArt_Costo.Size = new System.Drawing.Size(37, 13);
            this.lblArt_Costo.TabIndex = 34;
            this.lblArt_Costo.Text = "Costo:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(91, 42);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(94, 20);
            this.txtCantidad.TabIndex = 33;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.Red;
            this.lblSubTotal.Location = new System.Drawing.Point(352, 44);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(16, 16);
            this.lblSubTotal.TabIndex = 42;
            this.lblSubTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "SubTotal: $ ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Cantidad:";
            // 
            // btnSearchArt
            // 
            this.btnSearchArt.Image = global::Vistas.Properties.Resources.search;
            this.btnSearchArt.Location = new System.Drawing.Point(201, 8);
            this.btnSearchArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchArt.Name = "btnSearchArt";
            this.btnSearchArt.Size = new System.Drawing.Size(32, 25);
            this.btnSearchArt.TabIndex = 32;
            this.btnSearchArt.UseVisualStyleBackColor = true;
            this.btnSearchArt.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // lblArt_ID
            // 
            this.lblArt_ID.AutoSize = true;
            this.lblArt_ID.Location = new System.Drawing.Point(35, 14);
            this.lblArt_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArt_ID.Name = "lblArt_ID";
            this.lblArt_ID.Size = new System.Drawing.Size(47, 13);
            this.lblArt_ID.TabIndex = 29;
            this.lblArt_ID.Text = "Artículo:";
            // 
            // txtArt_Descrip
            // 
            this.txtArt_Descrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtArt_Descrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArt_Descrip.Location = new System.Drawing.Point(91, 10);
            this.txtArt_Descrip.Margin = new System.Windows.Forms.Padding(2);
            this.txtArt_Descrip.Name = "txtArt_Descrip";
            this.txtArt_Descrip.Size = new System.Drawing.Size(94, 20);
            this.txtArt_Descrip.TabIndex = 30;
            // 
            // lblOc_Pagada
            // 
            this.lblOc_Pagada.AutoSize = true;
            this.lblOc_Pagada.Location = new System.Drawing.Point(259, 67);
            this.lblOc_Pagada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOc_Pagada.Name = "lblOc_Pagada";
            this.lblOc_Pagada.Size = new System.Drawing.Size(47, 13);
            this.lblOc_Pagada.TabIndex = 24;
            this.lblOc_Pagada.Text = "Pagada:";
            // 
            // dtOc_Fecha
            // 
            this.dtOc_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOc_Fecha.Location = new System.Drawing.Point(478, 32);
            this.dtOc_Fecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtOc_Fecha.Name = "dtOc_Fecha";
            this.dtOc_Fecha.Size = new System.Drawing.Size(112, 20);
            this.dtOc_Fecha.TabIndex = 22;
            // 
            // lblOc_Fecha
            // 
            this.lblOc_Fecha.AutoSize = true;
            this.lblOc_Fecha.Location = new System.Drawing.Point(432, 34);
            this.lblOc_Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOc_Fecha.Name = "lblOc_Fecha";
            this.lblOc_Fecha.Size = new System.Drawing.Size(40, 13);
            this.lblOc_Fecha.TabIndex = 21;
            this.lblOc_Fecha.Text = "Fecha:";
            // 
            // lblProv_ID
            // 
            this.lblProv_ID.AutoSize = true;
            this.lblProv_ID.Location = new System.Drawing.Point(201, 34);
            this.lblProv_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProv_ID.Name = "lblProv_ID";
            this.lblProv_ID.Size = new System.Drawing.Size(59, 13);
            this.lblProv_ID.TabIndex = 15;
            this.lblProv_ID.Text = "Proveedor:";
            // 
            // btnCancelOC
            // 
            this.btnCancelOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelOC.Location = new System.Drawing.Point(568, 284);
            this.btnCancelOC.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelOC.Name = "btnCancelOC";
            this.btnCancelOC.Size = new System.Drawing.Size(80, 27);
            this.btnCancelOC.TabIndex = 9;
            this.btnCancelOC.Text = "&Cancelar";
            this.btnCancelOC.UseVisualStyleBackColor = false;
            this.btnCancelOC.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSaveOC
            // 
            this.btnSaveOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveOC.Location = new System.Drawing.Point(478, 284);
            this.btnSaveOC.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveOC.Name = "btnSaveOC";
            this.btnSaveOC.Size = new System.Drawing.Size(80, 27);
            this.btnSaveOC.TabIndex = 7;
            this.btnSaveOC.Text = "&Guardar";
            this.btnSaveOC.UseVisualStyleBackColor = false;
            this.btnSaveOC.Click += new System.EventHandler(this.btnSaveOC_Click);
            // 
            // btnNewOC
            // 
            this.btnNewOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewOC.Location = new System.Drawing.Point(393, 284);
            this.btnNewOC.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewOC.Name = "btnNewOC";
            this.btnNewOC.Size = new System.Drawing.Size(80, 26);
            this.btnNewOC.TabIndex = 6;
            this.btnNewOC.Text = "&Nuevo";
            this.btnNewOC.UseVisualStyleBackColor = false;
            this.btnNewOC.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtOc_ID
            // 
            this.txtOc_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtOc_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOc_ID.Location = new System.Drawing.Point(88, 32);
            this.txtOc_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOc_ID.Name = "txtOc_ID";
            this.txtOc_ID.Size = new System.Drawing.Size(94, 20);
            this.txtOc_ID.TabIndex = 3;
            // 
            // lblOc_ID
            // 
            this.lblOc_ID.AutoSize = true;
            this.lblOc_ID.Location = new System.Drawing.Point(18, 37);
            this.lblOc_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOc_ID.Name = "lblOc_ID";
            this.lblOc_ID.Size = new System.Drawing.Size(43, 13);
            this.lblOc_ID.TabIndex = 0;
            this.lblOc_ID.Text = "Código:";
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProveedor.Image = global::Vistas.Properties.Resources.proveedor;
            this.btnProveedor.Location = new System.Drawing.Point(558, 8);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(138, 55);
            this.btnProveedor.TabIndex = 11;
            this.ttMensaje.SetToolTip(this.btnProveedor, "Proveedor");
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Compras";
            // 
            // errorIcono
            // 
            this.errorIcono.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorIcono.ContainerControl = this;
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 434);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Mantenimiento de Ingresos .:.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompra_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtArt_Costo;
        private System.Windows.Forms.Label lblArt_Costo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchArt;
        private System.Windows.Forms.Label lblArt_ID;
        private System.Windows.Forms.TextBox txtArt_Descrip;
        private System.Windows.Forms.Label lblOc_Pagada;
        private System.Windows.Forms.DateTimePicker dtOc_Fecha;
        private System.Windows.Forms.Label lblOc_Fecha;
        private System.Windows.Forms.Label lblProv_ID;
        private System.Windows.Forms.Button btnCancelOC;
        private System.Windows.Forms.Button btnSaveOC;
        private System.Windows.Forms.Button btnNewOC;
        private System.Windows.Forms.TextBox txtOc_ID;
        private System.Windows.Forms.Label lblOc_ID;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DataGridView dgvDetallesItems;
        private System.Windows.Forms.Label lblTotal_Pagado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbProv_ID;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label2;
    }
}