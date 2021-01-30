using HomeCraft.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeCraft.Data.Services
{
    public  class ShoppingCart
    {
        private readonly HomeCraftDbContext _homeCraftDbContext;
        public string ShoppingCartId { get; set; }

        public ShoppingCart(HomeCraftDbContext homeCraftDbContext)
        {
            _homeCraftDbContext = homeCraftDbContext;
        }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = service.GetService<HomeCraftDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product product, int quantity)
        {
            var shoppingCartItem = _homeCraftDbContext.ShoppingCartItems.SingleOrDefault(
               s => s.Product.Id == product.Id && s.ShopingCartId == ShoppingCartId);

            if(shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShopingCartId = ShoppingCartId,
                    Product = product,
                    Quantity = 1
                };
                _homeCraftDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }
            _homeCraftDbContext.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem = _homeCraftDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Product.Id == product.Id && s.ShopingCartId == ShoppingCartId);
            var localQuantity = 0;
            if(shoppingCartItem != null)
            {
                if(shoppingCartItem.Quantity > 1)
                {
                    shoppingCartItem.Quantity++;
                    localQuantity = shoppingCartItem.Quantity;
                }
                else
                {
                    _homeCraftDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
               
            }

            _homeCraftDbContext.SaveChanges();
            return localQuantity;
        }
        
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                (ShoppingCartItems =
                _homeCraftDbContext.ShoppingCartItems.Where(c => c.ShopingCartId == ShoppingCartId)
                .Include(s => s.Product)
                .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _homeCraftDbContext.ShoppingCartItems.
                Where(cart => cart.ShopingCartId == ShoppingCartId);

            _homeCraftDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _homeCraftDbContext.SaveChanges();
        }

        public double GetShoppingCartTotal()
        {
            var total = _homeCraftDbContext.ShoppingCartItems.Where(c => c.ShopingCartId == ShoppingCartId)
            .Select(c => c.Product.Price * c.Quantity).Sum();

            return total;
        }
    }
}
