using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IProductBL
    {
        Product AddProduct(Product p_product);
        List<Product> GetAllProducts();

        Product GetProductById(int p_id);
        List<Product> GetProductName(string p_name);

        
       // Product ProductsByStoreId(int p_id);
    }
}

//void PrintAllProducts();