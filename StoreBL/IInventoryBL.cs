using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IInventoryBL
    {
        Inventory GetItemById(int p_id);
        
        Inventory DecreaseInventory(Inventory p_inv, int p_update);
        
        Inventory ReplenishInventory(Inventory p_inv, int p_rep);

        //List<Stock> AllItemStoreInfo(int p_id);
        List<Inventory> ShowInventory();


    }
}
//Inventory Checkout(Inventory p_inv, int p_update);
//Inventory ReplenishLineById(Inventory p_inv, int p_howMuchAdded);