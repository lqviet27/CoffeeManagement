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
            Drink newDrink = new Drink {
                id = Convert.ToInt32(tb_DrinkID.Text),
                name = tb_DrinkName.Text,
                type = cb_DrinkType.Text,
                price = float.Parse(nm_DrinkPrice.Value.ToString()),
            };
            // cap nhat database
            BUS_Drink.Instance.Create(newDrink);
            btn_ShowDrink.PerformClick();
        }

        private void btn_EditDrink_Click(object sender, EventArgs e)
        {
            int oldDrinkID = 0;
            foreach(DataGridViewRow row in dgv_Drink.SelectedRows)
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
            DrinkType newDrinkType = new DrinkType
            {
                id = Convert.ToInt32(tb_DrinkTypeID.Text),
                name = tb_DrinkTypeName.Text
            };
            // cap nhat database
            BUS_DrinkType.Instance.Create(newDrinkType);
            btn_ShowDrinkType.PerformClick();
        }

        private void btn_EditDrinkType_Click(object sender, EventArgs e)
        {
            int odlDrinkTypeID = 0;
            foreach(DataGridViewRow row in dgv_DrinkType.SelectedRows)
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
        
        private void btn_EditTable_Click(object sender, EventArgs e)
        {
            int oldTableID = 0;
            foreach(DataGridViewRow row in dgv_Table.SelectedRows)
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
                tb_PassWord.Text = row.Cells[2].Value.ToString();
                cb_TypeAccount.Text = row.Cells[3].Value.ToString();

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
            Account newAccount = new Account
            {
                userName = tb_UserName.Text,
                displayName = tb_DisplayName.Text,
                type = cb_TypeAccount.Text,
                password = tb_PassWord.Text
            };
            // cap nhat database
            BUS_Account.Instance.Create(newAccount);
            btn_ShowAccount.PerformClick();
        }
        private void btn_EditAccount_Click(object sender, EventArgs e)
        {
            string oldUserName = "";
            foreach(DataGridViewRow row in dgv_Account.SelectedRows)
            {
                oldUserName = row.Cells[0].Value.ToString();
            }
            Account newAccount = new Account
            {
                userName = tb_UserName.Text,
                displayName = tb_DisplayName.Text,
                type = cb_TypeAccount.Text,
                password = tb_PassWord.Text
            };
            // cap nhat database
            BUS_Account.Instance.Update(newAccount, oldUserName);
            btn_ShowAccount.PerformClick();
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
            DataTable dt = new DataTable();
            dt.Rows.Clear();

            TimeSpan numberDays = dateTimePickerEnd.Value.Date.Subtract(dateTimePickerStart.Value.Date);
            int numDays = numberDays.Days;

            chart1.Series.Clear();

            Series Revenue = new Series("Revenue");
            chart1.Series.Add(Revenue);

            if ((numDays >= 14 && numDays < 30))
                chart1.Series["Revenue"].ChartType = SeriesChartType.Line;
            else
                chart1.Series["Revenue"].ChartType = SeriesChartType.Column;
            dt = BUS_Bill.Instance.Revenue(dateTimePickerStart.Value.Date, dateTimePickerEnd.Value.Date, numDays);

            chart1.DataSource = dt;

            chart1.Series["Revenue"].XValueMember = "Day";
            chart1.Series["Revenue"].YValueMembers = "Revenue";
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Series["Revenue"].IsValueShownAsLabel = true;
            chart1.Series["Revenue"].SmartLabelStyle.Enabled = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.Visible = true;

        }
    }
}
