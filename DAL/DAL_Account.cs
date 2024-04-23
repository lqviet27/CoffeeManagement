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
    public sealed class DAL_Account : DAL<DAL_Account, Account, string>
    {
        public override void Create(Account newElement)
        {
            throw new NotImplementedException();
        }

        public override void Delete(string PKValue)
        {
            throw new NotImplementedException();
        }

        public override DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("getAccount");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }

        public override void Update(Account updateElement, string PKvalue)
        {
            throw new NotImplementedException();
        }
    }
}
