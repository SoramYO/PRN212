using ProductManagementDAL.Models;

namespace ProductManagementDAL.Repositories
{
    public class CategoryRepository
    {

        private ProductManagementContext _context = new();

        public List<Category> Get()
        {
            _context = new ProductManagementContext();
            return _context.Categories.ToList();
        }


    }
}
