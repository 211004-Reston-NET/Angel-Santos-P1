using StoreModels;

namespace StoreBL
{
    public interface IInventoryBL
    {
        Inventory GetItemById(int p_id);
        Inventory DecreaseInventory(Inventory p_inv, int p_update);
        Inventory ReplenishInventory(Inventory p_inv, int p_rep);
        
    }
}
//Inventory Checkout(Inventory p_inv, int p_update);
//Inventory ReplenishLineById(Inventory p_inv, int p_howMuchAdded);