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
    
        public LineItem GetItemById(int p_id)
        {
           return _repo.GetItemById(p_id);
        }
        public LineItem ReplenishLineById(LineItem p_lin, int p_howMuchAdded)
        {
            p_lin.Inventory += p_howMuchAdded;

            return _repo.ReplenishLine(p_lin);
        }
       
    }
}