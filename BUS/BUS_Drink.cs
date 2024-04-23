using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Drink : BUS<BUS_Drink, Drink, int>
    {
        public override void Create(Drink model)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int data)
        {
            throw new NotImplementedException();
        }

        public override void getList(List<Drink> list)
        {
            list.Clear();
            foreach(DataRow dr in Read().Rows)
            {
                list.Add(new Drink
                {
                    id = Convert.ToInt32(dr["ID"]),
                    name = dr["Name"].ToString(),
                    type = dr["Type"].ToString(),
                    price = float.Parse(dr["Price"].ToString())
                });
            }
        }

        public override DataTable Read()
        {
            return DAL_Drink.Instance.Read();
        }

        public override void Update(Drink model, int data)
        {
          //  throw new NotImplementedException();
        }
    }
}
