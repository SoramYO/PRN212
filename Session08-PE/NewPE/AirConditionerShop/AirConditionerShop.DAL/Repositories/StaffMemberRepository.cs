using AirConditionerShop.DAL.Models;

namespace AirConditionerShop.DAL.Repositories
{

    public class StaffMemberRepository
    {
        private AirConditionerShop2024DbContext _context;
        public StaffMember Login(string username, string password)
        {
            _context = new AirConditionerShop2024DbContext();
            return _context.StaffMembers.FirstOrDefault(x => x.EmailAddress == username && x.Password == password);
        }
    }
}
