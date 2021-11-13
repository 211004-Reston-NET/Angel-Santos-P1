using StoreDL;
using StoreModels;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        

        public Inventory DecreaseInventory(Inventory p_inv, int p_dec)
        {
           
            p_inv.Quantity -= p_dec;

            return _repo.DecreaseInventory(p_inv);
        }

        public Inventory ReplenishInventory(Inventory p_inv, int p_rep)
        {
            p_inv.Quantity += p_rep;

            return _repo.ReplenishInventory(p_inv);
        }

        public List<Inventory> ShowInventory()
        {
            
            return _repo.ShowInventory();
        
        }

        public List<Inventory> AllItemStoreInfo(int p_id)
        {
            return _repo.AllItemStoreInfo(p_id);
        }
        
        
    }
}

