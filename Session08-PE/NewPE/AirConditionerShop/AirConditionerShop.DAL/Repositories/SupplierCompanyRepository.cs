using AirConditionerShop.DAL.Models;

namespace AirConditionerShop.DAL.Repositories
{
    public class SupplierCompanyRepository
    {
        private AirConditionerShop2024DbContext _context;

        public List<SupplierCompany> GetAll()
        {
            _context = new();
            return _context.SupplierCompanies.ToList();
        }
    }
}
