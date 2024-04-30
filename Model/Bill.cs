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
        private int _status;
        private DateTime _day;
        private float _totalPrice;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string tableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }
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
        public DateTime day
        {
            get { return _day; }
            set { _day = value; }
        }
        public float totalPrice
        {
            get { return _date; }
            set { _date = value; }
        }

        public Bill() { }
        public Bill(int id, string tableName, string cashier, int status, DateTime day, float totalPrice)
        {
            this._idTable = idTable;
            this._cashier = cashier;
            this._status = status;
            this._day = day;
            this._totalPrice = totalPrice;
        }
    }
}