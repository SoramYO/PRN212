using BookManagementDAL.Models;

namespace BookManagementDAL.Repositories
{
    public class UserRepository
    {
        private BookManagementDbContext _context = new();

        public UserAccount? CheckLogin(string email, string password)
        {
            return _context.UserAccounts
                           .FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
