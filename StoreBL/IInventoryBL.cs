using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IInventoryBL
    {
        Inventory GetItemById(int p_id);

        List<StoreInvCheck> AllItemStoreInfo(int p_id);

        List<Inventory> ShowInventory();

        //void ReplenishInventory(int p_id, int p_stockup);

        Inventory Replenish(Inventory update);

        //StoreInvCheck ManualReplenish(int p_inv, int p_rep);

    }
}
//Inventory Checkout(Inventory p_inv, int p_update);
//Inventory ReplenishLineById(Inventory p_inv, int p_howMuchAdded);