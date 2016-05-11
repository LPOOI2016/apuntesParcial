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
    public partial class FrmCompra : Form
    {
        private bool IsNuevo;

        private Orden_Compra ordenCompra= new Orden_Compra();
        private BindingList<Item_Orden_Compra> listaDetalles ;
        private int itemID;
        private Decimal total;
        private Decimal subTotal;
        private int idArtSeleccionado ;

        private static FrmCompra _instancia;

        public static FrmCompra GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmCompra();
            }
            return _instancia;
        }
        private void FrmCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        public void setArticulo(DataGridViewRow rowArtSelecionado)
        {
            idArtSeleccionado = Convert.ToInt32(rowArtSelecionado.Cells["ID"].Value);
            this.txtArt_Descrip.Text = Convert.ToString(rowArtSelecionado.Cells["Descripcion"].Value);
            this.txtArt_Costo.Text = Convert.ToString(rowArtSelecionado.Cells["Costo"].Value);
            txtCantidad.Text = "1";
        }

        public FrmCompra()
        {
            InitializeComponent();
            disableFormOrdenCompra();
            Mostrar();

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
        
        private void limpiarDetalle()
        {
            dgvDetallesItems.DataSource = new BindingList<Item_Orden_Compra>();
            this.txtArt_Descrip.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.txtArt_Costo.Text = string.Empty;
            lblTotal_Pagado.Text = "0.0";
            errorIcono.Clear();
        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtOc_ID.ReadOnly = !valor;
            this.dtOc_Fecha.Enabled = valor;
            this.txtCantidad.ReadOnly = !valor;
            this.txtArt_Costo.ReadOnly = !valor;

            this.btnSearchArt.Enabled = valor;
            this.btnAdd.Enabled = valor;
            this.btnRemove.Enabled = valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNewOC.Enabled = false;
                this.btnSaveOC.Enabled = true;
                this.btnCancelOC.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNewOC.Enabled = true;
                this.btnSaveOC.Enabled = false;
                this.btnCancelOC.Enabled = false;
            }

        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = TrabajarOrden.ViewOrden();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void MostrarDetalle()
        {
            this.dgvDetallesItems.DataSource = TrabajarOrden.ViewItem(Convert.ToInt32(this.txtOc_ID.Text));
        }

        private void LoadCmbRol()
        {
            DataTable rolNuevo = TrabajarProveedor.ViewProvider();
            DataRow row = rolNuevo.NewRow();
            row["prov_id"] = 0;
            row["prov_nombre"] = "<Seleccione uno...>";
            rolNuevo.Rows.InsertAt(row, 0);
            cmbProv_ID.DisplayMember = "prov_nombre";
            cmbProv_ID.ValueMember = "prov_id";
            cmbProv_ID.DataSource = rolNuevo;
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            //this.crearTabla();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            FrmVistaArticulo vista = new FrmVistaArticulo();
            vista.ShowDialog();
        }


        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.Botones();

            this.Habilitar(false);
            this.limpiarDetalle();
            disableFormOrdenCompra();
        }

/*Habilita textBox del Formulario*/
        private void enableFormOrdenCompra()
        {
            txtArt_Costo.Enabled = true;
            txtCantidad.Enabled = true;
            dtOc_Fecha.Enabled = true;
            rbNo.Enabled = true;
            rbYes.Enabled = true;
            cmbProv_ID.Enabled = true;
            btnSearchArt.Enabled = true;
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            btnSaveOC.Enabled = true;
            btnCancelOC.Enabled = true;
            btnNewOC.Enabled = false;
        }
/*deshabilita textBox del Formulario*/
        private void disableFormOrdenCompra()
        {
            txtArt_Costo.Enabled = false;
            txtCantidad.Enabled = false;
            dtOc_Fecha.Enabled = false;
            rbNo.Enabled = false;
            rbYes.Enabled = false;
            cmbProv_ID.Enabled = false;
            txtOc_ID.Enabled = false;
            btnSearchArt.Enabled = false;
            txtArt_Descrip.Enabled = false;
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            btnSaveOC.Enabled = false;
            btnCancelOC.Enabled = false;
            btnNewOC.Enabled = true;

        }


/*  EVENTO DEL BOTON NUEVO
 * habilita el formulario y crea una nueva orden de compra vacia
 */
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            enableFormOrdenCompra();

            ordenCompra = new Orden_Compra();
            ordenCompra.Oc_ID = TrabajarOrden.getUltimoId() + 1;
            txtOc_ID.Text = Convert.ToString(ordenCompra.Oc_ID);

            listaDetalles = new BindingList<Item_Orden_Compra>();
            dgvDetallesItems.DataSource = listaDetalles;


            this.IsNuevo = true;
            this.Botones();

            this.Habilitar(true);
            this.LoadCmbRol();
            this.cmbProv_ID.Focus();

        }


