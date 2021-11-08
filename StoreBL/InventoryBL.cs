using StoreDL;
using StoreModels;

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
        /*public Inventory ReplenishLineById(Inventory p_inv, int p_howMuchAdded)
        {
            p_inv.Quantity += p_howMuchAdded;

            return _repo.ReplenishInv(p_inv);
        }
       */
    }
}