using System;
using System.Collections.Generic;

namespace Fiap.GeekBurguer.Products.Contract
{
    public class Product
    {
        public string StoreName { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Item> Items { get; set; }
        public decimal Price { get; set; }
    }

    public class Item
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
    }
    public class ProductChanged
    {
        public ProductState State { get; set; }
        public Product Product { get; set; }
    }

    public enum ProductState
    {
        Deleted = 2,
        Modified = 3,
        Added = 4
    }
}
