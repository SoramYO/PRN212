using BookManagementDAL.Models;
using BookManagementDAL.Repositories;

namespace BookManagementBLL.Services
{
    public class CategoryService
    {
        private CategoryRepository _repo = new();

        public List<BookCategory> GetAllCategories()
        {
            return _repo.GetAll();
        }
    }
}
