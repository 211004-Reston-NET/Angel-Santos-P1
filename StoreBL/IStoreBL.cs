using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IStoreBL
    {   
        
        /// <summary>
        /// Add a new store front
        /// </summary>
        /// <param name="p_store"></param>
        /// <returns></returns>
        StoreFront AddStore(StoreFront p_store);

        /// <summary>
        /// List all store fronts
        /// </summary>
        /// <returns></returns>
        List<StoreFront> GetAllStore();
        
        /// <summary>
        /// Get a store by name
        /// </summary>
        /// <param name="p_name"></param>
        /// <returns></returns>
        List<StoreFront> GetStoreName(string p_name);

        /// <summary>
        /// Select Store Id and list inventory items information
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<Inventory> InventoryByStoreId(int p_id);
        
        
    }
}

