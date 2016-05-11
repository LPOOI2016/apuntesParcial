namespace AccesoDatos
{
    partial class OtroEjDataSet
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
            this.grdAlumnos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLU = new System.Windows.Forms.TextBox();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAlumnos
            // 
            this.grdAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlumnos.Location = new System.Drawing.Point(19, 17);
            this.grdAlumnos.Name = "grdAlumnos";
            this.grdAlumnos.Size = new System.Drawing.Size(363, 150);
            this.grdAlumnos.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Obtiene LU Alumno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre Alumno:";
            // 
            // txtLU
            // 
            this.txtLU.Location = new System.Drawing.Point(125, 226);
            this.txtLU.Name = "txtLU";
            this.txtLU.Size = new System.Drawing.Size(100, 20);
            this.txtLU.TabIndex = 15;
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(125, 196);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(121, 21);
            this.cmbAlumnos.TabIndex = 14;
            this.cmbAlumnos.SelectionChangeCommitted += new System.EventHandler(this.cmbAlumnos_SelectionChangeCommitted);
            // 
            // OtroEjDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLU);
            this.Controls.Add(this.cmbAlumnos);
            this.Controls.Add(this.grdAlumnos);
            this.Name = "OtroEjDataSet";
            this.Text = "Otro Ejemplo DataSet";
            this.Load += new System.EventHandler(this.OtroEjDataSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAlumnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLU;
        private System.Windows.Forms.ComboBox cmbAlumnos;
    }
}