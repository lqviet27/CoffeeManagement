using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private DataTable DrinkType;
        private DataTable Drink;

        private void LoadComboBox()
        {
            comboBoxDrinkType.Items.Clear();
            string s = "Select * from DrinkType";
            string s1 = "Select * from Drink";
            SqlCommand cmd = new SqlCommand(s, DataProvider.Instance.con);
            SqlCommand cmd1 = new SqlCommand(s1, DataProvider.Instance.con);
            DrinkType = DataProvider.Instance.ExecuteTable(cmd);
            Drink = DataProvider.Instance.ExecuteTable(cmd1);
            foreach (DataRow dr in DrinkType.Rows)
            {

                comboBoxDrinkType.Items.Add(dr["Name"]);


            }
        }
        private void FormTable_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBoxDrinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDrink.Items.Clear();
            comboBoxDrink.Text = "";
            string NameType = comboBoxDrinkType.Text.ToString();
            string IDType = "";
            foreach (DataRow row in DrinkType.Rows)
            {
                if (row["Name"].ToString() == NameType) 
                { 
                    IDType = row["ID"].ToString();
                    break;
                }
            }
            foreach(DataRow row in Drink.Rows)
            {
                if (row["IDType"].ToString() ==  IDType)
                {
                    comboBoxDrink.Items.Add(row["Name"].ToString());
                }
            }
        }
    }
}
