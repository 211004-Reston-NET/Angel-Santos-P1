using StoreModels;

namespace StoreBL
{
    public interface IInventoryBL
    {
        Inventory GetItemById(int p_id);
        //Inventory ReplenishLineById(Inventory p_inv, int p_howMuchAdded);
    }
}