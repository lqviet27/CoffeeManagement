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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeeManagement
{
    public partial class FormLogin : Form
    {
        //******
        private List<Account> listAccount = new List<Account>();
        public static string Type;
        public static string Cashier;
        //******
        public FormLogin()
        {
            InitializeComponent();
        }
        private bool checkLogin(string username, string password)
        {
            BUS_Account.Instance.getList(listAccount);
            foreach (Account i in listAccount)
            {
                if (i.userName == username && i.password == password)
                {
                    Type = i.type;
                    Cashier = i.displayName;
                    return true;
                }
            }
            return false;
        }
        private void rjBtn_Login_Click(object sender, EventArgs e)
        {
            //FormMainMenu mainMenu = new FormMainMenu();
            //this.Hide();
            //mainMenu.ShowDialog();
            //this.Show();
            //DataProvider.Instance.con.Open();
            string userName = rjTextBoxUsername.Texts;
            string passWord = rjTextBoxPassword.Texts;
            if (checkLogin(userName, passWord))
            {

                rjTextBoxUsername.Texts = String.Empty;
                rjTextBoxPassword.Texts = String.Empty;
                //Show Form MainMenu
                //MessageBox.Show(Type);
                FormMainMenu mainMenu = new FormMainMenu();
                this.Hide();
                mainMenu.ShowDialog();
                this.Show();
                
            }
            else
            {
                //MessageBox.Show("Your Password or User Name is not correct!");
                lb_invalidInput.Visible = true;
            }
            
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

        private void rjTextBoxUsername__TextChanged(object sender, EventArgs e)
        {
            lb_invalidInput.Visible = false;
        }
    }
}
