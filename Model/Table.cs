using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Table
    {
        private int _id;
        private string _name, _status;
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
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
        public Table() { }
        public Table(int id, string name, string status)
        {
            this._id = id;
            this._name = name;
            this._status = status;
        }
    }
}
