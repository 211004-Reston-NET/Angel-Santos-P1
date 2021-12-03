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
       

        /// <summary>
        /// Check inventory selected store inventory by ID
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<Inventory> InventoryByStoreId(int p_id);

        /// <summary>
        /// Select all stores, inventory, and product information 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<StoreInvCheck> AllItemStoreInfo(int p_id);
        
        /// <summary>
        /// Select an item by ID and add a specified amount -cart
        /// </summary>
        /// <param name="p_lin"></param>
        /// <returns></returns>
        LineItem AddQuantityById(LineItem p_lin);

        /// <summary>
        /// Add a new product for browsing
        /// </summary>
        /// <param name="p_product"></param>
        /// <returns></returns>
        Product AddProduct(Product p_product);

        /// <summary>
        /// Replenish a store inventory
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        Inventory Replenish(Inventory update);

        /// <summary>
        /// Delete a customer's information
        /// </summary>
        /// <param name="p_customer"></param>
        /// <returns></returns>
        Customer DeleteCustomer(Customer p_customer);

        /// <summary>
        /// Slect an inventory item by ID
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        Inventory GetItemById(int p_id);

        /// <summary>
        /// Select a product by ID
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        Product GetProductById(int p_id);

        /// <summary>
        /// Select an order history by ID
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        PurchaseOrder GetOrderById(int p_id);

        /// <summary>
        /// Delete an order history by ID
        /// </summary>
        /// <param name="p_order"></param>
        /// <returns></returns>
        PurchaseOrder DeleteOrder(PurchaseOrder p_order);

        /// <summary>
        /// Show a list of order history
        /// </summary>
        /// <returns></returns>
        List<PurchaseOrder> ShowOrders();

        /// <summary>
        /// Finalize/checkout an order
        /// </summary>
        /// <param name="p_ord"></param>
        /// <returns></returns>
        PurchaseOrder PlaceOrder(PurchaseOrder p_ord);

        /// <summary>
        /// Slect a customer by ID
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        Customer GetCustomerById(int p_id);

        /// <summary>
        /// Select customer by first name 
        /// </summary>
        /// <param name="p_cust"></param>
        /// <returns></returns>
        List<Customer> GetCustomerByFirstName(string p_cust);
        
        /// <summary>
        /// Select a customer by last name 
        /// </summary>
        /// <param name="p_cust"></param>
        /// <returns></returns>
        List<Customer> GetCustomerByLastName(string p_cust);

        /// <summary>
        /// Select a customer by first and last names
        /// </summary>
        /// <param name="p_cust"></param>
        /// <returns></returns>
        List<Customer> GetCustomerByNames(string p_cust);
      
    }
}