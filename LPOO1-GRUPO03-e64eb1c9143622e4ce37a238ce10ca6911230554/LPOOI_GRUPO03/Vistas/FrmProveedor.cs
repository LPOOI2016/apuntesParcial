using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseConexion;

namespace Vistas
{
    public partial class FrmProveedor : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtProv_Nom.Text = string.Empty;
            this.txtProv_Dep.Text = string.Empty;
            this.txtProv_Dom.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtProv_CP.Text = string.Empty;
            this.txtProv_Mail.Text = string.Empty;
            this.txtProv_Id.Text = string.Empty;

        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtProv_Nom.ReadOnly = !valor;
            this.txtProv_Dom.ReadOnly = !valor;
            this.txtProv_Dep.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtProv_CP.ReadOnly = !valor;
            this.txtProv_Mail.ReadOnly = !valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNewProv.Enabled = false;
                this.btnSaveProv.Enabled = true;
                this.btnEditProv.Enabled = false;
                this.btnCancelProv.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNewProv.Enabled = true;
                this.btnSaveProv.Enabled = false;
                this.btnEditProv.Enabled = true;
                this.btnCancelProv.Enabled = false;
            }

        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dgwProveedores.Columns[0].Visible = false;
            this.dgwProveedores.Columns[1].Visible = false;
        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dgwProveedores.DataSource = TrabajarProveedor.ViewProvider();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgwProveedores.Rows.Count);
        }
        
        private void btnSearchProv_Click(object sender, EventArgs e)
        {
            if (txtSearchProv.Text != "")
            {
                dgwProveedores.DataSource = TrabajarUsuario.SearchUser(txtSearchProv.Text);
                OcultarColumnas();
            }
            else
            {
                Mostrar();
            }
            lblTotal.Text = "Total Registros: " + Convert.ToString(dgwProveedores.Rows.Count);
        }
        private void btnDeleteProv_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgwProveedores.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = TrabajarProveedor.DeleteProvider(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente el registro");
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

        private void btnNewProv_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtProv_Nom.Focus();
        }
        private void btnSaveProv_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtProv_Nom.Text == string.Empty || this.txtProv_Dom.Text == string.Empty
                    || this.txtProv_Mail.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtProv_Nom, "Ingrese un Valor");
                    errorIcono.SetError(txtProv_Dom, "Ingrese un Valor");
                    errorIcono.SetError(txtProv_Mail, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = TrabajarProveedor.InsertProvider(txtProv_Nom.Text.Trim(),txtProv_Dom.Text, txtProv_Dep.Text,
                            txtProv_CP.Text, txtTelefono.Text, txtProv_Mail.Text);

                    }
                    else
                    {
                        rpta = TrabajarProveedor.EditProvider(Convert.ToInt32(this.txtProv_Id.Text),txtProv_Nom.Text.Trim(),
                            txtProv_Dom.Text, txtProv_Dep.Text,txtProv_CP.Text, txtTelefono.Text, txtProv_Mail.Text);
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnEditProv_Click(object sender, EventArgs e)
        {
            if (!this.txtProv_Id.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }
        private void btnCancelProv_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtProv_Id.Text = string.Empty;
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                this.dgwProveedores.Columns[0].Visible = true;
            }
            else
            {
                this.dgwProveedores.Columns[0].Visible = false;
            }
        }

        private void dgwProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwProveedores.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgwProveedores.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dgwProveedores_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtProv_Nom.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["prov_nombre"].Value);
                this.txtProv_CP.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["prov_codigo_postal"].Value);
                this.txtProv_Dep.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["prov_departamento"].Value);
                this.txtProv_Dom.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["prov_domicilio"].Value);
                this.txtTelefono.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["prov_telefono"].Value);
                this.txtProv_Mail.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["prov_email"].Value);

                this.tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

    }
       
}
