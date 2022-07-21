using coursework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.db
{
    partial class TAccount
    {
        public TAccount(Account account)
        {
            Password = account.Password;
            Login = account.Login;
        }

        public bool CompareAccounts(Account account)
        {
            return (
                Password == account.Password &&
                Login == account.Login
            );
        }
    }
}
