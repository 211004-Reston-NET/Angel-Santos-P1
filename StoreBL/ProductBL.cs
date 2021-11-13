using System;
using System.Collections.Generic;
using System.Linq;
using StoreDL;
using StoreModels;

namespace StoreBL
{

    public class ProductBL : IProductBL
    {
        private IRepository _repo;
        
        public ProductBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        /*public Product ItemIdCollection(int p_Id)
        {
            return _repo.ItemIdCollection(p_Id);
        }
        */
        public Product AddProduct(Product p_product)
        {
            return _repo.AddProduct(p_product);
        }
        

        public List<Product> GetAllProducts()
        {
            
            List<Product> listOfProduct = _repo.GetAllProduct();
            for (int i = 0; i < listOfProduct.Count; i++)
            //Below sets product names to Uppercase
            {
                listOfProduct[i].ItemName = listOfProduct[i].ItemName.ToUpper(); 
            }

            return listOfProduct;
        }

        public Product GetProductById(int p_id)
        {
           return _repo.GetProductById(p_id);
        }

        

        /*public Product ProductsByStoreId(int p_id)
        {
            List<Product> listOfProduct = _repo.ProductsByStoreId(p_id);
            return listOfProduct.Where(store => store.StoreId.ToLower().Contains(p_name.ToLower())).ToList();

        }

       /*public Tuple<List<Product>, double> ProductsByStoreId(int p_id)
        {
            List<Product> listOfProduct = _repo.ProductByStoreId(p_id);
            double 
            return _repo.ProductsByStoreId(p_storeId);
        }
        */

        public List<Product> GetProductName(string p_name)
        {
            List<Product> listOfProduct = _repo.GetAllProduct();
            return listOfProduct.Where(prod => prod.ItemName.ToLower().Contains(p_name.ToLower())).ToList();
        }

    }
}

/*public void PrintAllProducts()
        {
            List<Product> listOfProduct = GetAllProducts();
                foreach (Product prod in listOfProduct)
                    {
                    Console.WriteLine("====================");
                    Console.WriteLine(prod);
                    Console.WriteLine("====================");
                    }
                    Console.WriteLine("====================");
        }
        */

        //Will select all tables that reference ProductId
        
       /* public Product GetAllProductById(int p_Id)
        {
            List<Product> listOfProduct = _repo.GetAllProductById(p_Id);

            if (prodFound == null)
            {
                throw new Exception("Product was not found!");
            }

            return prodFound;
        }
        */