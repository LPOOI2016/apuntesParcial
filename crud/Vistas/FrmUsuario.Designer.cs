namespace Vistas
{
    partial class FrmUsuario
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
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.cmbRol_Id = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsr_UserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsr_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsr_Nombre = new System.Windows.Forms.TextBox();
            this.txtUsr_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsr_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.dgwUsuarios = new System.Windows.Forms.DataGridView();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.cmbRol_Id);
            this.grpUsers.Controls.Add(this.label6);
            this.grpUsers.Controls.Add(this.txtUsr_UserName);
            this.grpUsers.Controls.Add(this.label5);
            this.grpUsers.Controls.Add(this.txtUsr_Email);
            this.grpUsers.Controls.Add(this.label4);
            this.grpUsers.Controls.Add(this.txtUsr_Nombre);
            this.grpUsers.Controls.Add(this.txtUsr_Apellido);
            this.grpUsers.Controls.Add(this.label3);
            this.grpUsers.Controls.Add(this.label2);
            this.grpUsers.Controls.Add(this.txtUsr_Password);
            this.grpUsers.Controls.Add(this.label1);
            this.grpUsers.Location = new System.Drawing.Point(558, 86);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(309, 249);
            this.grpUsers.TabIndex = 0;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "Datos del Usuario";
            // 
            // cmbRol_Id
            // 
            this.cmbRol_Id.FormattingEnabled = true;
            this.cmbRol_Id.Location = new System.Drawing.Point(108, 34);
            this.cmbRol_Id.Name = "cmbRol_Id";
            this.cmbRol_Id.Size = new System.Drawing.Size(168, 21);
            this.cmbRol_Id.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contraseña";
            // 
            // txtUsr_UserName
            // 
            this.txtUsr_UserName.Location = new System.Drawing.Point(108, 175);
            this.txtUsr_UserName.Name = "txtUsr_UserName";
            this.txtUsr_UserName.Size = new System.Drawing.Size(168, 20);
            this.txtUsr_UserName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Usuario";
            // 
            // txtUsr_Email
            // 
            this.txtUsr_Email.Location = new System.Drawing.Point(108, 139);
            this.txtUsr_Email.Name = "txtUsr_Email";
            this.txtUsr_Email.Size = new System.Drawing.Size(168, 20);
            this.txtUsr_Email.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txtUsr_Nombre
            // 
            this.txtUsr_Nombre.Location = new System.Drawing.Point(108, 106);
            this.txtUsr_Nombre.Name = "txtUsr_Nombre";
            this.txtUsr_Nombre.Size = new System.Drawing.Size(168, 20);
            this.txtUsr_Nombre.TabIndex = 5;
            // 
            // txtUsr_Apellido
            // 
            this.txtUsr_Apellido.Location = new System.Drawing.Point(108, 72);
            this.txtUsr_Apellido.Name = "txtUsr_Apellido";
            this.txtUsr_Apellido.Size = new System.Drawing.Size(168, 20);
            this.txtUsr_Apellido.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // txtUsr_Password
            // 
            this.txtUsr_Password.Location = new System.Drawing.Point(108, 205);
            this.txtUsr_Password.Name = "txtUsr_Password";
            this.txtUsr_Password.Size = new System.Drawing.Size(168, 20);
            this.txtUsr_Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(792, 352);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUser.TabIndex = 1;
            this.btnSaveUser.Text = "Guardar";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // dgwUsuarios
            // 
            this.dgwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuarios.Location = new System.Drawing.Point(27, 86);
            this.dgwUsuarios.Name = "dgwUsuarios";
            this.dgwUsuarios.Size = new System.Drawing.Size(516, 249);
            this.dgwUsuarios.TabIndex = 2;
            this.dgwUsuarios.CurrentCellChanged += new System.EventHandler(this.dgwUsuarios_CurrentCellChanged);
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(27, 37);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(406, 20);
            this.txtPattern.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(440, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 412);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.dgwUsuarios);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.grpUsers);
            this.Name = "FrmUsuario";
            this.Text = "ABM Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.grpUsers.ResumeLayout(false);
            this.grpUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.TextBox txtUsr_Nombre;
        private System.Windows.Forms.TextBox txtUsr_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsr_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRol_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsr_UserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsr_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.DataGridView dgwUsuarios;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button btnSearch;
    }
}