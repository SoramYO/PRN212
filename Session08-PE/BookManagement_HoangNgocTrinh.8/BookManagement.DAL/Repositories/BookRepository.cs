using BookManagement.DAL.Models;

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
            return _context.Books.ToList();
        }

    }

}

//Mô hình sử dụng class
//GUI WPF => Service(BLL) => Repository(DAL) => DBContext => DB
//GUI WPF <= Service(BLL) <= Repository(DAL) <= DBContext <= DB
