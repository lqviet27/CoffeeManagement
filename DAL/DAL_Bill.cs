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
    public class DAL_Bill : DAL<DAL_Bill, Bill, int>
    {
        public override void Create(Bill bill)
        {
            SqlCommand cmd = new SqlCommand("InsertBill");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = bill.tableName;
            cmd.Parameters.AddWithValue("@CashierDN", SqlDbType.NVarChar).Value = bill.cashier;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = bill.status;
            cmd.Parameters.AddWithValue("@Day", SqlDbType.DateTime).Value = bill.day;
            cmd.Parameters.AddWithValue("@TotalPrice", SqlDbType.Float).Value = bill.totalPrice;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override void Delete(int PKValue)
        {
            throw new NotImplementedException();
        }
        public override void Update(Bill updateElement, int PKvalue)
        {
            throw new NotImplementedException();
        }
        public override DataTable Read()
        {
            throw new NotImplementedException();
        }
        // -----------------------------------------------
        // thong ke doanh thu
        public DataTable Revenue(DateTime StartDay, DateTime EndDay, int numDays)
        {
            SqlCommand cmd = new SqlCommand();
            if (numDays >= 30)
                cmd.CommandText = "RevenueMonth";
            else
                cmd.CommandText = "Revenue";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@StartDay", SqlDbType.DateTime).Value = StartDay;
            cmd.Parameters.Add("@EndDay", SqlDbType.DateTime).Value = EndDay;
            return DataProvider.Instance.ExecuteTable(cmd);
        }
        // lay id hoa don theo ten ban
        public int getBillID(string tableName)
        {
            SqlCommand cmd = new SqlCommand("getBillByTableName");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = tableName;
            cmd.Parameters.Add("Status", SqlDbType.Int).Value = 0;
            DataTable dataTable = DataProvider.Instance.ExecuteTable(cmd);
            return int.Parse(dataTable.Rows[0]["ID"].ToString());
        }
        // lay tong tien cua hoa don
        public float getTotal(string tableName)
        {
            SqlCommand cmd = new SqlCommand("getBillByTableName");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = tableName;
            cmd.Parameters.Add("Status", SqlDbType.Int).Value = 0;
            DataTable dataTable = DataProvider.Instance.ExecuteTable(cmd);
            return float.Parse(dataTable.Rows[0]["TotalPrice"].ToString());
        }
        // cap nhat tong tien cua hoa don khi them mon
        public void setTotal(string tableName, float drinkTotal)
        {
            SqlCommand cmd = new SqlCommand("SetTotal");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = tableName;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = 0;
            cmd.Parameters.AddWithValue("@Total", SqlDbType.Float).Value = drinkTotal;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public string getCashier(string tableName)
        {
            SqlCommand cmd = new SqlCommand("getCashier");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = tableName;
            cmd.Parameters.Add("Status", SqlDbType.Int).Value = 0;
            DataTable dataTable = DataProvider.Instance.ExecuteTable(cmd);
            return dataTable.Rows[0][0].ToString();
        }
        // cap nhat trang thai cua hoa don la 1: da thanh toan
        public void setPurchase(string tableName)
        {
            SqlCommand cmd = new SqlCommand("SetPurchase");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = tableName;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public void UpdateTableInBill(string tableFrom, string tableTo)
        {
            SqlCommand cmd = new SqlCommand("UpdateTableInBill");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableNameFrom", SqlDbType.NVarChar).Value = tableFrom;
            cmd.Parameters.AddWithValue("@TableNameTo", SqlDbType.NVarChar).Value = tableTo;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
    }
}
