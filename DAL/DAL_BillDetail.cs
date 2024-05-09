using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BillDetail : DAL<DAL_BillDetail, BillDetail, int>
    {
        public override void Create(BillDetail billdetail)
        {
            SqlCommand cmd = new SqlCommand("InsertBillDetail");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdBill", SqlDbType.Int).Value = billdetail.billId;
            cmd.Parameters.AddWithValue("@DrinkName", SqlDbType.NVarChar).Value = billdetail.drinkName;
            cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Int).Value = billdetail.quantity;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override void Delete(int BillID)
        {
            SqlCommand cmd = new SqlCommand("DeleteBillDetail");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BillID", SqlDbType.Int).Value = BillID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public void DeleteDrinkBill(int BillID,string  nameDrink)
        {
			SqlCommand cmd = new SqlCommand("DeleteDrinkBill");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@BillID", SqlDbType.Int).Value = BillID;
			cmd.Parameters.AddWithValue("@NameDrink", SqlDbType.NVarChar).Value = nameDrink;
			DataProvider.Instance.ExecuteNonQuery(cmd);
		}


        public override DataTable Read()
        {
            throw new NotImplementedException();
        }

        public override void Update(BillDetail billDetail, int oldBillDetailID)
        {
            SqlCommand cmd = new SqlCommand("IncreaseDrink");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BillID", SqlDbType.NVarChar).Value = billDetail.billId;
            cmd.Parameters.AddWithValue("@DrinkName", SqlDbType.NVarChar).Value = billDetail.drinkName;
            cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Int).Value = billDetail.quantity;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
		public void QuantityDes(int BillId, string DrinkName, int count)
		{
			SqlCommand cmd = new SqlCommand("descreaseDrink");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@BillID", SqlDbType.Int).Value = BillId;
			cmd.Parameters.AddWithValue("@DrinkName", SqlDbType.NVarChar).Value = DrinkName;
			cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Int).Value = count;
			DataProvider.Instance.ExecuteNonQuery(cmd);
		}

		public int getCountDrink(int idBIll, string drinkName)
        {
            SqlCommand cmd = new SqlCommand("CheckDrinkTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BillID", SqlDbType.Int).Value = idBIll;
            cmd.Parameters.AddWithValue("@DrinkName", SqlDbType.Int).Value = drinkName;
            DataTable table = DataProvider.Instance.ExecuteTable(cmd);
            return int.Parse(table.Rows[0][0].ToString());
        }

        public DataTable Read(int billID)
        {
            SqlCommand cmd = new SqlCommand("SelectAllBillDetail");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BillID", SqlDbType.Int).Value = billID;
            return DataProvider.Instance.ExecuteTable(cmd);
        }
    }
}
