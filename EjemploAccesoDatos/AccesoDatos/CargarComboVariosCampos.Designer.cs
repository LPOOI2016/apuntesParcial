namespace AccesoDatos
{
    partial class CargarComboVariosCampos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbApellido = new System.Windows.Forms.ComboBox();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.cmbNombreCompleto = new System.Windows.Forms.ComboBox();
            this.txtLU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo:";
            // 
            // cmbApellido
            // 
            this.cmbApellido.FormattingEnabled = true;
            this.cmbApellido.Location = new System.Drawing.Point(151, 40);
            this.cmbApellido.Name = "cmbApellido";
            this.cmbApellido.Size = new System.Drawing.Size(209, 21);
            this.cmbApellido.TabIndex = 1;
            // 
            // cmbNombre
            // 
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(151, 76);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(209, 21);
            this.cmbNombre.TabIndex = 2;
            // 
            // cmbNombreCompleto
            // 
            this.cmbNombreCompleto.FormattingEnabled = true;
            this.cmbNombreCompleto.Location = new System.Drawing.Point(151, 112);
            this.cmbNombreCompleto.Name = "cmbNombreCompleto";
            this.cmbNombreCompleto.Size = new System.Drawing.Size(209, 21);
            this.cmbNombreCompleto.TabIndex = 3;
            this.cmbNombreCompleto.SelectionChangeCommitted += new System.EventHandler(this.cmbNombreCompleto_SelectionChangeCommitted);
            // 
            // txtLU
            // 
            this.txtLU.Location = new System.Drawing.Point(151, 159);
            this.txtLU.Name = "txtLU";
            this.txtLU.ReadOnly = true;
            this.txtLU.Size = new System.Drawing.Size(100, 20);
            this.txtLU.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "LU:";
            // 
            // CargarComboVariosCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 215);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLU);
            this.Controls.Add(this.cmbNombreCompleto);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.cmbApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CargarComboVariosCampos";
            this.Text = "Cargar ComboBox con Varios Campos";
            this.Load += new System.EventHandler(this.CargarComboVariosCampos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbApellido;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.ComboBox cmbNombreCompleto;
        private System.Windows.Forms.TextBox txtLU;
        private System.Windows.Forms.Label label4;
    }
}