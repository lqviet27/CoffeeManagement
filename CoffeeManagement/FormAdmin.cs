using BUS;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CoffeeManagement
{
    public partial class FormAdmin : Form
    {
        string choose = "";
        private const string SAVE_ADD_DRINK = "AddDrink";
        private const string SAVE_EDIT_DRINK = "EditDrink";
        private const string SAVE_ADD_DRINK_TYPE = "AddDrinkType";
        private const string SAVE_EDIT_DRINK_TYPE = "EditDrinkType";
        private const string SAVE_ADD_TABLE = "AddTable";
        private const string SAVE_EDIT_TABLE = "EditTable";
        private const string SAVE_ADD_ACCOUNT = "AddAccount";
        private const string SAVE_EDIT_ACCOUNT = "EditAccount";
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            Display.FormatTable(dgv_Drink);
            Display.FormatTable(dgv_DrinkType);
            Display.FormatTable(dgv_Account);
            Display.FormatTable(dgv_Table);
        }
        // -------------------------------------format size DataGridView-----------------------------------------
        private void ResizeDataGridViewColumns(DataGridView dataGridView)
        {
            int totalWidth = dataGridView.ClientSize.Width;
            int columnCount = dataGridView.Columns.Count;
            int[] columnWidths = new int[columnCount];

            // Tính toán kích thước cột cho từng cột
            for (int i = 0; i < columnCount; i++)
            {
                // Giả sử tất cả các cột có kích thước bằng nhau
                columnWidths[i] = totalWidth / columnCount;
            }

            // Thiết lập kích thước cột
            for (int i = 0; i < columnCount; i++)
            {
                dataGridView.Columns[i].Width = columnWidths[i];
            }

            // Tùy chỉnh kích thước dòng
            int rowHeight = dataGridView.RowTemplate.Height;
            int rowCount = dataGridView.DisplayedRowCount(false);
            dataGridView.Height = rowHeight * rowCount + dataGridView.ColumnHeadersHeight + 2; // 2 là margin
        }
        // -----------------------------------------------------------------------------------------------------

        // --------------------------------------Drink---------------------------------------------------------
        private void LoadDrinkTypeToComboBox()
        {
            List<DrinkType> listType = new List<DrinkType>();
            BUS_DrinkType.Instance.getList(listType);
            BUS_DrinkType.Instance.LoadDrinkTypeToComboBox(listType, cb_DrinkType);
        }

        private void btn_ShowDrink_Click(object sender, EventArgs e)
        {
            BUS_Drink.Instance.ShowDGV(dgv_Drink);
            LoadDrinkTypeToComboBox();
            //enable cho cac button
            btn_AddDrink.Enabled = true;
            btn_EditDrink.Enabled = true;
            btn_DeleteDrink.Enabled = true;
        }
        private void dgv_Drink_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Drink.SelectedRows)
            {
                tb_DrinkID.Text = row.Cells[0].Value.ToString();
                tb_DrinkName.Text = row.Cells[1].Value.ToString();
                cb_DrinkType.Text = row.Cells[2].Value.ToString();
                nm_DrinkPrice.Text = row.Cells[3].Value.ToString();
            }
        }
        private void btn_AddDrink_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Add Drink ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                choose = SAVE_ADD_DRINK;
                tb_DrinkID.Text = "";
                tb_DrinkName.Text = "";
                cb_DrinkType.Text = "";
                nm_DrinkPrice.Text = "0";
                tb_DrinkID.Focus();
            }
        }

        private void btn_EditDrink_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Add Edit ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (choose.Equals(SAVE_ADD_DRINK))
                {
                    btn_ShowDrink.PerformClick();
                }
                choose = SAVE_EDIT_DRINK;
                tb_DrinkID.Focus();
            }

        }
        private void btn_SavaDrink_Click(object sender, EventArgs e)
        {
            if (choose == "")
            {
                MessageBox.Show("Can not Save");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Confirm Save ?", "Warning !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (choose.Equals(SAVE_ADD_DRINK))
                    {
                        Drink newDrink = new Drink
                        {
                            id = Convert.ToInt32(tb_DrinkID.Text),
                            name = tb_DrinkName.Text,
                            type = cb_DrinkType.Text,
                            price = float.Parse(nm_DrinkPrice.Value.ToString()),
                        };
                        // cap nhat database
                        BUS_Drink.Instance.Create(newDrink);
                        btn_ShowDrink.PerformClick();
                    }
                    else if (choose.Equals(SAVE_EDIT_DRINK))
                    {
                        int oldDrinkID = 0;
                        foreach (DataGridViewRow row in dgv_Drink.SelectedRows)
                        {
                            oldDrinkID = Convert.ToInt32(row.Cells[0].Value.ToString());
                        }
                        Drink newDrink = new Drink
                        {
                            id = Convert.ToInt32(tb_DrinkID.Text),
                            name = tb_DrinkName.Text,
                            type = cb_DrinkType.Text,
                            price = float.Parse(nm_DrinkPrice.Value.ToString()),
                        };
                        // cap nhat database
                        BUS_Drink.Instance.Update(newDrink, oldDrinkID);
                        btn_ShowDrink.PerformClick();
                    }
                }
                choose = "";
            }
            
        }
        private void btn_DeleteDrink_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Confirm Delete ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int deleteDrinkID = 0;
                foreach (DataGridViewRow row in dgv_Drink.SelectedRows)
                {
                    deleteDrinkID = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
                //xoa trong database
                BUS_Drink.Instance.Delete(deleteDrinkID);
                btn_ShowDrink.PerformClick();
            }
        }
        private void tb_SearchDrinkName_TextChanged(object sender, EventArgs e)
        {
            BUS_Drink.Instance.SearchByName(dgv_Drink, tb_SearchDrinkName.Text);
        }
        // -----------------------------------------------------------------------------------------------------

        // --------------------------------------Drink Type-----------------------------------------------------
        private void dgv_DrinkType_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_DrinkType.SelectedRows)
            {
                tb_DrinkTypeID.Text = row.Cells[0].Value.ToString();
                tb_DrinkTypeName.Text = row.Cells[1].Value.ToString();
            }
        }
        private void btn_Show_Drink_Type_Click(object sender, EventArgs e)
        {
            BUS_DrinkType.Instance.ShowDGV(dgv_DrinkType);
            //enable cho cac button
            btn_AddDrinkType.Enabled = true;
            btn_EditDrinkType.Enabled = true;
            btn_DeleteDrinkType.Enabled = true;
        }

        private void btn_AddDrinkType_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Add Drink Type ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                choose = SAVE_ADD_DRINK_TYPE;
                tb_DrinkTypeID.Text = "";
                tb_DrinkTypeName.Text = "";
                tb_DrinkTypeID.Focus();
            }
        }

        private void btn_EditDrinkType_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Confirm Edit Drink Type ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (choose.Equals(SAVE_ADD_DRINK_TYPE))
                {
                    btn_ShowDrinkType.PerformClick();
                }
                choose = SAVE_EDIT_DRINK_TYPE;
                tb_DrinkTypeID.Focus();
            }
        }

        private void btn_SaveDrinkType_Click(object sender, EventArgs e)
        {
            if (choose == "")
            {
                MessageBox.Show("Can not Save");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Confirm Save ?", "Warning !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (choose.Equals(SAVE_ADD_DRINK_TYPE))
                    {
                        DrinkType newDrinkType = new DrinkType
                        {
                            id = Convert.ToInt32(tb_DrinkTypeID.Text),
                            name = tb_DrinkTypeName.Text
                        };
                        // cap nhat database
                        BUS_DrinkType.Instance.Create(newDrinkType);
                        btn_ShowDrinkType.PerformClick();
                    }
                    else if (choose.Equals(SAVE_EDIT_DRINK_TYPE))
                    {
                        int odlDrinkTypeID = 0;
                        foreach (DataGridViewRow row in dgv_DrinkType.SelectedRows)
                        {
                            odlDrinkTypeID = Convert.ToInt32(row.Cells[0].Value.ToString());
                        }
                        DrinkType newDrinkType = new DrinkType
                        {
                            id = Convert.ToInt32(tb_DrinkTypeID.Text),
                            name = tb_DrinkTypeName.Text
                        };
                        // cap nhat database
                        BUS_DrinkType.Instance.Update(newDrinkType, odlDrinkTypeID);
                        btn_ShowDrinkType.PerformClick();
                    }
                }
                choose = "";
            }
            
        }

        private void btn_DeleteDrinkType_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Delete ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int deleteDrinkTypeID = 0;
                foreach (DataGridViewRow row in dgv_DrinkType.SelectedRows)
                {
                    deleteDrinkTypeID = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
                //xoa trong database
                BUS_DrinkType.Instance.Delete(deleteDrinkTypeID);
                btn_ShowDrinkType.PerformClick();
            }
        }
        // -----------------------------------------------------------------------------------------------------

        // -------------------------------------------Table-----------------------------------------------------
        private void dgv_Table_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Table.SelectedRows)
            {
                tb_TableID.Text = row.Cells[0].Value.ToString();
                tb_TableName.Text = row.Cells[1].Value.ToString();
            }
        }
        private void btn_Show_Table_Click(object sender, EventArgs e)
        {
            BUS_Table.Instance.ShowDGV(dgv_Table);
            dgv_Table.Columns["Status"].Visible = false;
            //enable cho cac button
            btn_AddTable.Enabled = true;
            btn_EditTable.Enabled = true;
            btn_DeleteTable.Enabled = true;
        }
        private void btn_AddTable_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Add Table ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                choose = SAVE_ADD_TABLE;
                tb_TableID.Text = "";
                tb_TableName.Text = "";
                tb_DrinkTypeID.Focus();
            }
        }
        
        private void btn_EditTable_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Edit Table ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (choose.Equals(SAVE_ADD_TABLE))
                {
                    btn_ShowDrinkType.PerformClick();
                }
                choose = SAVE_EDIT_TABLE;
                tb_TableID.Focus();
            }
        }

        private void btn_SaveTable_Click(object sender, EventArgs e)
        {
            if (choose == "")
            {
                MessageBox.Show("Can not Save");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Confirm Save ?", "Warning !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (choose.Equals(SAVE_ADD_TABLE))
                    {
                        Table newTable = new Table
                        {
                            id = Convert.ToInt32(tb_TableID.Text),
                            name = tb_TableName.Text,
                            status = "Empty"
                        };
                        // cap nhat database
                        BUS_Table.Instance.Create(newTable);
                        btn_ShowTable.PerformClick();
                    }
                    else if (choose.Equals(SAVE_EDIT_TABLE))
                    {
                        int oldTableID = 0;
                        foreach (DataGridViewRow row in dgv_Table.SelectedRows)
                        {
                            oldTableID = Convert.ToInt32(row.Cells[0].Value.ToString());
                        }
                        Table newTalbe = new Table
                        {
                            id = Convert.ToInt32(tb_TableID.Text),
                            name = tb_TableName.Text,
                            status = "Empty"
                        };
                        // cap nhat database
                        BUS_Table.Instance.Update(newTalbe, oldTableID);
                        btn_ShowTable.PerformClick();
                    }
                }
                choose = "";
            }
            
        }

        private void btn_DeleteTable_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Delete ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int deleteTableID = 0;
                foreach (DataGridViewRow row in dgv_Table.SelectedRows)
                {
                    deleteTableID = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
                //xoa trong database
                BUS_Table.Instance.Delete(deleteTableID);
                btn_ShowTable.PerformClick();
            }
        }
        // -----------------------------------------------------------------------------------------------------


        // -------------------------------------------Account----------------------------------------------------
        private void dgv_Account_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgv_Account.SelectedRows)
            {
                tb_UserName.Text = row.Cells[0].Value.ToString();
                tb_DisplayName.Text = row.Cells[1].Value.ToString();
                cb_TypeAccount.Text = row.Cells[2].Value.ToString();
            }
        }
        private void btn_Show_Acc_Click(object sender, EventArgs e)
        {
            BUS_Account.Instance.ShowDGV(dgv_Account);
            //enable cho cac button
            btn_AddAccount.Enabled = true;
            btn_EditAccount.Enabled = true;
            btn_DeleteAccount.Enabled = true;
        }
        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Add Account ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tb_UserName.ReadOnly = false;
                choose = SAVE_ADD_ACCOUNT;
                tb_UserName.Text = "";
                tb_DisplayName.Text = "";
                cb_TypeAccount.Text = "";
                tb_UserName.Focus();
            }
        }
        private void btn_EditAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Edit Account ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (choose.Equals(SAVE_ADD_ACCOUNT))
                {
                    btn_ShowAccount.PerformClick();
                }
                choose = SAVE_EDIT_ACCOUNT;
                tb_DisplayName.Focus();
            }
        }

        private void btn_SaveAccount_Click(object sender, EventArgs e)
        {
            if(choose == "")
            {
                MessageBox.Show("Can not Save");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Confirm Save ?", "Warning !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (choose.Equals(SAVE_ADD_ACCOUNT))
                    {
                        Account newAccount = new Account
                        {
                            userName = tb_UserName.Text,
                            displayName = tb_DisplayName.Text,
                            type = cb_TypeAccount.Text,
                            password = "1"
                        };
                        // cap nhat database
                        BUS_Account.Instance.Create(newAccount);
                        btn_ShowAccount.PerformClick();
                    }
                    else if (choose.Equals(SAVE_EDIT_ACCOUNT))
                    {
                        string oldUserName = "";
                        foreach (DataGridViewRow row in dgv_Account.SelectedRows)
                        {
                            oldUserName = row.Cells[0].Value.ToString();
                        }
                        Account newAccount = new Account
                        {
                            userName = tb_UserName.Text,
                            displayName = tb_DisplayName.Text,
                            type = cb_TypeAccount.Text,
                            password = "1"
                        };
                        // cap nhat database
                        BUS_Account.Instance.Update(newAccount, oldUserName);
                        btn_ShowAccount.PerformClick();
                    }
                }
                choose = "";
            }

        }

        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Delete ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string deleteUserName = "";
                foreach (DataGridViewRow row in dgv_Account.SelectedRows)
                {
                    deleteUserName = row.Cells[0].Value.ToString();
                }
                //xoa trong database
                BUS_Account.Instance.Delete(deleteUserName);
                btn_ShowAccount.PerformClick();
            }
        }



        // -----------------------------------------------------------------------------------------------------


        // -------------------------------------------Revenue----------------------------------------------------
        private void rjButton13_Click(object sender, EventArgs e)
        {
            DataTable dt_revenue = new DataTable();
            DataTable dt_revenueByCashier = new DataTable();
            dt_revenue.Rows.Clear();
            dt_revenue.Columns.Clear();
            chart_Revenue.Series.Clear();
            chart_RevenueByCashier.Series.Clear();


            TimeSpan numberDays = dateTimePickerEnd.Value.Date.Subtract(dateTimePickerStart.Value.Date);
            int numDays = numberDays.Days;
            chart_Revenue.Series.Add("Revenue");
            chart_RevenueByCashier.Series.Add("Revenue By Cashier");

            checkBox_ByCashier.Checked = false;
            chart_Revenue.Dock = DockStyle.Fill;

            dt_revenue = BUS_Bill.Instance.Revenue(dateTimePickerStart.Value.Date, dateTimePickerEnd.Value.Date, numDays);
            if (dt_revenue.Rows.Count == 0)
            {
                MessageBox.Show("Do not exist data!");
            }
            else
            {
                if (dt_revenue.Rows.Count >= 7)
                {
                    chart_Revenue.Series["Revenue"].ChartType = SeriesChartType.Line;
                    chart_Revenue.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = -90;
                }

                else
                {
                    chart_Revenue.Series["Revenue"].ChartType = SeriesChartType.Column;
                    chart_Revenue.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = 0;
                }

                chart_Revenue.DataSource = dt_revenue;
                chart_Revenue.Series["Revenue"].XValueMember = "Day";
                chart_Revenue.Series["Revenue"].YValueMembers = "Revenue";
                chart_Revenue.ChartAreas[0].AxisX.Interval = 1;
                chart_Revenue.Series["Revenue"].IsValueShownAsLabel = true;
                chart_Revenue.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart_Revenue.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chart_Revenue.Visible = true;

            }


            dt_revenueByCashier = BUS_Bill.Instance.RevenueByCashier(dateTimePickerStart.Value.Date, dateTimePickerEnd.Value.Date);
            if (dt_revenueByCashier.Rows.Count == 0)
            {
                MessageBox.Show("Do not exist data!");
            }
            else
            {
                chart_RevenueByCashier.Series["Revenue By Cashier"].ChartType = SeriesChartType.Column;
                chart_RevenueByCashier.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = 0;
                chart_RevenueByCashier.DataSource = dt_revenueByCashier;
                chart_RevenueByCashier.Series["Revenue By Cashier"].XValueMember = "Cashier";
                chart_RevenueByCashier.Series["Revenue By Cashier"].YValueMembers = "Revenue";
                chart_RevenueByCashier.ChartAreas[0].AxisX.Interval = 1;
                chart_RevenueByCashier.Series["Revenue By Cashier"].IsValueShownAsLabel = true;
                chart_RevenueByCashier.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart_RevenueByCashier.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chart_RevenueByCashier.Visible = true;
            }

            //dt_revenue = BUS_Bill.Instance.Revenue(dateTimePickerStart.Value.Date, dateTimePickerEnd.Value.Date, numDays);
            //if (dt_revenue.Rows.Count == 0)
            //{
            //    MessageBox.Show("Do not exist data!");
            //}
            //else
            //{
            //    if (dt_revenue.Rows.Count >= 7)
            //    {
            //        chart_Revenue.Series["Revenue"].ChartType = SeriesChartType.Line;
            //        chart_Revenue.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = -90;
            //    }

            //    else
            //    {
            //        chart_Revenue.Series["Revenue"].ChartType = SeriesChartType.Column;
            //        chart_Revenue.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = 0;
            //    }

            //    chart_Revenue.DataSource = dt_revenue;
            //    chart_Revenue.Series["Revenue"].XValueMember = "Day";
            //    chart_Revenue.Series["Revenue"].YValueMembers = "Revenue";
            //    chart_Revenue.ChartAreas[0].AxisX.Interval = 1;
            //    chart_Revenue.Series["Revenue"].IsValueShownAsLabel = true;
            //    chart_Revenue.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //    chart_Revenue.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //    chart_Revenue.Visible = true;

            //}


            //if (checkBox_ByCashier.Checked)
            //{
            //    chart_Revenue.Dock = DockStyle.None;
            //    dt_revenueByCashier = BUS_Bill.Instance.RevenueByCashier(dateTimePickerStart.Value.Date, dateTimePickerEnd.Value.Date);
            //    if (dt_revenueByCashier.Rows.Count == 0)
            //    {
            //        MessageBox.Show("Do not exist data!");
            //    }
            //    else
            //    {
            //        chart_RevenueByCashier.Series["Revenue By Cashier"].ChartType = SeriesChartType.Column;
            //        chart_RevenueByCashier.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = 0;
            //        chart_RevenueByCashier.DataSource = dt_revenueByCashier;
            //        chart_RevenueByCashier.Series["Revenue By Cashier"].XValueMember = "Cashier";
            //        chart_RevenueByCashier.Series["Revenue By Cashier"].YValueMembers = "Revenue";
            //        chart_RevenueByCashier.ChartAreas[0].AxisX.Interval = 1;
            //        chart_RevenueByCashier.Series["Revenue By Cashier"].IsValueShownAsLabel = true;
            //        chart_RevenueByCashier.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //        chart_RevenueByCashier.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            //    }
            //}
            //else
            //{
            //    chart_Revenue.Dock = DockStyle.Fill;
            //}
        }

        private void checkBox_ByCashier_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox_ByCashier.Checked)
            {
                chart_Revenue.Dock = DockStyle.None;
            }
            else
            {
                chart_Revenue.Dock = DockStyle.Fill;

            }
        }
    }
}
