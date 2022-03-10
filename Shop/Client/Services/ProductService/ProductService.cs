using System.Collections.Generic;
using Shop.Shared;

namespace Shop.Client.Services.ProductService
{
    public class ProductService:IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public void LoadProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}