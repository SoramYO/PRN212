using ProductManagementDAL.Models;
using ProductManagementDAL.Repositories;

namespace ProductManagermentBLL.Services
{
    public class CategoryService
    {
        public CategoryRepository _repo = new();

        public List<Category> GetAllCategory()
        {
            return _repo.Get();
        }
    }
}
