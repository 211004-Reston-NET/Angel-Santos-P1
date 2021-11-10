using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IProductBL
    {
        Product AddProduct(Product p_product);
        List<Product> GetAllProducts();
        List<Product> GetProductName(string p_name);
    }
}

//void PrintAllProducts();