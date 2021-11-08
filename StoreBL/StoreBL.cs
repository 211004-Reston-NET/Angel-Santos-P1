using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;
using System.Linq;

namespace StoreBL
{
    public class StoreFrontBL : IStoreBL
    {
        private IRepository _repo;
        
        public StoreFrontBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        
        

        public void PrintAllProducts()
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

        //public void PrintAllInventory()
        /*{
            List<LineItem> listOfLine = _storeBL.GetAllLineItemInventory(ShowRestaurant._findRestName);

            foreach (LineItem lin in listOfLine)
            {
                Console.WriteLine("====================");
                Console.WriteLine(lin);
                Console.WriteLine("====================");
            }
        }
        */


        //Add Methods
        public StoreFront AddStore(StoreFront p_store)
        {
            return _repo.AddStore(p_store);
        }

        public Product AddProduct(Product p_product)
        {
            return _repo.AddProduct(p_product);
        }

        //AKA Add Customer 
        public Customer CustomerSignUp(Customer p_customer)
            {
            return _repo.AddCustomer(p_customer);
            }
        
        
        /*public List<Inventory> GetAllLineItemInventory(Product p_prod)
        {
              return _repo.GetAllLineItemInventory(p_prod);
        }
        */
        public List<StoreFront> GetAllStore()
        {
           
            List<StoreFront> listOfStore = _repo.GetAllStore();
            for (int i = 0; i < listOfStore.Count; i++)
            {
                listOfStore[i].StoreName = listOfStore[i].StoreName.ToUpper(); 
            }

            return listOfStore;
        }
        public List<StoreFront> GetStoreName(string p_name)
        {
            List<StoreFront> listOfStore = _repo.GetAllStore();
            return listOfStore.Where(store => store.StoreName.ToLower().Contains(p_name.ToLower())).ToList();
        }
        public List<Customer> GetAllCustomers()
        {
            
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            for (int i = 0; i < listOfCustomer.Count; i++)
            {
                listOfCustomer[i].FirstName = listOfCustomer[i].FirstName.ToUpper(); 
            }

            return listOfCustomer;
        
        }
        public List<Customer> GetCustomerName(string p_customerfname)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            return listOfCustomer.Where(cust => cust.FirstName.ToLower().Contains(p_customerfname.ToLower())).ToList();
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
        public List<Product> GetProductName(string p_name)
        {
            List<Product> listOfProduct = _repo.GetAllProduct();
            return listOfProduct.Where(prod => prod.ItemName.ToLower().Contains(p_name.ToLower())).ToList();
        }

        


        /*      
        public PurchaseOrder AddPurchaseOrder(PurchaseOrder p_order)
        {
            return _repo.AddPurchaseOrder(p_order);
        }
        public List<Product> GetProductCategory(string p_category)
        {
            List<Product> listOfProduct = _repo.GetAllProduct();
            return listOfProduct.Where(prod => prod.Category.ToLower().Contains(p_category.ToLower())).ToList();
        }
        */
    }
}