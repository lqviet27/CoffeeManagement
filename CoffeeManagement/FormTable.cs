using BUS;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FormTable : Form
    {
        private List<Table> tables = new List<Table>();
        private Table currentTable;
        private List<DrinkType> drinkTypes = new List<DrinkType>();
        private List<Drink> drinks = new List<Drink>();
        
        public FormTable()
        {
            InitializeComponent();
            LoadComboBox();
            loadTable();
        }


        public void loadTable()
        {
            BUS_Table.Instance.getList(tables);
            Point point = new Point(3, 30) ;
            
            for(int i=0;i<tables.Count;i++)
            {
                Button btn = new Button();
                btn.MouseClick += Btn_MouseClick;
                btn.Size=new Size(90, 40);
                btn.Font = new System.Drawing.Font(button1.Font.FontFamily, 12);
                if (tables[i].status=="Online")
                    btn.BackColor = System.Drawing.Color.Red;
                btn.Text = tables[i].name;
                if(point.X + 90 > pn_Table.Width)
                {
                    point.X = 3; point.Y += 50;
                }
                btn.Location = point;
                pn_Table.Controls.Add(btn);
                point.X += 90 + 10;
             
            }
            
             
        }

        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            
              Button btn=  (Button) sender;
                tx_Table.Text = btn.Text;
        }

        private DataTable DT_Drink;

        private void LoadComboBox()
        {
            comboBoxDrinkType.Items.Clear();

            BUS_DrinkType.Instance.getList(drinkTypes);
            BUS_Drink.Instance.getList(drinks);

            foreach (DrinkType dt in drinkTypes)
            {
                comboBoxDrinkType.Items.Add(dt.name);
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
            foreach (Drink dr in drinks)
            {
                if (dr.type == NameType) 
                {
                    comboBoxDrink.Items.Add(dr.name);
                }
            }
        }

        

        
    }
}
