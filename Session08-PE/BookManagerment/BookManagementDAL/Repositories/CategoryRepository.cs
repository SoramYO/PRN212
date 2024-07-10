using BookManagementDAL.Models;

namespace BookManagementDAL.Repositories
{
    public class CategoryRepository
    {
        private BookManagementDbContext _context = new();

        public List<BookCategory> GetAll()
        {
            return _context.BookCategories.ToList();
        }
    }
}
