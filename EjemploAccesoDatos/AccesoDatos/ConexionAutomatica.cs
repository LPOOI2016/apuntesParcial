using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccesoDatos
{
    public partial class ConexionAutomatica : Form
    {
        public ConexionAutomatica()
        {
            InitializeComponent();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alumnosDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.alumnosDataSet.Alumnos);
        }
    }
}
