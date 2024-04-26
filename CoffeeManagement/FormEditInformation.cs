using BUS;
using Model;
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
    public partial class FormEditInformation : Form

    {
        List<Account> listAccount = new List<Account>();
        Account currAccount;
        public FormEditInformation()
        {
            InitializeComponent();
            LoadCasier();
        }
        private void LoadCasier()
        {
            BUS_Account.Instance.getList(listAccount);
            foreach (Account i in listAccount)
            {
                if (i.userName.Equals(FormLogin.UserNameCashier))
                {
                    currAccount = i;
                    txt_DisplayName.Text = i.displayName;
                    txt_UserName.Text = i.userName;
                }
            }
        }
        private bool checkPassword(string password)
        {
            if (currAccount.password.Equals(password))
            {
                return true;
            }
            return false;
        }

        private void btn_ChangeName_Click(object sender, EventArgs e)
        {
            currAccount.displayName = tb_DisplayName.Texts;
            currAccount.userName = tb_UserName.Texts;
            BUS_Account.Instance.Update(currAccount, FormLogin.UserNameCashier);
            FormLogin.UserNameCashier = currAccount.userName;
            MessageBox.Show("Change Information Success");
            LoadCasier();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            if (checkPassword(tb_OldPassword.Texts))
            {
                if (tb_NewPasword.Texts.Equals(tb_ComfirmPassword.Texts))
                {
                    currAccount.password = tb_NewPasword.Texts;
                    BUS_Account.Instance.Update(currAccount, FormLogin.UserNameCashier);
                    MessageBox.Show("Change Password Success");
                    LoadCasier();
                }
                else
                {
                    MessageBox.Show("New Password and Confirm Password are not the same");
                }
            }
            else
            {
                MessageBox.Show("Password is not correct");
            }
        }

        private void btn_CancelChangeName_Click(object sender, EventArgs e)
        {
            tb_DisplayName.Texts = "";
            tb_UserName.Texts = "";
        }

        private void btn_CancelChangePassword_Click(object sender, EventArgs e)
        {
            tb_OldPassword.Texts = "";
            tb_NewPasword.Texts = "";
            tb_ComfirmPassword.Texts = "";
        }
    }
}
