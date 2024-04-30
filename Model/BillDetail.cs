using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BillDetail
    {
        private int _id;
        private int _billId;
        private string _drinkName;
        private int _quantity;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int billId
        {
            get { return _billId; }
            set { _billId = value; }
        }
        public string drinkName
        {
            get { return _drinkName; }
            set { _drinkName = value; }
        }
        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public BillDetail() { }
        public BillDetail(int id, int billId, string drinkName, int quantity)
        {
            this._id = id;
            this._billId = billId;
            this._drinkName = drinkName;
            this._quantity = quantity;
        }
    }
}
