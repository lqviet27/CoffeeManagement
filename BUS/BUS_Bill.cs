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
            DAL_Bill.Instance.Delete(data);
        }

        public override void getList(List<Bill> list)
        {
            throw new NotImplementedException();
        }

        public override DataTable Read()
        {
            throw new NotImplementedException();
        }
        public override void Update(Bill model, int data)
        {
            throw new NotImplementedException();
        }
        //--------------------------------------------------------
        public int getBillID(string tableName)
        {
            return DAL_Bill.Instance.getBillID(tableName);
        }
        public DataTable Revenue(DateTime StartDay, DateTime EndDay, int numDays)
        {
            return DAL_Bill.Instance.Revenue(StartDay, EndDay, numDays);
        }
        public DataTable RevenueByCashier(DateTime StartDay, DateTime EndDay)
        {
            return DAL_Bill.Instance.RevenueByCashier(StartDay, EndDay);
        }
        // cap nhat tong tien cua hoa don khi them mon
        public void setTotal(string tableName, float drinkTotal)
        {
            DAL_Bill.Instance.setTotal(tableName, drinkTotal);
        }
        //lay ra tong tien cua hoa don
        public float getTotal(string tableName)
        {
               return DAL_Bill.Instance.getTotal(tableName);
        }
        // lay ra ten nhan vien
        public string getCashier(string tableName)
        {
            return DAL_Bill.Instance.getCashier(tableName);
        }
        // chuyen sang trang thai bill la 1: da thanh toan
        public void setPurchase(string tableName)
        {
            DAL_Bill.Instance.setPurchase(tableName);
        }

        public void UpdateTableInBill(string tableFrom, string tableTo)
        {
            DAL_Bill.Instance.UpdateTableInBill(tableFrom, tableTo);
        }
    }
}
