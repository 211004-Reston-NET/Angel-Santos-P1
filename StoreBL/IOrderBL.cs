using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IOrderBL
    {
        void Checkout(PurchaseOrder p_order);
        PurchaseOrder PlaceOrder(PurchaseOrder p_order);
        public List<PurchaseOrder> ShowOrders();
        //PurchaseOrder Checkout(PurchaseOrder p_purch);
        //IEnumerable<PurchaseOrder> Sale(PurchaseOrder p_sale);
    }
}
