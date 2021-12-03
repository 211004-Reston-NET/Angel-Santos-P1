using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IProductBL
    {
        /// <summary>
        /// Add a new product for browsing
        /// </summary>
        /// <param name="p_product"></param>
        /// <returns></returns>
        Product AddProduct(Product p_product);

        /// <summary>
        /// List all products for browsing
        /// </summary>
        /// <returns></returns>
        List<Product> GetAllProducts();

        /// <summary>
        /// Select a product by ID
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        Product GetProductById(int p_id);

        /// <summary>
        /// Select product by name
        /// </summary>
        /// <param name="p_name"></param>
        /// <returns></returns>
        List<Product> GetProductName(string p_name);

        
    }
}

