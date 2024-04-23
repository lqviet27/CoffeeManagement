using BUS;
using DAL;
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

namespace CoffeeManagement
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void nmDrinkPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ShowDrink_Click(object sender, EventArgs e)
        {
            BUS_Drink.Instance.ShowDGV(dgv_Drink);
            ResizeDataGridViewColumns(dgv_Drink);

        }

        private void btn_Show_Drink_Type_Click(object sender, EventArgs e)
        {
            BUS_DrinkType.Instance.ShowDGV(dataGridView1);
            ResizeDataGridViewColumns(dataGridView1);

        }

        private void btn_Show_Table_Click(object sender, EventArgs e)
        {
            string query = "Select * from [Table] ";
            SqlCommand cmd = new SqlCommand(query, DataProvider.Instance.con);
            DataTable dt = DataProvider.Instance.ExecuteTable(cmd);
            dataGridView2.DataSource = dt;
            ResizeDataGridViewColumns(dataGridView2);
        }

        private void btn_Show_Acc_Click(object sender, EventArgs e)
        {
            BUS_Account.Instance.ShowDGV(dataGridView3);
            ResizeDataGridViewColumns(dataGridView3);
        }
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

    }
}
