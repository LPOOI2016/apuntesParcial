namespace AccesoDatos
{
    partial class ConexionAutomatica
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alumnosDataSet = new AccesoDatos.AlumnosDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new AccesoDatos.AlumnosDataSetTableAdapters.AlumnosTableAdapter();
            this.aLULUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLUNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLUDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aLULUDataGridViewTextBoxColumn,
            this.aLUNombreDataGridViewTextBoxColumn,
            this.aLUDireccionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alumnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // alumnosDataSet
            // 
            this.alumnosDataSet.DataSetName = "AlumnosDataSet";
            this.alumnosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.alumnosDataSet;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // aLULUDataGridViewTextBoxColumn
            // 
            this.aLULUDataGridViewTextBoxColumn.DataPropertyName = "ALU_LU";
            this.aLULUDataGridViewTextBoxColumn.HeaderText = "LU";
            this.aLULUDataGridViewTextBoxColumn.Name = "aLULUDataGridViewTextBoxColumn";
            this.aLULUDataGridViewTextBoxColumn.ReadOnly = true;
            this.aLULUDataGridViewTextBoxColumn.ToolTipText = "Libreta Universitaria";
            // 
            // aLUNombreDataGridViewTextBoxColumn
            // 
            this.aLUNombreDataGridViewTextBoxColumn.DataPropertyName = "ALU_Nombre";
            this.aLUNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.aLUNombreDataGridViewTextBoxColumn.Name = "aLUNombreDataGridViewTextBoxColumn";
            // 
            // aLUDireccionDataGridViewTextBoxColumn
            // 
            this.aLUDireccionDataGridViewTextBoxColumn.DataPropertyName = "ALU_Direccion";
            this.aLUDireccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.aLUDireccionDataGridViewTextBoxColumn.Name = "aLUDireccionDataGridViewTextBoxColumn";
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(282, 197);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 37);
            this.btnCargarDatos.TabIndex = 1;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // ConexionAutomatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 262);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConexionAutomatica";
            this.Text = "ConexionAutomatica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AlumnosDataSet alumnosDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private AlumnosDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLULUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLUNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLUDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCargarDatos;
    }
}