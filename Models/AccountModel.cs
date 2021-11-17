using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;

namespace Models
{
    public class AccountModel   
    {
        private NatusVincenzoDbContext context = null;

        public AccountModel()
        {
            context = new NatusVincenzoDbContext();
        }
        public bool Login(string username, string password)
        {
            object[] sqlParam = 
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };
            var res = context.Database.SqlQuery<bool>("SP_Account_Login @Username,@Password", sqlParam).SingleOrDefault();
            return res;
        }
    }
}
