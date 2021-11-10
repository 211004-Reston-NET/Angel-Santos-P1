using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IStoreBL
    {   
        
        //void PrintAllInventory();
        StoreFront AddStore(StoreFront p_store);
        List<StoreFront> GetAllStore();
        List<Customer> GetAllCustomers();
        
        Customer CustomerSignUp(Customer p_customer);
        
        
        List<Customer> GetCustomerName(string p_name);
        List<StoreFront> GetStoreName(string p_name);
        

        //List<Inventory> GetAllLineItemInventory();

        //List<Inventory> GetAllLineItemInventory(Product p_prod);

        //PurchaseOrder AddPurchaseOrder(PurchaseOrder p_order);
    }
}