using MilkTeaManagerDAL.Repositories;

namespace MilkTeaManagerBLL.Services
{
    public class LoginService
    {
        private LoginRepository _repo = new LoginRepository();

        public LoginService(string username, string password)
        {
            _repo.GetLogin(username, password);
        }
    }
}
