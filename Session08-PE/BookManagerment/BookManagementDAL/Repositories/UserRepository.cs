using BookManagementDAL.Models;

namespace BookManagementDAL.Repositories
{
    public class UserRepository
    {
        public UserAccount? CheckLogin(string email, string password)
        {
            _context = new();

            return _context.UserAccounts
                           .FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
