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
        public override void Create(Bill newBill)
        {
            SqlCommand cmd = new SqlCommand("InsertBill");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTable", SqlDbType.Int).Value = newBill.idTable;
            cmd.Parameters.Add("@Day", SqlDbType.DateTime).Value = newBill.Date;
            cmd.Parameters.Add("@Cashier", SqlDbType.NVarChar).Value = newBill.cashier;
            cmd.Parameters.Add("@TotalPrice", SqlDbType.Float).Value = newBill.totalPrice;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override void Delete(int PKValue)
        {
            throw new NotImplementedException();
        }

        public override DataTable Read()
        {
            throw new NotImplementedException();
        }

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

        public override void Update(Bill updateElement, int PKvalue)
        {
            throw new NotImplementedException();
        }
    }
}
