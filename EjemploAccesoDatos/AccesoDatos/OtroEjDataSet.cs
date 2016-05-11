using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public partial class OtroEjDataSet : Form
    {
        public OtroEjDataSet()
        {
            InitializeComponent();
        }

        private void OtroEjDataSet_Load(object sender, EventArgs e)
        {
            //Realizar la conexión a la Base de Datos
            SqlConnection cn = new SqlConnection(AccesoDatos.Properties.Settings.Default.DBSistemaAlumnos);

            //Crear el Comando
            SqlCommand cmd = new SqlCommand("SELECT * FROM Alumnos", cn);

            //Crear el DataAdapter y le pasamos el Comando SQLCommand que acabamos de crear
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Crear el DataSet
            DataSet ds = new DataSet();

            //Cargar el DataSet con el contenido del DataAdapter
            da.Fill(ds);

            //Asociar el DataSet a la grilla
            grdAlumnos.DataSource = ds.Tables[0];

            //Refrescar el contenido de la grilla
            grdAlumnos.Refresh();

            //Asociar el DataSet al ComboBox
            cmbAlumnos.DataSource = ds.Tables[0];
            cmbAlumnos.DisplayMember = "ALU_Nombre";
            cmbAlumnos.ValueMember = "ALU_LU";

            cmbAlumnos.Refresh();

        }

        private void cmbAlumnos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtLU.Text = cmbAlumnos.SelectedValue.ToString();
            txtLU.Refresh();
        }
    }
}
