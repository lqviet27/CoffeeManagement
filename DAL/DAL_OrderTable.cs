using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_OrderTable : DAL<DAL_OrderTable, OrderDrink, int>
    {
        public override void Create(OrderDrink newElement)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int PKValue)
        {
            throw new NotImplementedException();
        }

        public override DataTable Read()
        {
            throw new NotImplementedException();
        }

        public override void Update(OrderDrink updateElement, int PKvalue)
        {
            throw new NotImplementedException();
        }
    }
}
