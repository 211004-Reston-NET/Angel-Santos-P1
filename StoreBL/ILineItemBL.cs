using StoreModels;

namespace StoreBL
{
    public interface ILineItemBL
    {
        /// <summary>
        /// Select and add quantity of item/s for purchase 
        /// </summary>
        /// <param name="p_lin"></param>
        /// <param name="p_howMuchAdded"></param>
        /// <returns></returns>
        LineItem AddQuantityById(LineItem p_lin, int p_howMuchAdded);
    }
}