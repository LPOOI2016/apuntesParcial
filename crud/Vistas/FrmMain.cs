using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        public string perfil = "";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Perfil:: " + perfil);
        }
    }
}
