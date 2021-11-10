using StoreModels;

namespace StoreBL
{
    public interface ILineItemBL
    {
        LineItem AddQuantityById(LineItem p_lin, int p_howMuchAdded);
    }
}