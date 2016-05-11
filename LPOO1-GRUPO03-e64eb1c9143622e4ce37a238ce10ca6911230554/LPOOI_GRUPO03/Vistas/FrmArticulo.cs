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
    public partial class FrmArticulo : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        
        //Procedimientos
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
            this.txtArt_ID.Text = string.Empty;
            this.txtArt_Descrip.Text = string.Empty;
            this.txtArt_Costo.Text = string.Empty;
            this.txtArt_Precio.Text = string.Empty;
            this.txtArt_SA.Text = string.Empty;
            this.txtArt_SMax.Text = string.Empty;
            this.txtArt_SMin.Text = string.Empty;
            this.txtArt_SR.Text = string.Empty;
            this.rbYes.Checked = false;
            this.rbNo.Checked = false;
        }
        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtArt_Descrip.ReadOnly = !valor;
            this.txtArt_SMin.ReadOnly = !valor;
            this.txtArt_SMax.ReadOnly = !valor;
            this.cbArt_Fam.Enabled = valor;
            this.cbArt_UM.Enabled = valor;
            this.rbYes.Enabled = valor;
            this.rbNo.Enabled = valor;
            this.txtArt_Precio.ReadOnly = !valor;
            this.txtArt_Costo.ReadOnly = !valor;
            this.txtArt_MB.ReadOnly = !valor;
            this.txtArt_SR.Enabled = !valor;
            this.txtArt_SA.Enabled = !valor;
            
        }
        private void HabilitarEdit(bool valor)
        {
            this.txtArt_Descrip.ReadOnly = !valor;
            this.txtArt_SMin.ReadOnly = !valor;
            this.txtArt_SMax.ReadOnly = !valor;
            this.cbArt_Fam.Enabled = valor;
            this.cbArt_UM.Enabled = valor;
            this.rbYes.Enabled = valor;
            this.rbNo.Enabled = valor;
            this.txtArt_Precio.ReadOnly = !valor;
            this.txtArt_Costo.ReadOnly = !valor;
            this.txtArt_MB.ReadOnly = !valor;
            this.txtArt_SR.ReadOnly = !valor;
            this.txtArt_SA.ReadOnly = !valor;
        }
        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNewArt.Enabled = false;
                this.btnSaveArt.Enabled = true;
                this.btnEditArt.Enabled = false;
                this.btnCancelArt.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNewArt.Enabled = true;
                this.btnSaveArt.Enabled = false;
                this.btnEditArt.Enabled = true;
                this.btnCancelArt.Enabled = false;
            }
        }
        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dgwArticulo.Columns[0].Visible = false;
            this.dgwArticulo.Columns[1].Visible = false;
            this.dgwArticulo.Columns[5].Visible = false;
            this.dgwArticulo.Columns[6].Visible = false;
            this.dgwArticulo.Columns[7].Visible = false;
            this.dgwArticulo.Columns[10].Visible = false;
            this.dgwArticulo.Columns[13].Visible = false;
            this.dgwArticulo.Columns[14].Visible = false;
        }
        //Método Mostrar
        private void Mostrar()
        {
            this.dgwArticulo.DataSource = TrabajarArticulo.ViewArticles();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgwArticulo.Rows.Count);
        }
        //Permite que solo se ingrese decimal con 2 decimos
        private void IngDec(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;
            for (int i = 0; i < ((TextBox)sender).Text.Length; i++)
            {
                if (((TextBox)sender).Text[i] == ',')
                    IsDec = true;
                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 44)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
        //Calcula el Precio
        private void Calcular(object sender)
        {
            decimal precio = 0;
            if (((TextBox)sender).Text != "")
            {
                decimal dCambio = decimal.Parse(((TextBox)sender).Text);
                ((TextBox)sender).Text = dCambio.ToString("N2");
            }
            if (txtArt_Costo.Text != "" && txtArt_MB.Text != "")
            {
                precio = decimal.Parse(txtArt_Costo.Text) / (1 - (decimal.Parse(txtArt_MB.Text) / 100));
                txtArt_Precio.Text = precio.ToString("N2");
            }
            else
            {
                txtArt_Precio.Text = precio.ToString("N2");
            }
        }
        //Cargar ComboBoxes
        //Alta
        private void LoadArtFam()
        {
            DataTable newTable = TrabajarArticulo.ViewFamilia();
            DataRow row = newTable.NewRow();
            row["fam_id"] = 0;
            row["fam_descrip"] = "<Seleccione valor...>";
            newTable.Rows.InsertAt(row, 0);
            cbArt_Fam.DisplayMember = "fam_descrip";
            cbArt_Fam.ValueMember = "fam_id";
            cbArt_Fam.DataSource = newTable;
        }
        private void LoadArtUM()
        {
            DataTable newTable = TrabajarArticulo.ViewUM();
            DataRow row = newTable.NewRow();
            row["um_id"] = 0;
            row["um_descrip"] = "<Seleccione valor...>";
            newTable.Rows.InsertAt(row, 0);
            cbArt_UM.DisplayMember = "um_descrip";
            cbArt_UM.ValueMember = "um_id";
            cbArt_UM.DataSource = newTable;
        }
        //Modificacion
        private void LoadcbArtFam()
        {
            cbArt_Fam.DisplayMember = "fam_descrip";
            cbArt_Fam.ValueMember = "fam_id";
            cbArt_Fam.DataSource = TrabajarArticulo.ViewFamilia();
        }
        private void LoadcbArtUM()
        {
            cbArt_UM.DisplayMember = "um_descrip";
            cbArt_UM.ValueMember = "um_id";
            cbArt_UM.DataSource = TrabajarArticulo.ViewUM();
        }

        //Botones Mantenimiento
        private void btnNewArt_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.LoadArtFam();
            this.LoadArtUM();
            this.txtArt_Descrip.Focus();
        }
        private void btnSaveArt_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (validarCampos())
                {
                    if (this.IsNuevo)
                    {
                        decimal dValorInicial = 0;
                        rpta = TrabajarArticulo.InsertArt(txtArt_Descrip.Text, Convert.ToInt32(cbArt_Fam.SelectedValue),
                            Convert.ToInt32(cbArt_UM.SelectedValue), Convert.ToDecimal(txtArt_Costo.Text), Convert.ToDecimal(txtArt_MB.Text), Convert.ToDecimal(txtArt_Precio.Text), Convert.ToDecimal(txtArt_SMin.Text),
                            Convert.ToDecimal(txtArt_SMax.Text), dValorInicial, dValorInicial, rbYes.Checked);
                    }
                    else
                    {
                        rpta = TrabajarArticulo.EditArt(Convert.ToInt32(txtArt_ID.Text), txtArt_Descrip.Text, Convert.ToInt32(cbArt_Fam.SelectedValue),
                            Convert.ToInt32(cbArt_UM.SelectedValue), Convert.ToDecimal(txtArt_Costo.Text), Convert.ToDecimal(txtArt_MB.Text),
                            Convert.ToDecimal(txtArt_Precio.Text), Convert.ToDecimal(txtArt_SMin.Text), Convert.ToDecimal(txtArt_SMax.Text),
                            Convert.ToDecimal(txtArt_SR.Text), Convert.ToDecimal(txtArt_SA.Text), rbYes.Checked);
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
                else
                {
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


/******************************************************
 * Valida si los datos de los campos son correctos.
 * retorna True si lo estan y False si no
 *******************************************************/
        private Boolean validarCampos()
        {
            Boolean valido = true;
            errorIcono.Clear();
            if (this.txtArt_Descrip.Text == string.Empty)
            {
                errorIcono.SetError(txtArt_Descrip, "Ingrese un Valor");
                valido = false;
            }

            if(this.txtArt_SMin.Text == string.Empty)
            {
                errorIcono.SetError(txtArt_SMin, "Ingrese un Valor");
                valido = false;
                
            }

            if(this.txtArt_SMax.Text == string.Empty)
            {
                errorIcono.SetError(txtArt_SMax, "Ingrese un Valor");
                valido = false;
            }
            if (this.txtArt_Costo.Text == string.Empty)
            {
                errorIcono.SetError(txtArt_Costo, "Ingrese un Valor");
                valido = false;
            }
            if (this.txtArt_MB.Text == string.Empty)
            {
                errorIcono.SetError(txtArt_MB, "Ingrese un Valor");
                valido = false;
            }

            if ((int)cbArt_Fam.SelectedValue == 0)
            {
                errorIcono.SetError(cbArt_Fam, "Seleccione valor");
                valido = false;
            }

            if ((int)cbArt_UM.SelectedValue == 0)
            {
                 errorIcono.SetError(cbArt_UM, "Seleccione valor");
                 valido = false;
            }

            if ((rbYes.Checked = false) && (rbNo.Checked = false))
            {
                errorIcono.SetError(rbNo, "Selecione opción");
                valido = false;
            }

            if(!valido)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
            }

            return valido;
        }
        private void btnEditArt_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();
            if (!this.txtArt_ID.Text.Equals(""))
            {
                string sNameFam = cbArt_Fam.Text;
                string sNameUM = cbArt_UM.Text;
                this.IsEditar = true;
                this.Botones();
                this.HabilitarEdit(true);
                this.LoadcbArtFam();
                this.LoadcbArtUM();
                this.cbArt_Fam.Text = sNameFam;
                this.cbArt_UM.Text = sNameUM;
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }
        private void btnCancelArt_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        //Botones Listado
        private void btnDeleteArt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgwArticulo.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = TrabajarArticulo.DeleteArt(Convert.ToInt32(Codigo));

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
        private void btnSearchArt_Click(object sender, EventArgs e)
        {
            if (txtSearchArt.Text != "")
            {
                dgwArticulo.DataSource = TrabajarUsuario.SearchUser(txtSearchArt.Text);
                OcultarColumnas();
            }
            else
            {
                Mostrar();
            }
            lblTotal.Text = "Total Registros: " + Convert.ToString(dgwArticulo.Rows.Count);
        }
        private void dgwArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwArticulo.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgwArticulo.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
        private void dgwArticulo_DoubleClick(object sender, EventArgs e)
        {
            this.txtArt_ID.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["ID"].Value);
            this.txtArt_Descrip.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Descripcion"].Value);
            this.cbArt_Fam.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Familia"].Value);
            this.cbArt_UM.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Unidad de Medida"].Value);
            this.txtArt_Costo.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Costo"].Value);
            this.txtArt_MB.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Margen de Beneficio"].Value);
            this.txtArt_Precio.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Precio"].Value);
            this.txtArt_SMin.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Stock Min."].Value);
            this.txtArt_SMax.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Stock Max."].Value);
            this.txtArt_SR.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Stock Reposicion"].Value);
            this.txtArt_SA.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Stock Actual"].Value);
            if (Convert.ToBoolean(this.dgwArticulo.CurrentRow.Cells["Maneja Stock"].Value))
            {
                this.rbYes.Checked = Convert.ToBoolean(this.dgwArticulo.CurrentRow.Cells["Maneja Stock"].Value);
            }
            else
            {
                this.rbNo.Checked = Convert.ToBoolean(this.dgwArticulo.CurrentRow.Cells["Maneja Stock"].Value);
            }

            this.tabControl1.SelectedIndex = 1;
        }
        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                this.dgwArticulo.Columns[0].Visible = true;
            }
            else
            {
                this.dgwArticulo.Columns[0].Visible = false;
            }
        }

        private void txtArt_Costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngDec(sender, e);
        }
        private void txtArt_MB_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngDec(sender, e);
        }
        private void txtArt_Costo_Leave(object sender, EventArgs e)
        {
            Calcular(sender);
        }
        private void txtArt_MB_Leave(object sender, EventArgs e)
        {
            Calcular(sender);
        }

    }
}
