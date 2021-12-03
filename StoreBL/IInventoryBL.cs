using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IInventoryBL
    {
        /// <summary>
        /// Select Inventory item by ID
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        Inventory GetItemById(int p_id);

        /// <summary>
        /// Select and list -all inventories -all stores
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<StoreInvCheck> AllItemStoreInfo(int p_id);

        /// <summary>
        /// List inventory items for a select store.
        /// </summary>
        /// <returns></returns>
        List<Inventory> ShowInventory();

        /// <summary>
        /// Replenish/update inventory items for a select store
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        Inventory Replenish(Inventory update);

        

    }
}
