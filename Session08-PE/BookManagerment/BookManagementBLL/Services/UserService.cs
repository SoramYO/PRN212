using BookManagementDAL.Models;
using BookManagementDAL.Repositories;

namespace BookManagementBLL.Services
{
    public class UserService
    {
        private UserRepository _repo = new();
        public UserAccount? CheckUserLogin(string email, string password)
        {
            return _repo.CheckLogin(email, password);
        }

    }
}
