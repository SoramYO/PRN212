using BookManagementDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagementDAL.Repositories
{
    public class BookRepository
    {
        private BookManagementDbContext _context = new();

        public List<Book> GetAll()
        {
            _context = new BookManagementDbContext();
            return _context.Books.Include("BookCategory").ToList();
        }

        public Book Get(int id)
        {
            return _context.Books.Include(b => b.BookCategory)
                                 .FirstOrDefault(b => b.BookId == id);
        }

        public List<Book> Search(string keyword)
        {
            return _context.Books.Include(b => b.BookCategory)
                                 .Where(b => b.BookName
                                 .Contains(keyword)
                                 || b.Description
                                 .Contains(keyword))
                                 .ToList();
        }

        public void Add(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public void Update(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context = new BookManagementDbContext();
            var book = _context.Books.FirstOrDefault(b => b.BookId == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
