using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseConexion;
using ClasesBase;

namespace Vistas
{
    public partial class FrmUsuario : Form
    {
        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNuevo = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsEditar = false;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        //Mensajes
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Procedimientos de Acciones
        private void Limpiar()
        {
            this.txtUsr_ID.Text = string.Empty;
            this.txtUsr_Nom.Text = string.Empty;
            this.txtUsr_Ape.Text = string.Empty;
            this.txtUsr_Mail.Text = string.Empty;
            this.txtUsr_UsrName.Text = string.Empty;
            this.txtUsr_Pass.Text = string.Empty;
            this.cmbRol_ID.DataSource = null;
        }
        private void Habilitar(bool Valor)
        {
            this.txtUsr_Nom.ReadOnly = !Valor;
            this.txtUsr_Ape.ReadOnly = !Valor;
            this.txtUsr_Mail.ReadOnly = !Valor;
            this.txtUsr_UsrName.ReadOnly = !Valor;
            this.txtUsr_Pass.ReadOnly = !Valor;
            this.cmbRol_ID.Enabled = Valor;
        }
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNewUsr.Enabled = false;
                this.btnSaveUsr.Enabled = true;
                this.btnEditUsr.Enabled = false;
                this.btnCancelUsr.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNewUsr.Enabled = true;
                this.btnSaveUsr.Enabled = false;
                this.btnEditUsr.Enabled = true;
                this.btnCancelUsr.Enabled = false;
            }
        }
        private void OcultarColumnas()
        {
            this.dgwUsuarios.Columns[0].Visible = false;
            this.dgwUsuarios.Columns[1].Visible = false;
        }
        private void Mostrar()
        {
            this.dgwUsuarios.DataSource = TrabajarUsuario.ViewUser();
            this.OcultarColumnas();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dgwUsuarios.Rows.Count);
        }
        private void LoadCmbRol()
        {
            cmbRol_ID.DisplayMember = "rol_descrip";
            cmbRol_ID.ValueMember = "rol_id";
            cmbRol_ID.DataSource = TrabajarUsuario.ViewRol();
        }
        private void LoadRol()
        {
            DataTable rolNuevo = TrabajarUsuario.ViewRol();
            DataRow row = rolNuevo.NewRow();
            row["rol_id"] = 0;
            row["rol_descrip"] = "<Seleccione valor...>";
            rolNuevo.Rows.InsertAt(row, 0);
            cmbRol_ID.DisplayMember = "rol_descrip";
            cmbRol_ID.ValueMember = "rol_id";
            cmbRol_ID.DataSource = rolNuevo;
        }

        //Botones Mantenimiento
        private void btnSaveUsr_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (validarCampos())
                {
                    if (this.IsNuevo)
                    {
                        //Vamos a insertar un Trabajador 
                        Rpta = TrabajarUsuario.InsertUser(Convert.ToInt32(cmbRol_ID.SelectedValue), this.txtUsr_Ape.Text.Trim(), this.txtUsr_Nom.Text.Trim(),
                            txtUsr_UsrName.Text, txtUsr_Pass.Text, txtUsr_Mail.Text);
                    }
                    else
                    {
                        //Vamos a modificar un Trabajador
                        Rpta = TrabajarUsuario.EditUser(Convert.ToInt32(this.txtUsr_ID.Text), this.txtUsr_Ape.Text.Trim(), this.txtUsr_Nom.Text.Trim(),
                            txtUsr_UsrName.Text, txtUsr_Pass.Text, txtUsr_Mail.Text, Convert.ToInt32(cmbRol_ID.SelectedValue));
                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOK("Se actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.txtUsr_ID.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

/**
 * Valida si los datos de los campos son correctos.
 * retorna True si lo estan y False si no
**/
        private Boolean validarCampos()
        {
            Boolean valido = true;
            errorIcono.Clear();

            if (this.txtUsr_Nom.Text == string.Empty)
            {
                errorIcono.SetError(txtUsr_Nom, "Ingrese un Valor");
                valido = false;
            }

            if (this.txtUsr_Ape.Text == string.Empty)
            {   
                valido = false;
                errorIcono.SetError(txtUsr_Ape, "Ingrese un Valor");
            }

            if (txtUsr_Mail.Text == string.Empty)
            {
                valido = false;
                errorIcono.SetError(txtUsr_Mail, "Ingrese un Valor");
            }

            if(txtUsr_UsrName.Text == string.Empty)
            {
                valido = false;
                errorIcono.SetError(txtUsr_UsrName, "Ingrese un Valor");
            }

            if (txtUsr_Pass.Text == string.Empty)
	        {
                valido = false;
		        errorIcono.SetError(txtUsr_Pass, "Ingrese un Valor");
        	}
            
            if ((int)cmbRol_ID.SelectedValue == 0)
            {
                errorIcono.SetError(cmbRol_ID, "Seleccione un Valor");
            }

            if (!valido)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
            }

            return valido;
        }

        private void btnNewUsr_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.LoadRol();
            this.txtUsr_Nom.Focus();
        }
        private void btnEditUsr_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un producto no puede modificar
            if (!this.txtUsr_ID.Text.Equals(""))
            {
                string sNombreRol=cmbRol_ID.Text;
                this.IsEditar = true;
                this.Botones();
                this.LoadCmbRol();
                this.cmbRol_ID.Text = sNombreRol;
            }
            else
            {
                this.MensajeError("Debe de buscar un registro para Modificar");
            }
        }
        private void btnCancelUsr_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtUsr_ID.Text = string.Empty;
        }
        
        //Botones Listado
        private void btnSearchUsr_Click(object sender, EventArgs e)
        {
            if (txtSearchUsr.Text != "")
            {
                dgwUsuarios.DataSource = TrabajarUsuario.SearchUser(txtSearchUsr.Text);
                OcultarColumnas();
            }
            else
            {
                Mostrar();
            }
            lblTotal.Text = "Total Registros: " + Convert.ToString(dgwUsuarios.Rows.Count);
        }
        private void btnDeleteUsr_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgwUsuarios.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = TrabajarUsuario.DeleteUser(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                this.dgwUsuarios.Columns[0].Visible = true;
            }
            else
            {
                this.dgwUsuarios.Columns[0].Visible = false;
            }
        }
        private void dgwUsuarios_DoubleClick(object sender, EventArgs e)
        {
            this.txtUsr_ID.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["usr_id"].Value);
            this.txtUsr_Nom.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Nombre"].Value);
            this.txtUsr_Ape.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Apellido"].Value);
            this.txtUsr_Mail.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Email"].Value);
            this.txtUsr_UsrName.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Usuario"].Value);
            this.txtUsr_Pass.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Contraseña"].Value);
            this.cmbRol_ID.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Rol"].Value);
            
            this.tabControl1.SelectedIndex = 1;
        }
        private void dgwUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwUsuarios.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dgwUsuarios.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
    }
}