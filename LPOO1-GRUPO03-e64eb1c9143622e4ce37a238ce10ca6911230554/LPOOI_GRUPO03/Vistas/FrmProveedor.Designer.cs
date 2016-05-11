namespace Vistas
{
    partial class FrmProveedor
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
            this.txtProv_Nom = new System.Windows.Forms.TextBox();
            this.txtProv_Id = new System.Windows.Forms.TextBox();
            this.lblProv_Dom = new System.Windows.Forms.Label();
            this.lblProv_Nom = new System.Windows.Forms.Label();
            this.lblProv_Id = new System.Windows.Forms.Label();
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.txtProv_Mail = new System.Windows.Forms.TextBox();
            this.lblProv_Mail = new System.Windows.Forms.Label();
            this.txtProv_CP = new System.Windows.Forms.TextBox();
            this.lblProv_CP = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblProv_Tel = new System.Windows.Forms.Label();
            this.txtProv_Dep = new System.Windows.Forms.TextBox();
            this.lblProv_Dep = new System.Windows.Forms.Label();
            this.btnCancelProv = new System.Windows.Forms.Button();
            this.btnEditProv = new System.Windows.Forms.Button();
            this.btnSaveProv = new System.Windows.Forms.Button();
            this.btnNewProv = new System.Windows.Forms.Button();
            this.txtProv_Dom = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.txtSearchProv = new System.Windows.Forms.TextBox();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgwProveedores = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteProv = new System.Windows.Forms.Button();
            this.btnSearchProv = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.gbProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProveedores)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProv_Nom
            // 
            this.txtProv_Nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtProv_Nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProv_Nom.Location = new System.Drawing.Point(117, 69);
            this.txtProv_Nom.Margin = new System.Windows.Forms.Padding(2);
            this.txtProv_Nom.Name = "txtProv_Nom";
            this.txtProv_Nom.Size = new System.Drawing.Size(198, 20);
            this.txtProv_Nom.TabIndex = 4;
            // 
            // txtProv_Id
            // 
            this.txtProv_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtProv_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProv_Id.Location = new System.Drawing.Point(115, 35);
            this.txtProv_Id.Margin = new System.Windows.Forms.Padding(2);
            this.txtProv_Id.Name = "txtProv_Id";
            this.txtProv_Id.ReadOnly = true;
            this.txtProv_Id.Size = new System.Drawing.Size(83, 20);
            this.txtProv_Id.TabIndex = 3;
            // 
            // lblProv_Dom
            // 
            this.lblProv_Dom.AutoSize = true;
            this.lblProv_Dom.Location = new System.Drawing.Point(22, 147);
            this.lblProv_Dom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProv_Dom.Name = "lblProv_Dom";
            this.lblProv_Dom.Size = new System.Drawing.Size(55, 13);
            this.lblProv_Dom.TabIndex = 2;
            this.lblProv_Dom.Text = "Dirección:";
            // 
            // lblProv_Nom
            // 
            this.lblProv_Nom.AutoSize = true;
            this.lblProv_Nom.Location = new System.Drawing.Point(20, 71);
            this.lblProv_Nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProv_Nom.Name = "lblProv_Nom";
            this.lblProv_Nom.Size = new System.Drawing.Size(47, 13);
            this.lblProv_Nom.TabIndex = 1;
            this.lblProv_Nom.Text = "Nombre:";
            // 
            // lblProv_Id
            // 
            this.lblProv_Id.AutoSize = true;
            this.lblProv_Id.Location = new System.Drawing.Point(22, 37);
            this.lblProv_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProv_Id.Name = "lblProv_Id";
            this.lblProv_Id.Size = new System.Drawing.Size(43, 13);
            this.lblProv_Id.TabIndex = 0;
            this.lblProv_Id.Text = "Código:";
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.txtProv_Mail);
            this.gbProveedor.Controls.Add(this.lblProv_Mail);
            this.gbProveedor.Controls.Add(this.txtProv_CP);
            this.gbProveedor.Controls.Add(this.lblProv_CP);
            this.gbProveedor.Controls.Add(this.txtTelefono);
            this.gbProveedor.Controls.Add(this.lblProv_Tel);
            this.gbProveedor.Controls.Add(this.txtProv_Dep);
            this.gbProveedor.Controls.Add(this.lblProv_Dep);
            this.gbProveedor.Controls.Add(this.btnCancelProv);
            this.gbProveedor.Controls.Add(this.btnEditProv);
            this.gbProveedor.Controls.Add(this.btnSaveProv);
            this.gbProveedor.Controls.Add(this.btnNewProv);
            this.gbProveedor.Controls.Add(this.txtProv_Dom);
            this.gbProveedor.Controls.Add(this.txtProv_Nom);
            this.gbProveedor.Controls.Add(this.txtProv_Id);
            this.gbProveedor.Controls.Add(this.lblProv_Dom);
            this.gbProveedor.Controls.Add(this.lblProv_Nom);
            this.gbProveedor.Controls.Add(this.lblProv_Id);
            this.gbProveedor.Location = new System.Drawing.Point(48, 17);
            this.gbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Padding = new System.Windows.Forms.Padding(2);
            this.gbProveedor.Size = new System.Drawing.Size(528, 284);
            this.gbProveedor.TabIndex = 0;
            this.gbProveedor.TabStop = false;
            this.gbProveedor.Text = "Proveedores";
            // 
            // txtProv_Mail
            // 
            this.txtProv_Mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtProv_Mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProv_Mail.Location = new System.Drawing.Point(364, 197);
            this.txtProv_Mail.Margin = new System.Windows.Forms.Padding(2);
            this.txtProv_Mail.Name = "txtProv_Mail";
            this.txtProv_Mail.Size = new System.Drawing.Size(145, 20);
            this.txtProv_Mail.TabIndex = 20;
            // 
            // lblProv_Mail
            // 
            this.lblProv_Mail.AutoSize = true;
            this.lblProv_Mail.Location = new System.Drawing.Point(322, 199);
            this.lblProv_Mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProv_Mail.Name = "lblProv_Mail";
            this.lblProv_Mail.Size = new System.Drawing.Size(38, 13);
            this.lblProv_Mail.TabIndex = 19;
            this.lblProv_Mail.Text = "E-mail:";
            // 
            // txtProv_CP
            // 
            this.txtProv_CP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtProv_CP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProv_CP.Location = new System.Drawing.Point(371, 35);
            this.txtProv_CP.Margin = new System.Windows.Forms.Padding(2);
            this.txtProv_CP.Name = "txtProv_CP";
            this.txtProv_CP.Size = new System.Drawing.Size(103, 20);
            this.txtProv_CP.TabIndex = 18;
            // 
            // lblProv_CP
            // 
            this.lblProv_CP.AutoSize = true;
            this.lblProv_CP.Location = new System.Drawing.Point(292, 37);
            this.lblProv_CP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProv_CP.Name = "lblProv_CP";
            this.lblProv_CP.Size = new System.Drawing.Size(75, 13);
            this.lblProv_CP.TabIndex = 17;
            this.lblProv_CP.Text = "Codigo Postal:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(117, 197);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(198, 20);
            this.txtTelefono.TabIndex = 16;
            // 
            // lblProv_Tel
            // 
            this.lblProv_Tel.AutoSize = true;
            this.lblProv_Tel.Location = new System.Drawing.Point(22, 199);
            this.lblProv_Tel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProv_Tel.Name = "lblProv_Tel";
            this.lblProv_Tel.Size = new System.Drawing.Size(52, 13);
            this.lblProv_Tel.TabIndex = 15;
            this.lblProv_Tel.Text = "Teléfono:";
            // 
            // txtProv_Dep
            // 
            this.txtProv_Dep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtProv_Dep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProv_Dep.Location = new System.Drawing.Point(115, 104);
            this.txtProv_Dep.Margin = new System.Windows.Forms.Padding(2);
            this.txtProv_Dep.Name = "txtProv_Dep";
            this.txtProv_Dep.Size = new System.Drawing.Size(198, 20);
            this.txtProv_Dep.TabIndex = 14;
            // 
            // lblProv_Dep
            // 
            this.lblProv_Dep.AutoSize = true;
            this.lblProv_Dep.Location = new System.Drawing.Point(22, 106);
            this.lblProv_Dep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProv_Dep.Name = "lblProv_Dep";
            this.lblProv_Dep.Size = new System.Drawing.Size(77, 13);
            this.lblProv_Dep.TabIndex = 12;
            this.lblProv_Dep.Text = "Departamento:";
            // 
            // btnCancelProv
            // 
            this.btnCancelProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelProv.Location = new System.Drawing.Point(382, 244);
            this.btnCancelProv.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelProv.Name = "btnCancelProv";
            this.btnCancelProv.Size = new System.Drawing.Size(80, 27);
            this.btnCancelProv.TabIndex = 9;
            this.btnCancelProv.Text = "&Cancelar";
            this.btnCancelProv.UseVisualStyleBackColor = false;
            this.btnCancelProv.Click += new System.EventHandler(this.btnCancelProv_Click_1);
            // 
            // btnEditProv
            // 
            this.btnEditProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProv.Location = new System.Drawing.Point(280, 244);
            this.btnEditProv.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditProv.Name = "btnEditProv";
            this.btnEditProv.Size = new System.Drawing.Size(80, 27);
            this.btnEditProv.TabIndex = 8;
            this.btnEditProv.Text = "E&ditar";
            this.btnEditProv.UseVisualStyleBackColor = false;
            this.btnEditProv.Click += new System.EventHandler(this.btnEditProv_Click);
            // 
            // btnSaveProv
            // 
            this.btnSaveProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProv.Location = new System.Drawing.Point(184, 244);
            this.btnSaveProv.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveProv.Name = "btnSaveProv";
            this.btnSaveProv.Size = new System.Drawing.Size(80, 27);
            this.btnSaveProv.TabIndex = 7;
            this.btnSaveProv.Text = "&Guardar";
            this.btnSaveProv.UseVisualStyleBackColor = false;
            this.btnSaveProv.Click += new System.EventHandler(this.btnSaveProv_Click);
            // 
            // btnNewProv
            // 
            this.btnNewProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProv.Location = new System.Drawing.Point(87, 244);
            this.btnNewProv.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewProv.Name = "btnNewProv";
            this.btnNewProv.Size = new System.Drawing.Size(80, 26);
            this.btnNewProv.TabIndex = 6;
            this.btnNewProv.Text = "&Nuevo";
            this.btnNewProv.UseVisualStyleBackColor = false;
            this.btnNewProv.Click += new System.EventHandler(this.btnNewProv_Click);
            // 
            // txtProv_Dom
            // 
            this.txtProv_Dom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtProv_Dom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProv_Dom.Location = new System.Drawing.Point(116, 145);
            this.txtProv_Dom.Margin = new System.Windows.Forms.Padding(2);
            this.txtProv_Dom.Multiline = true;
            this.txtProv_Dom.Name = "txtProv_Dom";
            this.txtProv_Dom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProv_Dom.Size = new System.Drawing.Size(226, 43);
            this.txtProv_Dom.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(495, 67);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(10, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = " ";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(10, 64);
            this.chkDelete.Margin = new System.Windows.Forms.Padding(2);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(62, 17);
            this.chkDelete.TabIndex = 5;
            this.chkDelete.Text = "Eliminar";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // txtSearchProv
            // 
            this.txtSearchProv.Location = new System.Drawing.Point(191, 28);
            this.txtSearchProv.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchProv.Name = "txtSearchProv";
            this.txtSearchProv.Size = new System.Drawing.Size(186, 20);
            this.txtSearchProv.TabIndex = 1;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // dgwProveedores
            // 
            this.dgwProveedores.AllowUserToAddRows = false;
            this.dgwProveedores.AllowUserToDeleteRows = false;
            this.dgwProveedores.AllowUserToOrderColumns = true;
            this.dgwProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgwProveedores.Location = new System.Drawing.Point(16, 87);
            this.dgwProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgwProveedores.MultiSelect = false;
            this.dgwProveedores.Name = "dgwProveedores";
            this.dgwProveedores.ReadOnly = true;
            this.dgwProveedores.RowTemplate.Height = 24;
            this.dgwProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProveedores.Size = new System.Drawing.Size(590, 215);
            this.dgwProveedores.TabIndex = 7;
            this.dgwProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProveedores_CellContentClick);
            this.dgwProveedores.DoubleClick += new System.EventHandler(this.dgwProveedores_DoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblAviso);
            this.tabPage1.Controls.Add(this.dgwProveedores);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.chkDelete);
            this.tabPage1.Controls.Add(this.btnDeleteProv);
            this.tabPage1.Controls.Add(this.btnSearchProv);
            this.tabPage1.Controls.Add(this.txtSearchProv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(623, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProv
            // 
            this.btnDeleteProv.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProv.Location = new System.Drawing.Point(515, 23);
            this.btnDeleteProv.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProv.Name = "btnDeleteProv";
            this.btnDeleteProv.Size = new System.Drawing.Size(81, 28);
            this.btnDeleteProv.TabIndex = 3;
            this.btnDeleteProv.Text = "&Eliminar";
            this.btnDeleteProv.UseVisualStyleBackColor = false;
            this.btnDeleteProv.Click += new System.EventHandler(this.btnDeleteProv_Click);
            // 
            // btnSearchProv
            // 
            this.btnSearchProv.BackColor = System.Drawing.Color.Silver;
            this.btnSearchProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchProv.Location = new System.Drawing.Point(426, 23);
            this.btnSearchProv.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchProv.Name = "btnSearchProv";
            this.btnSearchProv.Size = new System.Drawing.Size(79, 28);
            this.btnSearchProv.TabIndex = 2;
            this.btnSearchProv.Text = "&Buscar";
            this.btnSearchProv.UseVisualStyleBackColor = false;
            this.btnSearchProv.Click += new System.EventHandler(this.btnSearchProv_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 67);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 343);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbProveedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(623, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proveedores";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(21, 31);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(147, 13);
            this.lblAviso.TabIndex = 8;
            this.lblAviso.Text = "Busca Nombre-Departamento";
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 419);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:. Mantenimiento de Proveedores .:.";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProveedores)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgwProveedores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Button btnDeleteProv;
        private System.Windows.Forms.Button btnSearchProv;
        private System.Windows.Forms.TextBox txtSearchProv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.Button btnCancelProv;
        private System.Windows.Forms.Button btnEditProv;
        private System.Windows.Forms.Button btnSaveProv;
        private System.Windows.Forms.Button btnNewProv;
        private System.Windows.Forms.TextBox txtProv_Nom;
        private System.Windows.Forms.TextBox txtProv_Id;
        private System.Windows.Forms.Label lblProv_Dom;
        private System.Windows.Forms.Label lblProv_Nom;
        private System.Windows.Forms.Label lblProv_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.TextBox txtProv_Dom;
        private System.Windows.Forms.TextBox txtProv_Dep;
        private System.Windows.Forms.Label lblProv_Dep;
        private System.Windows.Forms.TextBox txtProv_Mail;
        private System.Windows.Forms.Label lblProv_Mail;
        private System.Windows.Forms.TextBox txtProv_CP;
        private System.Windows.Forms.Label lblProv_CP;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblProv_Tel;
        private System.Windows.Forms.Label lblAviso;
    }
}