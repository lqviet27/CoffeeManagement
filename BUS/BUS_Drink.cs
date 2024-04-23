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
            foreach (DataRow dt in Read().Rows)
            {
                list.Add(
                    new Drink()
                    {
                        id = Convert.ToInt32(dt["ID"]),
                        name = dt["Name"].ToString(),
                        price = Convert.ToSingle(dt["Price"]),
                        type = dt["Type"].ToString()
                    }
                );
            }
        }


        public override DataTable Read()
        {
            return DAL_Drink.Instance.Read();
        }

        public override void Update(Drink model, int data)
        {
            throw new NotImplementedException();
        }
    }
}
