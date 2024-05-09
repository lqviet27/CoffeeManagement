using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public sealed class DAL_Account : DAL<DAL_Account, Account, string>
    {
        public override void Create(Account newAccount)
        {
            SqlCommand cmd = new SqlCommand("InsertAccount");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = newAccount.userName;
            cmd.Parameters.AddWithValue("@DisplayName", SqlDbType.NVarChar).Value = newAccount.displayName;
            cmd.Parameters.AddWithValue("@Type", SqlDbType.NVarChar).Value = newAccount.type;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = newAccount.password;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override void Delete(string deleteUserName)
        {
            SqlCommand cmd = new SqlCommand("DeleteAccount");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = deleteUserName;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("SelectAllAccount");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }

        public DataTable ReadNotPassword()
        {
            SqlCommand cmd = new SqlCommand("SelectAllAccountNotPassword");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }

        public override void Update(Account updateAccount, string oldUserName)
        {
            SqlCommand cmd = new SqlCommand("UpdateAccount");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = updateAccount.userName;
            cmd.Parameters.AddWithValue("@DisplayName", SqlDbType.NVarChar).Value = updateAccount.displayName;
            cmd.Parameters.AddWithValue("@Type", SqlDbType.NVarChar).Value = updateAccount.type;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = updateAccount.password;
            cmd.Parameters.AddWithValue("@OldUserName", SqlDbType.NVarChar).Value = oldUserName;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
    }
}
