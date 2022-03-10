using System.Collections.Generic;
using Shop.Shared;

namespace Shop.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}