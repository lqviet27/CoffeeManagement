using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    public class OrderDrink
    {
        private int _id {  get; set; }

        private string _name { get; set; }   

        private int _quantity { get; set; }

        private float _price { get; set; }


        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public float price
        {
            get { return _price; }
            set { _price = value; }
        }
        public OrderDrink() { }
        public OrderDrink(int id, string name,int quantity,float price)
        {
            this._id = id;
            this._name = name;
            this._quantity = quantity;
            this._price = price;
        }

    }
}
