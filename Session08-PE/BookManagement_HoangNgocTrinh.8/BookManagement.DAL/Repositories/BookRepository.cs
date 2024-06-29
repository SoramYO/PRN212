using BookManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.DAL.Repositories
{
    //class nay dong vvai book cabinet đã học
    //nó có các hàm crud table book
    //nhưng mình k cần viết câu sql mà chỉ đi gọi Đại sứ db chính là object từ class db context
    //                      db context là cabinet nhưng chơi thẳng với db do bên trong nó có chuỗi kết nối csdl
    //class repo chính là cabinet nhưng chỉ chơi 1 table book
    //cài cho nguyên lí S trong solid
    //class này phải khai báo biến db context và có các hàm CRUD table book
    //vì chơi trực tiếp table  -> thuộc level layer DAL Data Access Layer
    public class BookRepository
    {
        private BookManagementDbContext _context; //lúc nào thao tác table mới new
        //List<Book> _arr = new();
        //           _arr.Add(new Book(){   });

        //crud method với table book
        //tên hàm ngắn gọn mang ý nghĩa của CRUD table

        public List<Book> GetAll()
        {
            _context = new BookManagementDbContext();

            //select từ cuốn sách trong table new Book() và add vào List<Book> 
            //Nhưng lười k join k có new category nên trong cuốn sách để đảm bảo performance
            //nếu ta muốn lấy luôn category thì phải join
            //toán từ Include<Biến trỏ đến table cần join>
            //biến này gọi là navigation path đường giúp sang table khác

            //return _context.Books.ToList();
            return _context.Books.Include("BookCategory").ToList();
            //đã join sang table BookCategory qua biến BookCategory {get;set;}
        }

        public void Create(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Add(book);
            _context.SaveChanges();
        }//đã xong insert cuốn mới từ GUI đưa xuống vì từ
        //GUI gọi service gọi repo gọi dbcontext gọi db
        //Tương tự ta có hàm Update, Delete(Book book), Delete(int id)
        //remove 1 object từ List hoặc remove theo PK where id
    }

}

//Mô hình sử dụng class
//GUI WPF => Service(BLL) => Repository(DAL) => DBContext => DB
//GUI WPF <= Service(BLL) <= Repository(DAL) <= DBContext <= DB
