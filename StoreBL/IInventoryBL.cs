using StoreModels;

namespace StoreBL
{
    public interface IInventoryBL
    {
        LineItem GetItemById(int p_id);
        LineItem ReplenishLineById(LineItem p_lin, int p_howMuchAdded);
    }
}