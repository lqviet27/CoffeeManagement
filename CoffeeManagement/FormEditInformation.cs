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
            FormTable formTable = new FormTable();
            this.Dispose();
            formTable.ShowDialog();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            this.Dispose();
            formAdmin.ShowDialog();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Dispose();
            formLogin.ShowDialog();
        }

        private void FormEditInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
