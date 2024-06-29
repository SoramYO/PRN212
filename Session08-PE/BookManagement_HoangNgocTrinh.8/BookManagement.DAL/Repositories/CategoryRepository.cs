using BookManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.Repositories
{
    public class CategoryRepository
    {
        //class này chính là cabinet nhưng chỉ chơi với category
        //nó cần nhờ đến DbContext để thao tác với db
        //GUI WPF -> Service(BLL) -> Repository(DAL) -> DBContext -> DB
        //nhớ new _context mỗi lần thao tác với db
        private BookManagementDbContext _context;

        public List<BookCategory> GetAll()
        {
            _context = new();
            return _context.BookCategories.ToList(); //ta không join vì chỉ cần select * from category
        }
    }
}
