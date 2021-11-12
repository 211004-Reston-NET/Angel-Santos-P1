using System.Collections.Generic;
using StoreModels;

namespace StoreDL
{
    public interface IRepository
    {
        StoreFront AddStore(StoreFront p_store);
        List<Customer> GetAllCustomer();
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

        // List<Inventory> GetAllLineItemInventory(Product p_prod);
        //Product ItemIdCollection(int p_id);

        // Inventory ReplenishInv(Inventory p_inv);

        //PurchaseOrder AddPurchaseOrder(PurchaseOrder p_order);
    }
}