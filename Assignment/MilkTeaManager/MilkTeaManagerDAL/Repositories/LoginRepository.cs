using MilkTeaManagerDAL.Models;

namespace MilkTeaManagerDAL.Repositories
{
    public class LoginRepository
    {
        private CoffeeContext _context = new CoffeeContext();

        public Login GetLogin(string username, string password)
        {
            return _context.Logins.SingleOrDefault(x => x.UserName == username && x.Password == password);
        }
    }
}
