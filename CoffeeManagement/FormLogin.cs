using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void rjBtn_Login_Click(object sender, EventArgs e)
        {
            //FormMainMenu mainMenu = new FormMainMenu();
            //this.Hide();
            //mainMenu.ShowDialog();
            //this.Show();
            DataProvider.Instance.con.Open();
            MessageBox.Show(DataProvider.Instance.con.State.ToString());
        }
        private void btn_closed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_hidepass_Click(object sender, EventArgs e)
        {
            pictureBox_visiblepass.Visible = true;
            pictureBox_hidepass.Visible = false;
            rjTextBox6.PasswordChar = false;
        }

        private void pictureBox_visiblepass_Click(object sender, EventArgs e)
        {
            pictureBox_visiblepass.Visible = false;
            pictureBox_hidepass.Visible = true;
            rjTextBox6.PasswordChar = true;
        }

        
    }
}
