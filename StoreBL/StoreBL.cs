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

        //Add Methods
        public StoreFront AddStore(StoreFront p_store)
        {
            return _repo.AddStore(p_store);
        }


        //AKA Add Customer 
        public Customer CustomerSignUp(Customer p_customer)
            {
            return _repo.AddCustomer(p_customer);
            }
        
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