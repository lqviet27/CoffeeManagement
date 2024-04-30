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
        private List<DrinkType> listDrinkType = new List<DrinkType>();
        private List<Drink> listDrink = new List<Drink>();
        private List<Table> listTable = new List<Table>();
        private List<Bill> listBill = new List<Bill>();
        private List<BillDetail> listBillDetail = new List<BillDetail>();
        string strBill, strCashier;
        public FormTable()
        {
            InitializeComponent();
            LoadTable();
        }

        //-----------------------------------------Table + Bill --------------------------------------
        public void LoadTable()
        {
            try
            {
                pn_Table.Controls.Clear();
                BUS_Table.Instance.getList(listTable);
                int x = 10;
                int y = 10;
                for (int i = 0; i < listTable.Count; i++)
                {
                    Button btn = new Button()
                    {
                        Name = "btnTable" + (i + 1),
                        Text = listTable[i].name,
                        //Tag = BUS_Bill.Instance.getTotal(listTable[i].name), // cai nay dang bi ngu vi neu nhu ban chua co bill thi se bi loi
                        Width = 100,
                        Height = 50,
                        Location = new Point(x, y),
                    };
                    if (listTable[i].status == "Empty")
                    {
                        btn.BackColor = ColorTranslator.FromHtml("snow");
                    }
                    else if (listTable[i].status == "Online")
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
                MessageBox.Show("Database is not available tai day ");
            }

        }
        private void btnTable_MouseClick(object sender, EventArgs e)
        {
            // an di groupbox chuyen ban
            grb_SwitchTable.Visible = false;
            //tra ve trang thai ban theo mau sac cua btnTable
            txt_NameTable.Text = ((Button)sender).Text;

            if (((Button)sender).BackColor.ToString() == "Color [Snow]")
            {
                txt_Status.Text = "Empty";
                pn_Bill.Controls.Clear();
                txt_Total.Text = "0";
            }
            else if (((Button)sender).BackColor.ToString() == "Color [Red]")
            {
                txt_Status.Text = "Online";
                LoadBill();
            }
            //tra ve ten ban
            loadDataForAddDrinkGRB();
            //Tra ve tong tien
            //txt_Total.Text = ((Button)sender).Tag.ToString();
        }

        // load Bill------------------------------------
        private void LoadBill()
        {
            try
            {
                pn_Bill.Controls.Clear();
                txt_Total.Controls.Clear();
                strBill = "";
                int idBill = BUS_Bill.Instance.getBillID(txt_NameTable.Text);
                BUS_BillDetail.Instance.getList(listBillDetail, idBill);
                float totalPrice = 0;
                int y = 10;
                for (int i = 0; i < listBillDetail.Count; i++)
                {
                    strBill += (i + 1) + ".     " + listBillDetail[i].drinkName + "  X  " + listBillDetail[i].quantity.ToString() + "\n";
                    Label lbl = new Label()
                    {
                        Name = "btnFB" + i,
                        Text = "         " + (i + 1) + ".     " + listBillDetail[i].drinkName + "  X  " + listBillDetail[i].quantity.ToString(),
                        Width = pn_Bill.Width - 20,
                        Height = 20,
                        Location = new Point(5, y)
                    };
                    y += 25;
                    strCashier = BUS_Bill.Instance.getCashier(txt_NameTable.Text); // viet mot storded procedure de lay cashier co DAL_BILL (truyen vao table name va trang thai la 0 : chua thanh toan)
                    pn_Bill.Controls.Add(lbl);
                    // in tonng tien ra man hinh
                    BUS_Drink.Instance.getList(listDrink);
                    totalPrice += (BUS_Drink.Instance.getPrice(listDrink, listBillDetail[i].drinkName) * float.Parse(listBillDetail[i].quantity.ToString()));
                }
                txt_Total.Text = totalPrice.ToString();
            }
            catch
            {
                MessageBox.Show("This Bill is not available");
            }
        }

        //-----------------------------------------add drink ----------------------------------------
        // load data
        private void loadDataForAddDrinkGRB()
        {
            txt_NameTableAdd.Text = txt_NameTable.Text;
            BUS_DrinkType.Instance.getList(listDrinkType);
            BUS_DrinkType.Instance.LoadDrinkTypeToComboBox(listDrinkType, cb_DrinkType);
        }
        private void comboBoxDrinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS_Drink.Instance.getList(listDrink);
            BUS_Drink.Instance.AddDrinkToComboBoxFromType(listDrink, cb_Drink, cb_DrinkType.Text);
        }
        //----------------------------------------------------------------------------------
        //Add Drink
        private void SetTableOnline()
        {
            BUS_Table.Instance.SetTableOnline(txt_NameTable.Text);
        }
        private void SetTableEmpty()
        {
            BUS_Table.Instance.SetTableEmpty(txt_NameTable.Text);
        }

        // tinh tien tong tien
        private void setTotal()
        {
            float price = getPrice();
            float DrinkTotal = price * float.Parse(numericUpDownQuantity.Value.ToString());
            
            BUS_Bill.Instance.setTotal(txt_NameTable.Text, DrinkTotal);
        }

        //Them do uong moi
        private void AddNewDrink()
        {
            
            int idBill = BUS_Bill.Instance.getBillID(txt_NameTableAdd.Text);
            BillDetail billDetail = new BillDetail(0, idBill, cb_Drink.Text, Int32.Parse(numericUpDownQuantity.Value.ToString()));
            BUS_BillDetail.Instance.Create(billDetail);
            setTotal();
        }

        //Tang so do uong
        private void IncreaseDrink()
        {
            BillDetail billDetail = new BillDetail(0, BUS_Bill.Instance.getBillID(txt_NameTableAdd.Text), cb_Drink.Text, Int32.Parse(numericUpDownQuantity.Value.ToString()));
            BUS_BillDetail.Instance.Update(billDetail, 0);
            setTotal();
        }

        //Lay gia do uong
        private float getPrice()
        {
            BUS_Drink.Instance.getList(listDrink);
            return BUS_Drink.Instance.getPrice(listDrink, cb_Drink.Text);
        }

        //kiem tra mon da ton tai chua , neu ton tai : true, chua ton tai : false
        bool isDrink = false;
        public void isCountDrink()
        {
            try
            {
                int idBIll = BUS_Bill.Instance.getBillID(txt_NameTable.Text);
                int CountDrink = BUS_BillDetail.Instance.getCountDrink(idBIll, cb_Drink.Text);
                //MessageBox.Show(CountDrink.ToString());// lay ra so luong mon dua vao id bill va ten mon
                if (CountDrink > 0)
                {
                    isDrink = true;
                }
            }
            catch
            {
                isDrink = false;
            }
        }

        // submit add drink vao bill
        private void btn_AddDrink_Click(object sender, EventArgs e)
        {
            try
            {
                // sua lai ham add drink . neu dang empty thi moi tao bill moi , neu dang online thi chi lay ra id bill
                if (txt_Status.Text == "Empty")
                {
                    // tao bill moi o day va truyen id bill vao ham add drink
                    Bill bill = new Bill(0, txt_NameTableAdd.Text, FormLogin.Cashier, 0, DateTime.Now.Date, 0);
                    BUS_Bill.Instance.Create(bill);
                    SetTableOnline();
                    AddNewDrink();
                }
                else if (txt_Status.Text == "Online")
                {
                    // lay ra id bill va truyen vao ham add drink

                    //Ban dang hoat dong. chi them mon
                    isCountDrink();
                    if (isDrink == false)
                    {
                        //Neu mon chua co thi them mon
                        AddNewDrink();
                    }
                    else
                    {
                        //Neu mon co roi thi tang so luong
                        IncreaseDrink();
                    }
                }
                LoadTable();
                LoadBill();
                //Do khong he goi duoc phuong thuc Clickble de cap nhat lai Total Price
                // float DrinkTotal = float.Parse(txt_Total.Text) + getPrice() * float.Parse(numericUpDownQuantity.Value.ToString());
                //txt_Total.Text = DrinkTotal.ToString();
                txt_Status.Text = "Online";
            }
            catch
            {
                MessageBox.Show("Add Drink Fail !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------------------PURCHASE----------------------------------------------
        
        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Status.Text == "Online")
                {
                    DialogResult ms = MessageBox.Show("Comfirm Purchase : " + txt_NameTable.Text + "\n\nTotal Price: " + txt_Total.Text + " VND", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (ms == DialogResult.Yes)
                    {
                        int billID = BUS_Bill.Instance.getBillID(txt_NameTable.Text);
                        SetTableEmpty();
                        BUS_Bill.Instance.setPurchase(txt_NameTable.Text);
                        BUS_BillDetail.Instance.Delete(billID);
                        txt_Status.Text = "Empty";
                        txt_Total.Text = "0";
                        MessageBox.Show("Purchase success !  " + txt_NameTable.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadTable();
                    //LoadBill();
                    pn_Bill.Controls.Clear();
                }
                else if (txt_Status.Text == "Empty")
                {
                    MessageBox.Show("This Table Is Now Empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        //------------------------------------PRINT BILL-----------------------------------------------
        private void printDocumentBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DateTimePicker datetime = new DateTimePicker();
            string HoaDon = "";
            HoaDon += "\n" + "IT Coffee Shop" + "\n";
            HoaDon += "\n" + "Address : DUT" + "\n\n\n";
            HoaDon += "\n" + "Bill " + txt_NameTable.Text + "        \n\n\n";
            HoaDon += strBill;
            HoaDon += "\n\n\nTime: " + datetime.Value.ToShortTimeString() + ". " + datetime.Value.ToShortDateString() + "\n";
            HoaDon += "Cashier : " + strCashier + "\n";
            HoaDon += "\nTotal Price : " + txt_Total.Text + " VNĐ\n";
            e.Graphics.DrawString(HoaDon, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 100, 200);
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                printDialogBill.Document = printDocumentBill;
                if (printDialogBill.ShowDialog() == DialogResult.OK)
                {
                    printDocumentBill.Print();
                }
            }
            catch
            {
                MessageBox.Show("Can't print Bill !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //------------------------------------SWITCH TABLE---------------------------------------------
        private void LoadDataForSwitchTableGRB()
        {
            txt_FromTable.Text = txt_NameTable.Text;
            BUS_Table.Instance.getList(listTable);
            //Chi cho phep nhung ban khac Ban hien tai va hien dang Empty
            BUS_Table.Instance.getAvailableTable(listTable, cb_ToTable);
        }
        private void btn_SwitchTable_Click(object sender, EventArgs e)
        {
            //grb_SwitchTable.Visible = false;
            try
            {
                if (txt_Status.Text == "Online")
                {
                    grb_SwitchTable.Visible = true;
                    LoadDataForSwitchTableGRB();
                }
                else if (txt_Status.Text == "Empty")
                {
                    MessageBox.Show("This Table Is Now Empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }
        private void MoveTable()
        {
            string TableFrom = txt_FromTable.Text;
            string TableTo = cb_ToTable.Text;
            BUS_Bill.Instance.UpdateTableInBill(TableFrom, TableTo);
            BUS_Table.Instance.MoveTable(TableFrom, TableTo);
        }

        

        private void btn_AcceptSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ms = MessageBox.Show("Do you want to switch table " + txt_FromTable.Text + " to " + cb_ToTable.Text + " ?", "Submit", MessageBoxButtons.YesNo);
                if (ms == DialogResult.Yes)
                {
                    MoveTable();
                    LoadTable();
                    LoadBill();
                    pn_Bill.Controls.Clear();
                    MessageBox.Show("Switch Table Successfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Switch Table Fail !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
