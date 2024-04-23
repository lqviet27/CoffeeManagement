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
    public class BUS_DrinkType : BUS<BUS_DrinkType, DrinkType, int>
    {
        public override void Create(DrinkType model)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int data)
        {
            throw new NotImplementedException();
        }

        public override void getList(List<DrinkType> list)
        {
            list.Clear();
            foreach(DataRow dt in Read().Rows) {
                list.Add(new DrinkType
                {
                    id = (int)dt["ID"],
                    name = dt["Name"].ToString()
                });
            }
        }

        public override DataTable Read()
        {
           return DAL_DrinkType.Instance.Read();
        }

        public override void Update(DrinkType model, int data)
        {
            throw new NotImplementedException();
        }
    }
}
