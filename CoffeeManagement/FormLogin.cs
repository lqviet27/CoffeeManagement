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
            //DataProvider.Instance.con.Open();
            string s = "Select * from Account";
            string username = rjTextBoxUsername.Texts;
            string password = rjTextBoxPassword.Texts;
            SqlCommand cmd = new SqlCommand(s, DataProvider.Instance.con);
            DataTable dt = DataProvider.Instance.ExecuteTable(cmd);
            bool checkSuccess = false;
            bool checkExist = false;
            foreach (DataRow i in dt.Rows)
            {
                if (i["UserName"].ToString() == username)
                {
                    if (i["PassWord"].ToString() == password)
                    {
                        checkSuccess = true;
                        checkExist = true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is not correct!");
                        checkExist = true;
                        break;
                    }
                }
            }
            if (!checkExist)
            {
                MessageBox.Show("Account does not exist!");
            }
            if (checkSuccess)
            {
                FormMainMenu formMainMenu = new FormMainMenu();
                this.Hide();
                formMainMenu.ShowDialog();
                this.Show();
            }
            DataProvider.Instance.con.Close();
        }
        private void btn_closed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_hidepass_Click(object sender, EventArgs e)
        {
            pictureBox_visiblepass.Visible = true;
            pictureBox_hidepass.Visible = false;
            rjTextBoxPassword.PasswordChar = false;
        }

        private void pictureBox_visiblepass_Click(object sender, EventArgs e)
        {
            pictureBox_visiblepass.Visible = false;
            pictureBox_hidepass.Visible = true;
            rjTextBoxPassword.PasswordChar = true;
        }

        
    }
}
