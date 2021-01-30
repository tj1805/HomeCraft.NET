using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCraft.Core.Models
{
    public class ShoppingCartItem
    {
        public Guid Id { get; set; }
        public string ShopingCartId { get; set; }
        public int ShoppingCartItemid { get; set; }
        // number of individual product
        public int Quantity { get; set; }
        // individual pie added ///Amount
        public Product Product { get; set; }
    }
}
