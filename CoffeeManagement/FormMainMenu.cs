using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FormMainMenu : Form
    {
        //******
        private string Type = FormLogin.Type;
        //******
        public FormMainMenu()
        {
            InitializeComponent();
            checkAdmin();
        }
        private void checkAdmin()
        {
            if (Type == "Admin")
                btn_Admin.Enabled = true;
            else
                btn_Admin.Enabled = false;
        }
        private void btn_Table_Click(object sender, EventArgs e)
        {
            FormTable formTable = new FormTable();
            this.Hide();
            formTable.ShowDialog();
            this.Show();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            this.Hide();
            formAdmin.ShowDialog();
            this.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChangeInfo_Click(object sender, EventArgs e)
        {
            FormEditInformation formEditInformation = new FormEditInformation();
            this.Hide();
            formEditInformation.ShowDialog();
            this.Show();
        }
    }
}
