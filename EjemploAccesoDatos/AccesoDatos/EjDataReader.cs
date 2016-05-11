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
    public partial class EjDataReader : Form
    {
        public EjDataReader()
        {
            InitializeComponent();
        }


        private void EjDataReader_Load(object sender, EventArgs e)
        {
            //Realizar la conexión a la Base de Datos
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename='G:\\Fabiana\\Work\\UNJU\\2016\\LPOO I\\Clases Teóricas\\Clase 3\\Ejemplos en VS\\EjemploAccesoDatos\\SistemaAlumnosDB.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");

            //Crear el comando
            SqlCommand cmd = new SqlCommand("SELECT * FROM ALUMNOS", cn);

            //Crear el DataReader
            SqlDataReader dr;

            //Abrir la Conexión
            cn.Open();

            //Cargar el DataReader con el resultado de la Consulta
            dr = cmd.ExecuteReader();

            //Cargar el control (comboBox) con el contenido del DataReader
            while (dr.Read())
            {
                cmbAlumnos.Items.Add(dr["ALU_Nombre"]);
            }

            //Cerrar el DataReader
            dr.Close();

            //Cerrar la Conexión a la DB
            cn.Close();
        }

        private void cmbAlumnos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtNombre.Text = cmbAlumnos.SelectedItem.ToString();
            txtNombre.Refresh();
        }





    }
}
