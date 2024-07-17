using AirConditionerShop.DAL.Models;
using AirConditionerShop.DAL.Repositories;

namespace AirConditionerShop.BLL.Services
{

    public class StaffMemberService
    {
        private StaffMemberRepository _staffMemberRepository = new();

        public StaffMember StaffLogin(string username, string password)
        {
            return _staffMemberRepository.Login(username, password);
        }
    }
}
