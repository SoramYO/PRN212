using Microsoft.EntityFrameworkCore;
using ProductManagementDAL.Models;

namespace ProductManagementDAL.Repositories
{
    public class ProductRepository
    {
        private ProductManagementContext _context = new();

        public List<Product> Get()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }

        public void Add(Product product)
        {
            _context = new ProductManagementContext();
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public void Update(Product product)
        {
            _context = new ProductManagementContext();
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        public void Delete(Guid id)
        {
            _context = new ProductManagementContext();
            Product product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

    }
}
