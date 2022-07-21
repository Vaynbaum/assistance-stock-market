using coursework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.Factories
{
    public class AccountFactory
    {
        public Account Create(string login, string password)
        {
            Account account = new Account()
            {
                Login = login,
                Password = password,
            };
            return account;
        }
    }
}
