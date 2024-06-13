using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Account : BUS<BUS_Account, Account, string>
    {
        public override void getList(List<Account> list)
        {
            list.Clear();
            
            foreach(DataRow dt in Read().Rows)
            {
                list.Add(new Account{ 
                    userName = dt["UserName"].ToString(),
                    displayName = dt["DisplayName"].ToString(),
                    password = dt["PassWord"].ToString(),
                    type = dt["Type"].ToString()
                });
            }
        }

        public override DataTable Read()
        {
            return DAL_Account.Instance.Read();
        }

        public override void Create(Account model)
        {
            DAL_Account.Instance.Create(model);
        }

        public override void Delete(string data)
        {
            DAL_Account.Instance.Delete(data);
        }

        public override void Update(Account model, string data)
        {
            DAL_Account.Instance.Update(model, data);
        }
        public void ShowDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = ReadNotPassord();
        }
        public DataTable ReadNotPassord()
        {
            return DAL_Account.Instance.ReadNotPassword();
        }
        //public void ShowDGV(DataGridView dgv)
        //{
        //    dgv.DataSource = null;
        //    dgv.Rows.Clear();
        //    dgv.DataSource = this.Read();
        //}
        public string GetPassword(string userName)
        {
            string password = "";
            foreach (DataRow dt in Read().Rows)
            {
                if (dt["UserName"].ToString() == userName)
                {
                    password = dt["PassWord"].ToString();
                    break;
                }
            }
            return password;
        }
    }
}
