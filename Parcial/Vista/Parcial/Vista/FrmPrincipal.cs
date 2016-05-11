using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            LoadLocatario();
            LoadInmueble();
            LoadCuotas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Mensajes utilizados para interactuar con el Usuario
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parcial", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parcial", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearFields()
        {
            errorIcono.Clear();
            this.txtCuotas.Text = string.Empty;
            this.dtFecha.Value = DateTime.Now;
            this.cmbLocatario.SelectedValue = 0;
            this.cmbInmueble.SelectedValue = 0;
            cmbLocatario.Focus();
        }
        private void ListCuotas(int id)
        {
            this.dgwCuotas.DataSource = TrabajarAlquiler.ListCuotas(id);
            lblTotal.Text = "Total Registros: " + Convert.ToString(dgwCuotas.Rows.Count);
        }
        private void LoadCuotas()
        {
            DataTable dtTabla = TrabajarInmueble.ListInmuebles();
            DataRow row = dtTabla.NewRow();
            row["codinmueble"] = 0;
            row["Inmueble"] = "<Seleccione valor...>";
            dtTabla.Rows.InsertAt(row, 0);
            cmbCuotas.DisplayMember = "Inmueble";
            cmbCuotas.ValueMember = "codinmueble";
            cmbCuotas.DataSource = dtTabla;
        }
        private void LoadLocatario()
        {
            DataTable dtTabla = TrabajarLocatario.ListLocatarios();
            DataRow row = dtTabla.NewRow();
            row["dni"] = 0;
            row["Locatario"] = "<Seleccione valor...>";
            dtTabla.Rows.InsertAt(row, 0);
            cmbLocatario.DisplayMember = "Locatario";
            cmbLocatario.ValueMember = "dni";
            cmbLocatario.DataSource = dtTabla;
        }
        private void LoadInmueble()
        {
            DataTable dtTabla = TrabajarInmueble.ListInmueble();
            DataRow row = dtTabla.NewRow();
            row["codinmueble"] = 0;
            row["Inmueble"] = "<Seleccione valor...>";
            dtTabla.Rows.InsertAt(row, 0);
            cmbInmueble.DisplayMember = "Inmueble";
            cmbInmueble.ValueMember = "codinmueble";
            cmbInmueble.DataSource = dtTabla;
        }
        private Boolean ValidateFields()
        {
            Boolean bValid = true;
            errorIcono.Clear();

            if (Convert.ToInt32(this.cmbLocatario.SelectedValue) == 0)
            {
                errorIcono.SetError(cmbLocatario, "Elija un Locatario");
                bValid = false;
            }
            if (Convert.ToInt32(this.cmbInmueble.SelectedValue) == 0)
            {
                bValid = false;
                errorIcono.SetError(cmbInmueble, "Elija un Inmueble");
            }
            if (txtCuotas.Text == string.Empty)
            {
                bValid = false;
                errorIcono.SetError(txtCuotas, "Ingrese un Valor");
            }
            if (!bValid)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
            }

            return bValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
              string Rpta = "";
              if (ValidateFields())
                {
                    Alquiler oAlq = new Alquiler();
                    oAlq.Cliente = Convert.ToInt32(cmbLocatario.SelectedValue);
                    oAlq.Inmueble = Convert.ToInt32(cmbInmueble.SelectedValue);
                    oAlq.Fecha_alquiler = dtFecha.Value;
                    oAlq.Cuotas = Convert.ToInt32(txtCuotas.Text.Trim());
                  
                        Rpta = TrabajarAlquiler.InsertAlquiler(oAlq);
                    if (Rpta.Equals("OK"))
                    {
                            this.MensajeOK("Se insertó de forma correcta el registro");
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                    this.LoadCuotas();
                    this.LoadInmueble();
                    this.ClearFields();
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                errorIcono.Clear();
                e.Handled=false;
            }
            else
            {
                errorIcono.SetError(txtCuotas,"Solo numeros");
                e.Handled=true;
            }
        }

        private void cmbCuotas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbCuotas.SelectedValue) != 0)
            {
                DataTable tabla = TrabajarAlquiler.GetContrato(Convert.ToInt32(cmbCuotas.SelectedValue));
                txtContrato.Text = tabla.Rows[0][0].ToString();
                ListCuotas(Convert.ToInt32(txtContrato.Text));
            }
            else
            {
                dgwCuotas.DataSource = null;
                lblTotal.Text = "";
            }
        }
    }
}
