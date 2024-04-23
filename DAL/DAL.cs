using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class DAL<DALType, ModelType, PKType> where DALType : new()
    {
        protected static DALType _Instance;
        protected DAL() { }
        public static DALType Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DALType();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }
        public abstract void Create(ModelType newElement);
        public abstract DataTable Read();
        public abstract void Update(ModelType updateElement, PKType PKvalue);
        public abstract void Delete(PKType PKValue);
    }
    
}
