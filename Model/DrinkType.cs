using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DrinkType
    {
        private int _id;
        private string _name;

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
        public DrinkType() { }
        public DrinkType(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
    }
}
