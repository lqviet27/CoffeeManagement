using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Table : BUS<BUS_Table, Table, int>
    {

        public override void getList(List<Table> list)
        {
            list.Clear();

            foreach (DataRow dt in Read().Rows)
            {
                list.Add(new Table
                {
                    id = (int) dt["ID"],
                    name = dt["Name"].ToString(),
                    status = dt["Status"].ToString(),
                });
            }
        }

        public override void Create(Table model)
        {
            DAL_Table.Instance.Create(model);
        }

        public override void Delete(int data)
        {
            DAL_Table.Instance.Delete(data);
        }

        public override DataTable Read()
        {
            return DAL_Table.Instance.Read();
        }

        public override void Update(Table model, int data)
        {
            DAL_Table.Instance.Update(model, data);
        }
        //-----------------------------------------------------
        public void SetTableOnline(int idTable)
        {
            DAL_Table.Instance.SetTableOnline(idTable);
        }
        public void SetTableEmpty(int idTable)
        {
            DAL_Table.Instance.SetTableEmpty(idTable);
        }
    }
}
