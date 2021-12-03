using StoreDL;
using StoreModels;
using System.Collections.Generic;
using System.Linq;


namespace StoreBL
{
    public class InventoryBL : IInventoryBL
    {
        private IRepository _repo;
        public InventoryBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
 
    
        public Inventory GetItemById(int p_id)
        {
           return _repo.GetItemById(p_id);
        }

        public Inventory Replenish(Inventory update)
        {
            return _repo.Replenish(update);
        }

    

        public List<Inventory> ShowInventory()
        {
            
            return _repo.ShowInventory();
        
        }

        public List<StoreInvCheck> AllItemStoreInfo(int p_id)
        {
            return _repo.AllItemStoreInfo(p_id);
        }

   
        
    }
}

