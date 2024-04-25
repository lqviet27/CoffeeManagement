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
    public class BUS_DrinkType : BUS<BUS_DrinkType, DrinkType, int>
    {
        public override void Create(DrinkType model)
        {
            DAL_DrinkType.Instance.Create(model);
        }

        public override void Delete(int data)
        {
            DAL_DrinkType.Instance.Delete(data);
        }

        public override void getList(List<DrinkType> list)
        {
            list.Clear();
            foreach (DataRow dr in Read().Rows)
            {
                list.Add(new DrinkType
                {
                    id = Convert.ToInt32(dr["ID"]),
                    name = dr["Name"].ToString()
                });
            }
        }
        public override DataTable Read()
        {
           return DAL_DrinkType.Instance.Read();
        }

        public override void Update(DrinkType model, int data)
        {
            DAL_DrinkType.Instance.Update(model, data);
        }
        // load drink type vao combobox
        public void LoadDrinkTypeToComboBox(List<DrinkType> listType, ComboBox cbDrinkType)
        {
            cbDrinkType.Items.Clear();
            for (int i = 0; i < listType.Count; i++)
            {
                cbDrinkType.Items.Add(listType[i].name);
            }
        }
    }
}
