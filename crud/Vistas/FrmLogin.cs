using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Boolean bUserFound = false;

            Usuario oUser1 = new Usuario("juan", "123");
            Usuario oUser2 = new Usuario("maria", "456");

            FrmMain oFrmMain = new FrmMain();

            if (oUser1.Usr_UserName == txtUserName.Text && oUser1.Usr_Password == txtPassword.Text)
            {
                bUserFound = true;
            }
            else if (oUser2.Usr_UserName == txtUserName.Text && oUser2.Usr_Password == txtPassword.Text)
            {
                bUserFound = true;
            }

            if (bUserFound)
            {
                MessageBox.Show("Bienvenido/a:: " + txtUserName.Text);

                oFrmMain.perfil = "administrador";
                oFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Datos de acceso incorrectos");
            }
        }

 
    }
}
