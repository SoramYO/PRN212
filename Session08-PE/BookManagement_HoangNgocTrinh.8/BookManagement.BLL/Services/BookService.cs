using BookManagement.DAL.Models;
using BookManagement.DAL.Repositories;

namespace BookManagement.BLL.Services
{
    //GUI WPF -> Service(BLL) -> Repository(DAL) -> DBContext -> DB
    //class này lại cũng là 1 dạng cabinet nhưng chỉ chơi với table book
    //nook chơi trong ram và tính toán gì đó trở lại GUI hoặc lấy từ GUI xuống repository => từ đó xuống DbContext rồi xuống table
    //nó sẽ bị gọi bởi class GUI
    //nhưng nó sẽ gọi class repo cần khai báo biến repo
    public class BookService
    {
        private BookRepository _repo = new(); //new luôn



        //các hàm crud book trong ram đều nhờ cậy từ repo
        //đặt tên hàm 
        public List<Book> GetAllBooks()
        {
            return _repo.GetAll(); //phân trang sort trước khi trả về ...

        }
        //nhận cuốn sách từ GUI và đưa xuống repo
        public void CreateBook(Book book)
        {
            _repo.Create(book);
        }


    }
}
