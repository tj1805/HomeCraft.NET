using HomeCraft.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeCraft.Data.Services
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly HomeCraftDbContext _homeCraftDbContext;

        public ProductsRepository(HomeCraftDbContext homeCraftDbContext)
        {
            _homeCraftDbContext = homeCraftDbContext ?? throw new ArgumentNullException(nameof(homeCraftDbContext));
        }
        public void Addproduct(Product productToAdd)
        {
            if (productToAdd == null)
            {
                throw new ArgumentNullException(nameof(productToAdd));
            }
            _homeCraftDbContext.Add(productToAdd);

        }

        public void DeleteProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _homeCraftDbContext.Products.Remove(product);
        }

        public async Task<Product> GetProductAsync(Guid id)
        {
            return await _homeCraftDbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _homeCraftDbContext.Products.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _homeCraftDbContext.SaveChangesAsync() > 0);
        }
    }
}
