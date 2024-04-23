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
    public class DAL_Drink : DAL<DAL_Drink, Drink, int>
    {
        public override void Create(Drink newElement)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int PKValue)
        {
            throw new NotImplementedException();
        }

        public override DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("SelectAllDrink");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }

        public override void Update(Drink updateElement, int PKvalue)
        {
            throw new NotImplementedException();
        }
    }
}
