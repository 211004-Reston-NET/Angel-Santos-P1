using System.Collections.Generic;
using StoreModels;

namespace StoreDL
{
    public interface IRepository
    {
        /// <summary>
        /// Add New Store to DB
        /// </summary>
        /// <param name="p_store">New store class returned to DB</param>
        /// <returns></returns>
        StoreFront AddStore(StoreFront p_store);

        StoreFront StoreById(int p_id);

        /// <summary>
        /// Return list of customers in DB
        /// </summary>
        /// <returns></returns>
        List<Customer> GetAllCustomers();
        

        /// <summary>
        /// Return list of products in DB
        /// </summary>
        /// <returns></returns>
        List<Product> GetAllProducts();

        /// <summary>
        /// Return list of Stores in DB
        /// </summary>
        /// <returns></returns>
        List<StoreFront> GetAllStore();
        

        /// <summary>
        /// Return list of Inventory in DB
        /// </summary>
        /// <returns></returns>
        List<Inventory> ShowInventory();
        
        /// <summary>
        /// Add new Customer to DB
        /// </summary>
        /// <param name="p_customer">New customer class returned to DB</param>
        /// <returns></returns>
        Customer AddCustomer(Customer p_customer);
       // List<Product> ProductsByStoreId(int p_id);

        
        List<Inventory> InventoryByStoreId(int p_id);

        List<StoreInvCheck> AllItemStoreInfo(int p_id);
        
        LineItem AddQuantityById(LineItem p_lin);

        Product AddProduct(Product p_product);

        Inventory Replenish(Inventory update);

        Customer DeleteCustomer(Customer p_customer);

        Inventory GetItemById(int p_id);

        Product GetProductById(int p_id);

        PurchaseOrder GetOrderById(int p_id);

        PurchaseOrder DeleteOrder(PurchaseOrder p_order);

        List<PurchaseOrder> ShowOrders();

        PurchaseOrder PlaceOrder(PurchaseOrder p_ord);

        Customer GetCustomerById(int p_id);

        List<Customer> GetCustomerByFirstName(string p_cust);

        List<Customer> GetCustomerByLastName(string p_cust);

        List<Customer> GetCustomerByNames(string p_cust);
      
    }
}