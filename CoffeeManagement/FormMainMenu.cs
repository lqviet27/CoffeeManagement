using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeManagement
{
    public partial class FormMainMenu : Form
    {

        public FormMainMenu()
        {
            InitializeComponent();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            FormTable formTable = new FormTable();
            this.Hide();
            formTable.ShowDialog();
            this.Show();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            this.Hide();
            formAdmin.ShowDialog();
            this.Show();
        }

        private void btn_changeInfo_Click(object sender, EventArgs e)
        {
            FormEditInformation formEditInformation = new FormEditInformation();
            this.Hide();
            formEditInformation.ShowDialog();
            this.Show();
        }
    }
}
