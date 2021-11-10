using StoreModels;

namespace StoreBL
{
    public interface IOrderBL
    {
        PurchaseOrder Checkout(PurchaseOrder p_purch);
    }
}
