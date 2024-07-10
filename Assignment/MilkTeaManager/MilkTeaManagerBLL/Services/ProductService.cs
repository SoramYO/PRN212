using MilkTeaManagerDAL.Models;
using MilkTeaManagerDAL.Repositories;

namespace MilkTeaManagerBLL.Services
{
    public class ProductService
    {
        private ProductRepository _productRepository = new ProductRepository();

        public List<TbProduct> GetAllProduct()
        {
            return _productRepository.GetAll();
        }
    }
}
