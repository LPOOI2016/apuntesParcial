using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class Item_Orden_Compra
    {
        private int itemID;
        private int oc_ID;
        private int art_ID;
        private decimal itemCosto;
        private decimal itemCantidad;
        private decimal itemImporte;

        //Getters and Setters
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        public int Oc_ID
        {
            get { return oc_ID; }
            set { oc_ID = value; }
        }
        public int Art_ID
        {
            get { return art_ID; }
            set { art_ID = value; }
        }
        public decimal ItemCosto
        {
            get { return itemCosto; }
            set { itemCosto = value; }
        }
        public decimal ItemCantidad
        {
            get { return itemCantidad; }
            set { itemCantidad = value; }
        }
        public decimal ItemImporte
        {
            get { return itemImporte; }
            set { itemImporte = value; }
        }

        //Constructors
        public Item_Orden_Compra()
        {
        }
        public Item_Orden_Compra(int nID,int nOC,int nArt,decimal dCosto,decimal dCantidad,decimal dImporte)
        {
            ItemID = nID;
            Oc_ID = nOC;
            Art_ID = nArt;
            ItemCosto = dCosto;
            ItemCantidad = dCantidad;
            ItemImporte = dImporte;
        }
        public Item_Orden_Compra( int nOC, int nArt, decimal dCosto, decimal dCantidad, decimal dImporte)
        {
            
            Oc_ID = nOC;
            Art_ID = nArt;
            ItemCosto = dCosto;
            ItemCantidad = dCantidad;
            ItemImporte = dImporte;
        }

        //Insert
        public void InsertItem(Item_Orden_Compra item)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT into Items_Orden_Compra(oc_id,art_id,costo,cantidad,importe) values ( @oc_id, @art_id, @costo, @cantidad, @importe)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@oc_id", item.Oc_ID);
            cmd.Parameters.AddWithValue("@art_id", item.Art_ID);
            cmd.Parameters.AddWithValue("@costo", item.itemCosto);
            cmd.Parameters.AddWithValue("@cantidad", item.ItemCantidad);
            cmd.Parameters.AddWithValue("@importe", item.ItemImporte);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public int getUltimoId()
        {
            int ultimoId = 0;
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT item_oc_id FROM Items_Orden_Compra WHERE item_oc_id = (select max(item_oc_id) from Items_Orden_Compra)";
            oCmd.Connection = oCnn;
            SqlDataReader dr;
            oCnn.Open();
            dr = oCmd.ExecuteReader();

            while (dr.Read())
            {
                ultimoId = Convert.ToInt32(dr["item_oc_id"]);
            }
            dr.Close();
            oCnn.Close();

            return ultimoId;
        }
    }
}
