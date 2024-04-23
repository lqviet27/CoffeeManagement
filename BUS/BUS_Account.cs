using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    userName = dt["userName"].ToString(),
                    displayName = dt["displayName"].ToString(),
                    password = dt["password"].ToString(),
                    type = dt["type"].ToString()
                });
            }
        }

        public override DataTable Read()
        {
            return DAL_Account.Instance.Read();
        }

        public override void Create(Account model)
        {
            
        }

        public override void Delete(string data)
        {
            
        }

        public override void Update(Account model, string data)
        {
            
        }

    }
}
