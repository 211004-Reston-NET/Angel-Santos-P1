using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IOrderBL
    {
        
        PurchaseOrder PlaceOrder(PurchaseOrder p_order);
        List<PurchaseOrder> ShowOrders();
        PurchaseOrder GetOrderById(int p_id);
        PurchaseOrder DeleteOrder(PurchaseOrder p_order);
        
    }
}
