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

        FormLogin _formLogin;
        public FormMainMenu(FormLogin formLogin)
        {
            InitializeComponent();
            _formLogin = formLogin;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Dispose();
            _formLogin.Show();
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            FormTable formTable = new FormTable();
            this.Dispose();
            formTable.Show();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            this.Dispose();
            formAdmin.Show();
        }

        private void btn_changeInfo_Click(object sender, EventArgs e)
        {
            FormEditInformation formEditInformation = new FormEditInformation();
            this.Dispose();
            formEditInformation.Show();
        }

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
