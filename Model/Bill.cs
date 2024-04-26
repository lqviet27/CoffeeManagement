using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bill
    {
        private int _idTable;
        private DateTime _date;
        private string _cashier;
        private float _totalPrice;
        public string cashier
        {
            get { return _cashier; }
            set { _cashier = value; }
        }

        public float totalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        public int idTable
        {
            get { return _idTable; }
            set { _idTable = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Bill() { }
        public Bill(int idTable, string cashier, DateTime date, float totalPrice)
        {
            this._idTable = idTable;
            this._cashier = cashier;
            this._totalPrice = totalPrice;
            this.Date = date;

        }
    }
}