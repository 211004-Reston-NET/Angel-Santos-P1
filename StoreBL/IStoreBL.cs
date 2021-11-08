using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IStoreBL
    {   
        void PrintAllProducts();
        //void PrintAllInventory();
        StoreFront AddStore(StoreFront p_store);
        List<StoreFront> GetAllStore();
        List<Customer> GetAllCustomers();
        List<Product> GetAllProducts();
        Customer CustomerSignUp(Customer p_customer);
        Product AddProduct(Product p_product);
        List<Product> GetProductName(string p_name);
        List<Customer> GetCustomerName(string p_name);
        List<StoreFront> GetStoreName(string p_name);
        

        //List<Inventory> GetAllLineItemInventory();

        //List<Inventory> GetAllLineItemInventory(Product p_prod);

        //PurchaseOrder AddPurchaseOrder(PurchaseOrder p_order);
    }
}