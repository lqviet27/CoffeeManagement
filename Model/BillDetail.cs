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
        private int _drinkId;
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
        public int drinkId
        {
            get { return _drinkId; }
            set { _drinkId = value; }
        }
        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public BillDetail() { }
        public BillDetail(int id, int billId, int drinkId, int quantity)
        {
            this._id = id;
            this._billId = billId;
            this._drinkId = drinkId;
            this._quantity = quantity;
        }
    }
}
