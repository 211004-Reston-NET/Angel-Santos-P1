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
       // List<Inventory> GetAllLineItemInventory(Product p_prod);
        Customer AddCustomer(Customer p_customer);
        PurchaseOrder AddPurchase(PurchaseOrder p_purchase);
        LineItem AddQuantityById(LineItem p_lin);
        Product AddProduct(Product p_product);
       // Inventory ReplenishInv(Inventory p_inv);
        Inventory GetItemById(int p_id);
        Product GetProductById(int p_Id);

        Product ItemIdCollection(int p_Id);

        //PurchaseOrder AddPurchaseOrder(PurchaseOrder p_order);
    }
}