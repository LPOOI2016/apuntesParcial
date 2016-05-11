namespace Vista
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocatario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInmueble = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCuotas = new System.Windows.Forms.ComboBox();
            this.dgwCuotas = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtContrato = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Locatario";
            // 
            // cmbLocatario
            // 
            this.cmbLocatario.FormattingEnabled = true;
            this.cmbLocatario.Location = new System.Drawing.Point(66, 21);
            this.cmbLocatario.Name = "cmbLocatario";
            this.cmbLocatario.Size = new System.Drawing.Size(164, 21);
            this.cmbLocatario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inmueble";
            // 
            // cmbInmueble
            // 
            this.cmbInmueble.FormattingEnabled = true;
            this.cmbInmueble.Location = new System.Drawing.Point(66, 61);
            this.cmbInmueble.Name = "cmbInmueble";
            this.cmbInmueble.Size = new System.Drawing.Size(164, 21);
            this.cmbInmueble.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(66, 99);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(96, 20);
            this.dtFecha.TabIndex = 5;
            this.dtFecha.Value = new System.DateTime(2016, 5, 10, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cuotas";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(66, 134);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(100, 20);
            this.txtCuotas.TabIndex = 7;
            this.txtCuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuotas_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(66, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Alquilar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(164, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorIcono.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtCuotas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbInmueble);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbLocatario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 232);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alquileres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Inmueble";
            // 
            // cmbCuotas
            // 
            this.cmbCuotas.FormattingEnabled = true;
            this.cmbCuotas.Location = new System.Drawing.Point(376, 33);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(121, 21);
            this.cmbCuotas.TabIndex = 12;
            this.cmbCuotas.SelectedValueChanged += new System.EventHandler(this.cmbCuotas_SelectedValueChanged);
            // 
            // dgwCuotas
            // 
            this.dgwCuotas.AllowUserToAddRows = false;
            this.dgwCuotas.AllowUserToDeleteRows = false;
            this.dgwCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCuotas.Location = new System.Drawing.Point(315, 67);
            this.dgwCuotas.Name = "dgwCuotas";
            this.dgwCuotas.ReadOnly = true;
            this.dgwCuotas.Size = new System.Drawing.Size(329, 158);
            this.dgwCuotas.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(315, 237);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "label6";
            // 
            // txtContrato
            // 
            this.txtContrato.Location = new System.Drawing.Point(532, 33);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(100, 20);
            this.txtContrato.TabIndex = 15;
            this.txtContrato.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 262);
            this.Controls.Add(this.txtContrato);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgwCuotas);
            this.Controls.Add(this.cmbCuotas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "Alquileres";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLocatario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbInmueble;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DataGridView dgwCuotas;
        private System.Windows.Forms.ComboBox cmbCuotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtContrato;
    }
}

