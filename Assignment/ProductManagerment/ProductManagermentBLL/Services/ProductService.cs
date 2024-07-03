using ProductManagementDAL.Models;
using ProductManagementDAL.Repositories;

namespace ProductManagermentBLL.Services
{
    public class ProductService
    {
        private ProductRepository _repo = new();
        public List<Product> GetAllProduct()
        {
            return _repo.Get();
        }
        public void AddProduct(Product product)
        {
            _repo.Add(product);
        }
        public void UpdateProduct(Product product)
        {
            _repo.Update(product);
        }
        public void DeleteProduct(Guid id)
        {
            _repo.Delete(id);
        }

    }
}
