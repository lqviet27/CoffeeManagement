using DAL;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        //--------------------------------------------------------
        public void SetTableOnline(string TableName)
        {
            DAL_Table.Instance.SetTableOnline(TableName);
        }
        public void SetTableEmpty(string TableName)
        {
            DAL_Table.Instance.SetTableEmpty(TableName);
        }

        public void getAvailableTable(List<Table> listTable, ComboBox cb_ToTable)
        {
            cb_ToTable.Items.Clear();
            cb_ToTable.Text = "";
            for (int i = 0; i < listTable.Count; i++)
            {
                if (listTable[i].status == "Empty")
                    cb_ToTable.Items.Add(listTable[i].name);
            }
        }

        public void MoveTable(string tableFrom, string tableTo)
        {
            DAL_Table.Instance.MoveTable(tableFrom, tableTo);
        }
    }
}
