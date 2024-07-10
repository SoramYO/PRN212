using MilkTeaManagerDAL.Models;

namespace MilkTeaManagerDAL.Repositories
{
    public class ProductRepository
    {
        private CoffeeContext _context = new CoffeeContext();

        public List<TbProduct> GetAll()
        {
            return _context.TbProducts.ToList();
        }
    }
}
