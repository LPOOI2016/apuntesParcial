using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesConexion;
using ClasesBase;
namespace Vistas
{
    public partial class FormAlquiler : Form
    {
        public FormAlquiler()
        {
            InitializeComponent();
            loadLocatarios();
            loadInmuebles();
        }

        private void loadLocatarios()
        {
            DataTable locatarios= LocatarioADO.getLocatarios();
            cmbLocatario.DataSource = locatarios;
            locatarios.Columns.Add("NombreCompleto", typeof(String), "dni+'-'+apellido+'-'+nombre");
            cmbLocatario.DisplayMember = "NombreCompleto";
            cmbLocatario.ValueMember = "dni";
        }
        private void loadInmuebles()
        {
            DataTable Inmuebles = InmuebleADO.getAll();
            cmbInmueble.DataSource = Inmuebles;
            cmbInmueble.DisplayMember = "direccion";
            cmbInmueble.ValueMember = "codInmuebles";
        }
        private void FormAlquiler_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler(cmbLocatario.SelectedValue.ToString(),
                                             int.Parse(cmbInmueble.SelectedValue.ToString()),
                                             dtpFecha.Value,
                                             int.Parse(textBox1.Text));

            int idAlquiler = AlquilerADO.insert(alquiler);
            alquiler.NroContrato = idAlquiler;
            InmuebleADO.updateEstado(int.Parse(cmbInmueble.SelectedValue.ToString()), false);
            CuotasADO.generarCuotas(alquiler);

        }
    }
}
