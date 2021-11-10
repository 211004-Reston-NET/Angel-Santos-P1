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

        
        public List<StoreFront> GetAllStore()
        {
           
            return _repo.GetAllStore();
        }
        public List<StoreFront> GetStoreName(string p_name)
        {
            List<StoreFront> listOfStore = _repo.GetAllStore();
            return listOfStore.Where(store => store.StoreName.ToLower().Contains(p_name.ToLower())).ToList();
        }

        //public List<StoreFront> StockInventory(StoreFront s)
        //{
            //foreach
        //}
              
        
        

        


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