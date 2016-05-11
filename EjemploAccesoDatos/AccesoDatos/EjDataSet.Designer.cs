namespace AccesoDatos
{
    partial class EjDataSet
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
            this.btnCargarGrilla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAlumnos
            // 
            this.grdAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlumnos.Location = new System.Drawing.Point(7, 12);
            this.grdAlumnos.Name = "grdAlumnos";
            this.grdAlumnos.Size = new System.Drawing.Size(363, 150);
            this.grdAlumnos.TabIndex = 6;
            // 
            // btnCargarGrilla
            // 
            this.btnCargarGrilla.Location = new System.Drawing.Point(295, 191);
            this.btnCargarGrilla.Name = "btnCargarGrilla";
            this.btnCargarGrilla.Size = new System.Drawing.Size(75, 23);
            this.btnCargarGrilla.TabIndex = 7;
            this.btnCargarGrilla.Text = "Cargar Grilla";
            this.btnCargarGrilla.UseVisualStyleBackColor = true;
            this.btnCargarGrilla.Click += new System.EventHandler(this.btnCargarGrilla_Click);
            // 
            // EjDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 262);
            this.Controls.Add(this.btnCargarGrilla);
            this.Controls.Add(this.grdAlumnos);
            this.Name = "EjDataSet";
            this.Text = "Ejemplo DataSet";
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAlumnos;
        private System.Windows.Forms.Button btnCargarGrilla;
    }
}