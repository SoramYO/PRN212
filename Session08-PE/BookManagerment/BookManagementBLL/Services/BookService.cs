using BookManagementDAL.Models;
using BookManagementDAL.Repositories;

namespace BookManagementBLL.Services
{
    public class BookService
    {
        private BookRepository _repo = new();

        public List<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }
        public Book GetBookById(int id)
        {
            return _repo.Get(id);
        }

        public List<Book> SearchBooks(string keyword)
        {
            return _repo.Search(keyword);
        }

        public void AddBook(Book book)
        {
            _repo.Add(book);
        }

        public void UpdateBook(Book book)
        {
            _repo.Update(book);
        }

        public void DeleteBook(int id)
        {
            _repo.Delete(id);
        }
    }
}
