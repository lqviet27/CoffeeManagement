using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public abstract class BUS<BUSType, ModelType, PKType> where BUSType : new()
    {
        protected static BUSType _Instance;
        protected BUS() { }
        public static BUSType Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BUSType();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }
        public void ShowDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = Read();
        }
        public abstract void getList(List<ModelType> list);
        public abstract DataTable Read();
        public abstract void Create(ModelType model);
        public abstract void Delete(PKType data);
        public abstract void Update(ModelType model, PKType data);

    }
    
}
