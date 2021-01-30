using HomeCraft.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeCraft.Data.Services
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductAsync(Guid id);
        void Addproduct(Product productToAdd);
        Task<bool> SaveChangesAsync();
        void DeleteProduct(Product product);

    }
}


