using AirConditionerShop.DAL.Models;
using AirConditionerShop.DAL.Repositories;

namespace AirConditionerShop.BLL.Services
{
    public class SupplierCompanyService
    {
        private SupplierCompanyRepository _repo = new();

        public List<SupplierCompany> GetAllSupplierCompany()
        {
            return _repo.GetAll();
        }
    }
}
