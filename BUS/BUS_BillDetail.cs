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
    public class BUS_BillDetail : BUS<BUS_BillDetail, BillDetail, int>
    {
        public override void Create(BillDetail model)
        {
            DAL_BillDetail.Instance.Create(model);
        }

        public override void Delete(int data)
        {
            DAL_BillDetail.Instance.Delete(data);
        }

		public void QuantityDes(int BillId,string DrinkName, int count)
        {
            DAL_BillDetail.Instance.QuantityDes(BillId, DrinkName, count);
        }

		public void DeleteDrinkBill(int BillID, string nameDrink)
        {
            DAL_BillDetail.Instance.DeleteDrinkBill(BillID, nameDrink);
        }


		public void getList(List<BillDetail> list, int billID)
        {
            list.Clear();
            foreach (DataRow row in Read(billID).Rows)
            {
                list.Add(new BillDetail
                {
                    id = Convert.ToInt32(row["ID"]),
                    billId = Convert.ToInt32(row["IDBill"]),
                    drinkName = row["DrinkName"].ToString(),
                    quantity = Convert.ToInt32(row["Quantity"])
                });
            }
        }

        public override void getList(List<BillDetail> list)
        {
            throw new NotImplementedException();
        }

        public override System.Data.DataTable Read()
        {
            throw new NotImplementedException();
        }
        public DataTable Read(int billID)
        {
            return DAL_BillDetail.Instance.Read(billID);
        }

        public override void Update(BillDetail model, int data)
        {
            DAL_BillDetail.Instance.Update(model, data);
        }
        public int getCountDrink(int idBIll, string drinkName)
        {
            return DAL_BillDetail.Instance.getCountDrink(idBIll, drinkName);
        }
    }
}
