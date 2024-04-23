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
        public override void Create(Table newElement)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int PKValue)
        {
            throw new NotImplementedException();
        }

        public override DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("SelectAllTable");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }

        public override void Update(Table updateElement, int PKvalue)
        {
            throw new NotImplementedException();
        }
    }
}
