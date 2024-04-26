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
    public class BUS_Bill : BUS<BUS_Bill, Bill, int>
    {
        public override void Create(Bill model)
        {
            DAL_Bill.Instance.Create(model);
        }

        public override void Delete(int data)
        {
            throw new NotImplementedException();
        }

        public override void getList(List<Bill> list)
        {
            throw new NotImplementedException();
        }

        public override DataTable Read()
        {
            throw new NotImplementedException();
        }

        public DataTable Revenue(DateTime StartDay, DateTime EndDay, int numDays)
        {
            return DAL_Bill.Instance.Revenue(StartDay, EndDay, numDays);
        }

        public override void Update(Bill model, int data)
        {
            throw new NotImplementedException();
        }
    }
}
