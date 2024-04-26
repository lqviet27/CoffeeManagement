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
    public class DAL_Table : DAL<DAL_Table, Table, int>
    {
        public override void Create(Table newTable)
        {
            SqlCommand cmd = new SqlCommand("InsertTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = newTable.id;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = newTable.name;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = newTable.status;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override void Delete(int deleteTableID)
        {
            SqlCommand cmd = new SqlCommand("DeleteTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = deleteTableID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("SelectAllTable");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }

        public override void Update(Table updateTable, int oldTableID)
        {
            SqlCommand cmd = new SqlCommand("UpdateTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = updateTable.id;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = updateTable.name;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = updateTable.status;
            cmd.Parameters.AddWithValue("@OldId", SqlDbType.Int).Value = oldTableID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        //-----------------------------------------------------
        // dung khi them mon vao ban se chuyen sang online
        public void SetTableOnline(string TableName)
        {
            SqlCommand cmd = new SqlCommand("SetTableOnline");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = TableName;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        // dung khi thanh toan se chuyen sang empty
        public void SetTableEmpty(string TableName)
        {
            SqlCommand cmd = new SqlCommand("SetTableEmpty");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = TableName;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }


    }
}
