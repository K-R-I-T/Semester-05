using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountService
    {
        private UserAccountRepository _repo = new();

        public UserAccount? CheckLogin(string email, string password)
        {
            return _repo.GetAccount(email, password);
        }
    }
}
