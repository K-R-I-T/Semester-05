using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        private BookManagementDbContext _context;

        //tạm thời hok có select tất cả user như bên Category
        //CategoryRepository select hết để đổ vào combo, dropdown
        //BookRepo select hết để đổ vào gridview

        //Ở đây chỉ cần select 1 user để check login
        public UserAccount? GetAccount(string email, string password)
        {
            _context = new();
            //_context.UserAccounts.Where(đưa vào hàm lambda nhận vào 1 acc trả về true/false) -> trả về list user thỏa điều kiện nào đó
            //.Select(đưa vào hàm lambda nhận vào 1 acc trả về 1 giá trị) -> trả về 1 giá trị
            //FirstOrDefault() -> trả về giá trị đầu tiên thỏa điều kiện nào đó
            return _context.UserAccounts.FirstOrDefault(acc => acc.Email == email && acc.Password == password);
        }
    }
}
