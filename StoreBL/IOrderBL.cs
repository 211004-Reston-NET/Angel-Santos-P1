using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IOrderBL
    {
        void Checkout(PurchaseOrder p_order);
        //PurchaseOrder Checkout(PurchaseOrder p_purch);
        //IEnumerable<PurchaseOrder> Sale(PurchaseOrder p_sale);
    }
}
