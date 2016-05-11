using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class Orden_Compra
    {
        private int oc_ID;
        private int prov_ID;
        private DateTime oc_Fecha;
        private bool pagada;
        private string txt_Buscar;

        //Getters and Setters
        public int Oc_ID
        {
            get { return oc_ID; }
            set { oc_ID = value; }
        }
        public int Prov_ID
        {
            get { return prov_ID; }
            set { prov_ID = value; }
        }
        public DateTime Oc_Fecha
        {
            get { return oc_Fecha; }
            set { oc_Fecha = value; }
        }
        public bool Pagada
        {
            get { return pagada; }
            set { pagada = value; }
        }
        public string Txt_Buscar
        {
            get { return txt_Buscar; }
            set { txt_Buscar = value; }
        }

        //Constructors
        public Orden_Compra()
        {
        }
        public Orden_Compra(int nID,int nProv,DateTime dtFecha,bool bPago,string sBuscar)
        {
            Oc_ID = nID;
            Prov_ID = nProv;
            Oc_Fecha = dtFecha;
            Pagada = bPago;
            Txt_Buscar = sBuscar;
        }

        //Insert
        public void InsertOrden(Orden_Compra orden)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT into Orden_Compra(prov_id,oc_fecha,pagada) values ( @prov_id, @oc_fecha, @pagada)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@prov_id", orden.Prov_ID);
            cmd.Parameters.AddWithValue("@oc_fecha", orden.Oc_Fecha);
            cmd.Parameters.AddWithValue("@pagada", orden.Pagada);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        //Search
        public DataTable SearchOrdenes(Orden_Compra oOrden)
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT ";
            oCmd.CommandText += "oc_id as 'Número OC', ";
            oCmd.CommandText += "prov_nombre as 'Proveedor', oc_fecha as 'Fecha', ";
            oCmd.CommandText += "pagada as 'Estado'";
            oCmd.CommandText += "FROM Orden_Compra as O";
            oCmd.CommandText += " INNER JOIN Proveedor as P ON (P.prov_id=O.prov_id)";

            oCmd.CommandText += "WHERE ";
            oCmd.CommandText += "oc_fecha LIKE @pattern OR pagada LIKE @pattern";

            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@pattern", "%" + oOrden.Txt_Buscar + "%");

            DataTable oDT = new DataTable();
            try
            {
                SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
                oDA.Fill(oDT);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                oDT = null;
            }
            return oDT;
        }
        //Obtener Listas
        public DataTable ListOrden()
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT ";
            oCmd.CommandText += "oc_id as 'Numero_id', ";
            oCmd.CommandText += "prov_nombre as 'Proveedor', oc_fecha as 'Fecha', ";
            oCmd.CommandText += "pagada as 'Estado'";
            oCmd.CommandText += "FROM Orden_Compra as O";
            oCmd.CommandText += " LEFT JOIN Proveedor as P ON (P.prov_id=O.prov_id)";

            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        public DataTable ListItem(Item_Orden_Compra oItem)
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT ";
            oCmd.CommandText += "art_id,cantidad as 'Cantidad' ,art_descrip as 'Artículo', ";
            oCmd.CommandText += "prov_nombre as 'Proveedor', ";
            oCmd.CommandText += "costo as 'Costo', importe as 'Importe'";
            oCmd.CommandText += "FROM Item_Orden_Compra as I";
            oCmd.CommandText += " INNER JOIN Articulo as A ON (A.art_id=I.art_id)";
            oCmd.CommandText += " WHERE oc_id=@id";

            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;
            oCmd.Parameters.AddWithValue("@id", oItem.Art_ID);

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }

        public int getUltimoId()
        {
            int ultimoId=0;
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT oc_id FROM Orden_Compra WHERE oc_id = (select max(oc_id) from Orden_Compra)";
            oCmd.Connection = oCnn;
            SqlDataReader dr;
            oCnn.Open();
            dr = oCmd.ExecuteReader();

            while (dr.Read())
            {
                ultimoId = Convert.ToInt32(dr["oc_id"]);
            }
            dr.Close();
            oCnn.Close();

            return ultimoId;
        }
    }
}
