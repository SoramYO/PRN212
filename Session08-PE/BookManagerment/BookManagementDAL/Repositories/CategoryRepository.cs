using BookManagementDAL.Models;

namespace BookManagementDAL.Repositories
{
    public class CategoryRepository
    {
        private BookManagementDbContext? _context;

        public List<BookCategory> GetAll()
        {
            _context = new BookManagementDbContext();
            return _context.BookCategories.ToList();
        }
    }
}
