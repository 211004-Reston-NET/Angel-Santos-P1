using System.Collections.Generic;
using StoreModels;

namespace StoreDL
{
    public interface IRepository
    {
        StoreFront AddStore(StoreFront p_store);
        List<Customer> GetAllCustomers();
        List<Product> GetAllProduct();
        List<StoreFront> GetAllStore();
        Customer AddCustomer(Customer p_customer);
        PurchaseOrder Checkout(PurchaseOrder p_purchase);
        LineItem AddQuantityById(LineItem p_lin);
        Product AddProduct(Product p_product);
        Customer DeleteCustomer(Customer p_customer);
        Inventory GetItemById(int p_id);
        Inventory DecreaseInventory(Inventory p_inv);
        Product GetProductById(int p_id);
        Customer GetCustomerById(int p_id);
        List<Customer> GetCustomerByFirstName(string p_cust);
        List<Customer> GetCustomerByLastName(string p_cust);
    }
}