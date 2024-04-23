using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Account
    {
        private string _userName, _displayName, _password, _type;
        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string displayName
        {
            get { return _displayName; }
            set { _displayName = value;}
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public Account() { }
        public Account(string userName, string displayName, string password, string type)
        {
            this._userName = userName;
            this._displayName = displayName;
            this._password = password;
            this._type = type;
        }

    }
}