/*  Valida si los Campos de Orden de Compra son correctos
* devuelve True si son correctos y falso si son incorrectos
*/
        public Boolean validarCamposOrdenCompra()
        {
            try
            {
                errorIcono.Clear();
                Boolean isValido = true;
                if (cmbProv_ID.SelectedIndex <= 0)
                {
                    isValido = false;
                    errorIcono.SetError(cmbProv_ID, "seleccione un proveedor");
                }

                if (!rbNo.Checked && !rbYes.Checked)
                {
                    isValido = false;
                    errorIcono.SetError(rbNo, "seleccione un estado para la orden");
                }

                if (dtOc_Fecha.Text == String.Empty)
                {
                    isValido = false;
                    errorIcono.SetError(dtOc_Fecha, "seleccione una Fecha");
                }

                

                if (!isValido)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                }
                return isValido;
            }
            catch (Exception ex)
            {
                MensajeError("los datos son incorrectos");
                Console.WriteLine(ex);
                return false;
            }
        }

/*  Valida si los Campos ingresados del formulario al insertar un articulo a la orden de compra
* devuelve True si son correctos y falso si son incorrectos
*/
        public Boolean validarCamposArticulo()
        {
            try
            {
                errorIcono.Clear();
                Boolean isValido = true;
                if (this.txtCantidad.Text == string.Empty)
                {
                    isValido = false;
                    errorIcono.SetError(txtCantidad, "Ingrese un Valor");
                }
                if (this.txtArt_Costo.Text == string.Empty)
                {
                    isValido = false;
                    errorIcono.SetError(txtArt_Costo, "Ingrese un Valor");
                }

                if (!isValido)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                }
                return isValido;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

/* EVENTO DEL BOTON AGREGAR ITEM 
 * agrega un el articulo seleccionado a la orden de compra */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCamposArticulo())
            {
                Boolean repetido = false;
                for (int i = 0; i < listaDetalles.Count && !repetido ; i++)
                {
                    if (listaDetalles[i].Art_ID == idArtSeleccionado)
                    {
                        repetido = true;
                    }                    
                }
                
                if (repetido)
                {
                    MensajeError("YA se encuentra el artículo en el detalle");
                }
                else
                {
                    
                    if (listaDetalles.Count == 0)
                    {
                        itemID = TrabajarItemOrdenCompra.getUltimoId(); ;
                    }
                    else
                    {
                        itemID++;
                        //int index = listaDetalles.Count -1;
                        //itemID = listaDetalles[index].ItemID + 1;
                    }
                    Item_Orden_Compra nuevoItem = new Item_Orden_Compra(itemID,
                                                                        ordenCompra.Oc_ID,
                                                                        idArtSeleccionado,
                                                                        Convert.ToDecimal(txtArt_Costo.Text),
                                                                        Convert.ToDecimal(txtCantidad.Text),
                                                                        subTotal);
                    listaDetalles.Add(nuevoItem);
                    calcularTotal();
                }
            }
        }

        private void calcularTotal()
        {
            total = 0;
            foreach (Item_Orden_Compra item in listaDetalles)
            {
                total += item.ItemImporte;
            }
            lblTotal_Pagado.Text = Convert.ToString(total);
        }

/*  Evento del Boton Quitar item de Orde de compra
 * elimina de la lista el item seleccionado */
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvDetallesItems.SelectedRows.Count <= 0)
            {
                MensajeError("Debe Seleccionar un Fila Primero");
            }
            else
            {
                Item_Orden_Compra item = (Item_Orden_Compra)dgvDetallesItems.CurrentRow.DataBoundItem;
                listaDetalles.Remove(item);
                calcularTotal();
            }
        }
        

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtOc_ID.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Número OC"].Value);
                this.cmbProv_ID.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Proveedor"].Value);
                this.dtOc_Fecha.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["Fecha"].Value);
                this.MostrarDetalle();
                this.tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProveedor oProv = new FrmProveedor();
            oProv.ShowDialog();
        }


/* EVENTO DEL BOTON GUARDAR
 * creo el objeto orden de compra con los datos del form y los guardo en la BD
 */
        private void btnSaveOC_Click(object sender, EventArgs e)
        {
            if (validarCamposOrdenCompra())
            {
                if (listaDetalles.Count > 0)
                {
                    ordenCompra.Oc_Fecha = dtOc_Fecha.Value;
                    ordenCompra.Pagada = rbYes.Checked;
                    ordenCompra.Prov_ID = Convert.ToInt32(cmbProv_ID.SelectedValue);

                    TrabajarOrden.insertOrden(ordenCompra);
                    TrabajarItemOrdenCompra.insertItems(listaDetalles);
                    disableFormOrdenCompra();
                    limpiarDetalle();
                    MensajeOk("El Orden de compra se Guardo correctamente");
                }
                else
                {
                    MensajeError("No puede Guarda Una orden de Compra vacia \n" +
                                 "Porfavor Agregue Articulos a la orden de compra");
                }
            }
            
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                subTotal = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtArt_Costo.Text);
                lblSubTotal.Text = Convert.ToString(subTotal);
            }
            catch (Exception)
            {
                lblSubTotal.Text = "0";                
            }
            
        }

        private void txtArt_Costo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                subTotal = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtArt_Costo.Text);
                lblSubTotal.Text = Convert.ToString(subTotal);
            }
            catch (Exception)
            {
                lblSubTotal.Text = "0";
            }
        }


        
    }
}
