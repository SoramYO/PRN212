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

        public void DeleteBook(Book book)
        {
            _repo.Delete(book);
        }
        //hàm search ở search SELECT * FROM BOOK WHERE BOOKNAME LIKE '%keyword%'(AND OR) DESCRIPTION LIKE '%keyword%'
        //== so sánh đúng
        //like  Contains(từ khóa)
        //tên sách trong ram.Contains(từ khóa)
        //không quan tâm hoa thường mới ra được kết quả
        //ta phải đổi tất cả về lowercase hoặc uppercase
        //data - ram phải cùng hoa hết hoặc cùng thường hết
        public List<Book> GetBookByNameAndDescription(string name, string description)
        {
            name = name.ToLower();
            description = description.ToLower();
            //  return _repo.GetAll().Where(mệnh đề where and or trên các cột)
            // return _repo.GetAll().Where(b => b.BookName == ?? && b.Description == ??).ToList();
            //                                                name                   desc
            return _repo.GetAll().Where(b => b.BookName.ToLower().Contains(name) && b.Description.ToLower().Contains(description)).ToList();
        }

    }
}
