using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IStoreBL
    {   
        
        StoreFront AddStore(StoreFront p_store);
        List<StoreFront> GetAllStore();
        List<StoreFront> GetStoreName(string p_name);

    }
}

//List<Inventory> GetAllLineItemInventory();

        //List<Inventory> GetAllLineItemInventory(Product p_prod);

        //PurchaseOrder AddPurchaseOrder(PurchaseOrder p_order);