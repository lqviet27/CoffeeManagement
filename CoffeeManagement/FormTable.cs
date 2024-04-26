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
        private Table currentTable = null;
        private List<DrinkType> drinkTypes = new List<DrinkType>();
        private List<Drink> drinks = new List<Drink>();
        private List<List<OrderDrink>> Order = new List<List<OrderDrink>>();
        private float currentTotal = 0;
        public FormTable()
        {
            InitializeComponent();
            loadTable();
            LoadComboBox();
        }


        public void loadTable()
        {
            pn_Table.Controls.Clear();
            BUS_Table.Instance.getList(tables);
            Point point = new Point(3, 30);
            Order = new List<List<OrderDrink>>(tables.Count + 1);
            

            for (int i = 0; i < tables.Count; i++)
            {
                Button btn = new Button();
                btn.MouseClick += Btn_MouseClick;
                btn.Size = new Size(90, 40);
                btn.Font = new System.Drawing.Font(button1.Font.FontFamily, 12);
                if (tables[i].status == "Empty")
                {
                    btn.BackColor = ColorTranslator.FromHtml("snow");
                }
                else if (tables[i].status == "Online")
                {
                    btn.BackColor = ColorTranslator.FromHtml("red");
                }
                btn.Text = tables[i].name;
                if (point.X + 90 > pn_Table.Width)
                {
                    point.X = 3; point.Y += 50;
                }
                btn.Location = point;
                pn_Table.Controls.Add(btn);
                point.X += 90 + 10;
                Order.Add(new List<OrderDrink>());
            }
            Order.Add(new List<OrderDrink>());
        }


        private void loadOrder()
        {
            pn_order.Controls.Clear();
            Point point = new Point(30, 10);
            int currentTableId = currentTable.id;
            currentTotal = 0;
            lb_billTableName.Text = currentTable.name ;
            for (int i = 0; i < Order[currentTableId].Count; i++)
            {
                currentTotal += Order[currentTableId][i].quantity * Order[currentTableId][i].price;

                Panel panel = new Panel();
       
                pn_order.Controls.Add(panel);
                panel.Size = new Size(421, 30);
                panel.Location = point;

                Label lb_orderId = new Label();
                lb_orderId.Text = i+1 + "";
                lb_orderId.Size = new Size(35, 80);
                panel.Controls.Add(lb_orderId);


                Label lb_orderName = new Label();
                lb_orderName.Text = Order[currentTableId][i].name;
                lb_orderName.Location = new Point(70, 0);
                lb_orderName.Size = new Size(100, 80);
                panel.Controls.Add(lb_orderName);

                Label quantity = new Label();
                
                quantity.Text = Order[currentTableId][i].quantity+"";
                quantity.Size = new Size(20, 80);
                quantity.Location = new Point(200, 0);
                panel.Controls.Add(quantity);

                Button btn_down = new Button();
                btn_down.Location = new Point(230, 0);
                btn_down.Size = new Size(20, 20);
                panel.Controls.Add(btn_down);

                point.Y += 30;

           
            }
            lb_Total.Text = currentTotal.ToString();

        }

        private void quantityCheck()
        {

        }

        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Button)sender).BackColor.ToString() == "Color [Snow]")
            {
                txb_StatusTable.Text = "Empty";
            }
            else if (((Button)sender).BackColor.ToString() == "Color [Red]")
            {
                txb_StatusTable.Text = "Online";
            }

            Button btn=  (Button) sender;
            tx_Table.Text = btn.Text;
            
            foreach (Table table in tables)
            {
                if(table.name.Equals(btn.Text))
                {
                    currentTable = table;
                    lb_billTableName.Text = currentTable.name;
                    pn_order.Controls.Clear();
                    loadOrder();
                    break;
                }
            }
            
        }



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
            cb_drink.Items.Clear();
            cb_drink.Text = "";
            string NameType = comboBoxDrinkType.Text.ToString();
            NumUD_quantity.Value = 1;
            foreach (Drink dr in drinks)
            {
                if (dr.type == NameType)
                {
                    cb_drink.Items.Add(dr.name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tx_Table.Text!=null&&cb_drink.Text!=null&&comboBoxDrinkType.Text!=null)
            {
               
                lb_billTableName.Text = currentTable.name;
                int currentTableId = currentTable.id;
                for(int i = 0; i < Order[currentTableId].Count();i++)
                {
                    if (Order[currentTableId][i].name==cb_drink.Text)
                    {
                        Order[currentTableId][i].quantity += (int) NumUD_quantity.Value;
                        loadOrder();
                        return;
                    }
                }

                if (txb_StatusTable.Text == "Empty")
                {
                    BUS_Table.Instance.SetTableOnline(tx_Table.Text);
                    txb_StatusTable.Text = "Online";
                    loadTable();
                }

                
                foreach (Drink dr in drinks)
                {
                    if(dr.name == cb_drink.Text)
                    {
                        Order[currentTableId].Add(new OrderDrink{
                            id = dr.id,
                            name = dr.name,
                            quantity = (int)NumUD_quantity.Value,
                            price = dr.price
                        });

                        loadOrder();
                        return;
                    }
                }
            }
            else
            {
              
            }

        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill(currentTable.id, FormLogin.Cashier, DateTime.Now.Date, currentTotal);
            BUS_Bill.Instance.Create(bill);
            MessageBox.Show("Pay Successfully!");

        }

        private void FormTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
