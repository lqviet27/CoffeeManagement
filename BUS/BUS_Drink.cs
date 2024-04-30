using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Drink : BUS<BUS_Drink, Drink, int>
    {
        public override void Create(Drink model)
        {
            DAL_Drink.Instance.Create(model);
        }

        public override void Delete(int data)
        {
            DAL_Drink.Instance.Delete(data);
        }

        public override void getList(List<Drink> list)
        {
            list.Clear();
            foreach(DataRow dr in Read().Rows)
            {
                list.Add(new Drink
                {
                    id = Convert.ToInt32(dr["ID"]),
                    name = dr["Name"].ToString(),
                    type = dr["Type"].ToString(),
                    price = float.Parse(dr["Price"].ToString())
                });
            }
        }


        public override DataTable Read()
        {
            return DAL_Drink.Instance.Read();
        }


        public override void Update(Drink model, int data)
        {
            DAL_Drink.Instance.Update(model, data);
        }

        public void SearchByName(DataGridView dgv_Drink, string drinkName)
        {
            dgv_Drink.DataSource = null;
            dgv_Drink.Rows.Clear();
            dgv_Drink.DataSource = DAL_Drink.Instance.SearchDrink(drinkName);
        }
        // them mon vao combobox do uong co kieu la type
        public void AddDrinkToComboBoxFromType(List<Drink> list, ComboBox cb, string type)
        {
            cb.Items.Clear();
            cb.Text = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].type == type)
                    cb.Items.Add(list[i].name);
            }
        }
        // lay gia tien cua do uong
        public float getPrice(List<Drink> list, string drinkName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].name == drinkName)
                    return list[i].price;
            }
            return 0;
        }
        // tao ra list cac do uong co type mong muon
        public void getListDrinkWithManyType(List<Drink> list, List<Drink> chooseDrink, List<string> Type)
        {
            chooseDrink.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                if (Type.Contains(list[i].type))
                {
                    chooseDrink.Add(list[i]);
                }
            }
        }

    }
}
