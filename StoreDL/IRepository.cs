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
        List<TestClass> AllItemStoreInfo(int p_id);


        /// <summary>
        /// Add new Customer to DB
        /// </summary>
        /// <param name="p_customer">New customer class returned to DB</param>
        /// <returns></returns>
        Customer AddCustomer(Customer p_customer);
       // List<Product> ProductsByStoreId(int p_id);

        /// <summary>
        /// Find Customer by ID to add Order and save to DB
        /// </summary>
        /// <param name="p_order"> An Order added to the list of Orders by Customer ID</param>
        void Checkout(PurchaseOrder p_order);

        List<Inventory> InventoryByStoreId(int p_id);

        List<TestClass> AllItemStoreInfo(int p_id);
        
        LineItem AddQuantityById(LineItem p_lin);

        Product AddProduct(Product p_product);

        List<PurchaseOrder> ShowOrders();

        Customer DeleteCustomer(Customer p_customer);

        Inventory GetItemById(int p_id);

        Inventory DecreaseInventory(Inventory p_inv);

        Product GetProductById(int p_id);

        Customer GetCustomerById(int p_id);

        Inventory ReplenishInventory(Inventory p_inv);
        List<Customer> GetCustomerByFirstName(string p_cust);
        List<Customer> GetCustomerByLastName(string p_cust);
        List<Customer> GetCustomerByNames(string p_cust);
        //List<Customer> GetCustomerByNames(string p_cust, string p_cust1);
    }
}