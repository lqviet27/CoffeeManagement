using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Drink
    {
        private int _id;
        private string _name, _type;
        private float _price;

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
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public float price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Drink() { }
        public Drink(int id, string name, string type, float price)
        {
            this._id = id;
            this._name = name;
            this._type = type;
            this._price = price;
        }
    }
}
