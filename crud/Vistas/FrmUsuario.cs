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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();

            oUser.Rol_Id = (int) cmbRol_Id.SelectedValue;
            oUser.Usr_Apellido = txtUsr_Apellido.Text;
            oUser.Usr_Nombre = txtUsr_Nombre.Text;
            oUser.Usr_Email = txtUsr_Email.Text;
            oUser.Usr_UserName = txtUsr_UserName.Text;
            oUser.Usr_Password = txtUsr_Password.Text;

            TrabajarUsuario.insert_usuario(oUser);

            load_usuarios();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();

            load_usuarios();
        }

        private void load_combo_roles() {

            cmbRol_Id.DisplayMember = "rol_descrip";
            cmbRol_Id.ValueMember = "rol_id";
            cmbRol_Id.DataSource = TrabajarUsuario.list_roles();

        }

        private void load_usuarios()
        {
            dgwUsuarios.DataSource = TrabajarUsuario.list_usuarios();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPattern.Text != "")
            {
                dgwUsuarios.DataSource = TrabajarUsuario.search_usuarios(txtPattern.Text);
            }
            else {
                load_usuarios();
            }
        }

        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if ( dgwUsuarios.CurrentRow !=null ) {

                cmbRol_Id.SelectedValue = dgwUsuarios.CurrentRow.Cells["rol_id"].Value.ToString();

                txtUsr_Apellido.Text= dgwUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                txtUsr_Nombre.Text = dgwUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtUsr_Email.Text = dgwUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                txtUsr_UserName.Text = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtUsr_Password.Text = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
            }


        }




    }
}
