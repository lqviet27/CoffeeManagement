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
    public partial class FormEditInformation : Form
    {
        public FormEditInformation()
        {
            InitializeComponent();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            //FormTable formTable = new FormTable();
            //this.Hide();
            //formTable.ShowDialog();
            //this.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            //FormAdmin formAdmin = new FormAdmin();
            //this.Hide();
            //formAdmin.ShowDialog();
            //this.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            //FormLogin formLogin = new FormLogin();
            //this.Hide();
            //formLogin.ShowDialog();
            //this.Show();
        }

        private void FormEditInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Dispose();
        }
    }
}
