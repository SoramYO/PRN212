using BookManagement.DAL.Models;
using BookManagement.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.BLL.Services
{
    public class CategoryService
    {
        public CategoryRepository _repo = new();//new luôn ko sợ do trong repo tự new dbcontext

        public List<BookCategory> GetAllCategories()
        {
            return _repo.GetAll();
        }
    }
}
