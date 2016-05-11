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
    public partial class CargarComboVariosCampos : Form
    {
        public CargarComboVariosCampos()
        {
            InitializeComponent();
        }

        private void CargarComboVariosCampos_Load(object sender, EventArgs e)
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

            //Asociar el DataSet al ComboBox Apellido
            cmbApellido.DataSource = ds.Tables[0];
            cmbApellido.DisplayMember = "ALU_Apellido";
            //cmbApellido.ValueMember = "ALU_Apellido";

            cmbApellido.Refresh();

            //Asociar el DataSet al ComboBox Nombre
            cmbNombre.DataSource = ds.Tables[0];
            cmbNombre.DisplayMember = "ALU_Nombre";
            //cmbNombre.ValueMember = "ALU_Nombre";

            cmbNombre.Refresh();


            //Modificar y asociar el DataSet al ComboBox NombreCompleto
            ds.Tables[0].Columns.Add("NombreCompleto", typeof(string), "ALU_Apellido +', ' +ALU_Nombre");
            cmbNombreCompleto.DataSource = ds.Tables[0];
            cmbNombreCompleto.DisplayMember = "NombreCompleto";
            cmbNombreCompleto.ValueMember = "ALU_LU";

            cmbNombreCompleto.Refresh();
        }

        private void cmbNombreCompleto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtLU.Text = cmbNombreCompleto.SelectedValue.ToString();
            txtLU.Refresh();
        }
    }
}
