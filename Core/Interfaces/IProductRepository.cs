using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAysnc(int id);
         Task<IReadOnlyList<Product>> GetProductdAysnc();
         Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
         Task<IReadOnlyList<ProductType>> GetProductsTypesAsync();
         
    }
}