using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IOrderBL
    {

        /// <summary>
        /// Complete an order ie. checkout -order update  
        /// </summary>
        /// <param name="p_order"></param>
        /// <returns></returns>
        PurchaseOrder PlaceOrder(PurchaseOrder p_order);

        /// <summary>
        /// Display order history
        /// </summary>
        /// <returns></returns>
        List<PurchaseOrder> ShowOrders();

        /// <summary>
        /// Select order by ID
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        PurchaseOrder GetOrderById(int p_id);

        /// <summary>
        /// Delete order ie. transaction
        /// </summary>
        /// <param name="p_order"></param>
        /// <returns></returns>
        PurchaseOrder DeleteOrder(PurchaseOrder p_order);
        
    }
}
