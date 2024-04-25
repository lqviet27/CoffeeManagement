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
            loadTable();
        }


        public void loadTable()
        {
            //BUS_Table.Instance.getList(tables);
            //Point point = new Point(3, 30) ;

            //for(int i=0;i<tables.Count;i++)
            //{
            //    Button btn = new Button();
            //    btn.Size = new Size(90, 40);
            //    btn.Font = new System.Drawing.Font(button1.Font.FontFamily, 12);
            //    if (tables[i].status == "Online")
            //        btn.BackColor = System.Drawing.Color.Red;
            //    btn.Text = tables[i].name;
            //    if (point.X + 90 > pn_Table.Width)
            //    {
            //        point.X = 3; point.Y += 50;
            //    }
            //    btn.Location = point;
            //    pn_Table.Controls.Add(btn);
            //    point.X += 90 + 10;
            //    btn.MouseClick += new MouseEventHandler(btnTable_MouseClick);
            //}
            try
            {
                pn_Table.Controls.Clear();
                BUS_Table.Instance.getList(tables);
                int x = 10;
                int y = 10;
                for (int i = 0; i < tables.Count; i++)
                {
                    Button btn = new Button()
                    {
                        Name = "btnTable" + (i + 1),
                        Text = tables[i].name,
                        Width = 100,
                        Height = 50,
                        Location = new Point(x, y),
                    };
                    if (tables[i].status == "Empty")
                    {
                        btn.BackColor = ColorTranslator.FromHtml("snow");
                    }
                    else if (tables[i].status == "Online")
                    {
                        btn.BackColor = ColorTranslator.FromHtml("red");
                    }
                    if (x < pn_Table.Width - 220)
                    {
                        x += 110;
                    }
                    else
                    {
                        x = 10;
                        y += 60;
                    }
                    btn.MouseClick += new MouseEventHandler(btnTable_MouseClick);
                    pn_Table.Controls.Add(btn);
                }
            }
            catch
            {
                MessageBox.Show("Database is not available ! ");
            }

        }



        private void btnTable_MouseClick(object sender, EventArgs e)
        {
            //tra ve trang thai ban theo mau sac cua btnTable
            if (((Button)sender).BackColor.ToString() == "Color [Snow]")
            {
                txt_Status.Text = "Empty";
            }
            else if (((Button)sender).BackColor.ToString() == "Color [Red]")
            {
                txt_Status.Text = "Online";
            }
            //tra ve ten ban
            tb_Table.Text = ((Button)sender).Text;
            //Tra ve tong tien
            //txtTotal.Text = ((Button)sender).Tag.ToString();
            //LoadBill();
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
