using HomeCraft.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCraft.WebApp.Controllers.API
{
    public class ShoppingCartController
    {
        private readonly IProductsRepository _productsRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductsRepository productsRepository, ShoppingCart shoppingCart)
        {
            _productsRepository = productsRepository;
            _shoppingCart = shoppingCart;
        }

        

    }
}
 