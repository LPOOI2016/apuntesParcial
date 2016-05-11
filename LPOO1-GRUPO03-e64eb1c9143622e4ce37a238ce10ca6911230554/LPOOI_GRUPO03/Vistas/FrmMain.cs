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
        public string sLogInApellido = Program.ssApellido;
        public string sLogInNombre = Program.ssNombre;
        public int nLogInRol = Program.snRol;
        public int nLogInUser= Program.snUser;
        private string sRol;

        public FrmMain()
        {
            InitializeComponent();
            msMenu.Renderer = new MyRenderer();
        }

        //Aspecto MenuStrip
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }
        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.Transparent; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.MistyRose; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Transparent; }
            }
            public override Color MenuItemBorder
            {
                get { return Color.Transparent; }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            AccessUser();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblUserLogin.Text = "Bienvenido: " + sLogInApellido +", "+sLogInNombre+"  ("+sRol+")";
            lblClock.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
        }

        //Acceso de Usuario
        private void AccessUser()
        {
            if (nLogInRol == 1)
            {
                sRol = "Administrador";
                tsmStock.Visible = true;
                tsmCompras.Visible = true;
                tsmProduccion.Visible = true;
                tsmVentas.Visible = true;
                tsmUsuarios.Visible = true;
            }
            if (nLogInRol == 2)
            {
                sRol = "Repositor";
                tsmStock.Visible = true;
            }
            if (nLogInRol == 3)
            {
                sRol = "Pastelero";
                tsmProduccion.Visible = true;
            }
            if (nLogInRol == 4)
            {
                sRol = "Comprador";
                tsmCompras.Visible = true;
            }
            if (nLogInRol == 5)
            {
                sRol = "Vendedor";
                tsmVentas.Visible = true;
            }
            if (nLogInRol == 6)
            {
                sRol = "Cajero";
                tsmCompras.Visible = true;
                tsmVentas.Visible = true;
            }
        }

        FrmCompra oComp;
        FrmArticulo oArt;
        FrmUsuario oUsuario;

        //Botones de Control
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea Salir?", "◄ AVISO | Grupo 03 ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void tsmLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea Cerrar Sesión?", "◄ AVISO | Grupo 03 ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        //Evento TSM Click
        private void tsmCompras_Click(object sender, EventArgs e)
        {
            CloseActiveForm();
            oComp = FrmCompra.GetInstancia();
            oComp.MdiParent = this;
            oComp.Show();
        }
        private void tsmStock_Click(object sender, EventArgs e)
        {
            CloseActiveForm();
            oArt = new FrmArticulo();
            oArt.MdiParent = this;
            oArt.Show();
        }
        private void tsmUsuarios_Click(object sender, EventArgs e)
        {
            CloseActiveForm();
            oUsuario = new FrmUsuario();
            oUsuario.MdiParent = this;
            oUsuario.Show();
        }

        //Procedimiento de Cierre de Formulario
        private void CloseActiveForm()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        //Efecto de Imagenes de los TSM
        private void tsmStock_MouseEnter(object sender, EventArgs e)
        {
            tsmStock.Image = Properties.Resources.stock2;
        }
        private void tsmStock_MouseLeave(object sender, EventArgs e)
        {
            tsmStock.Image = Properties.Resources.stock1;
        }

        private void tsmCompras_MouseEnter(object sender, EventArgs e)
        {
            tsmCompras.Image = Properties.Resources.buy2;
        }
        private void tsmCompras_MouseLeave(object sender, EventArgs e)
        {
            tsmCompras.Image = Properties.Resources.buy1;
        }

        private void tsmProduccion_MouseEnter(object sender, EventArgs e)
        {
            tsmProduccion.Image = Properties.Resources.product2;
        }
        private void tsmProduccion_MouseLeave(object sender, EventArgs e)
        {
            tsmProduccion.Image = Properties.Resources.product1;
        }

        private void tsmVentas_MouseEnter(object sender, EventArgs e)
        {
            tsmVentas.Image = Properties.Resources.sell2;
        }
        private void tsmVentas_MouseLeave(object sender, EventArgs e)
        {
            tsmVentas.Image = Properties.Resources.sell1;
        }

        private void tsmUsuarios_MouseEnter(object sender, EventArgs e)
        {
            tsmUsuarios.Image = Properties.Resources.user2;
        }
        private void tsmUsuarios_MouseLeave(object sender, EventArgs e)
        {
            tsmUsuarios.Image = Properties.Resources.user1;
        }

        private void tsmLogOut_MouseEnter(object sender, EventArgs e)
        {
            tsmLogOut.Image = Properties.Resources.logout2;
        }
        private void tsmLogOut_MouseLeave(object sender, EventArgs e)
        {
            tsmLogOut.Image = Properties.Resources.logout1;
        }
    }
}
