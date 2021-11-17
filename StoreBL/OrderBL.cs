using System;
using StoreDL;
using StoreModels;
using System.Linq;
using System.Collections.Generic;

namespace StoreBL
{
    public class OrderBL : IOrderBL
    {
        private IRepository _repo;
        
        public OrderBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

                
        public PurchaseOrder PlaceOrder(PurchaseOrder p_order)
        {
            return _repo.PlaceOrder(p_order);
        }

        public List<PurchaseOrder> ShowOrders()
        {
            return _repo.ShowOrders();
        }

        public PurchaseOrder GetOrderById(int p_id)
        {
            return _repo.GetOrderById(p_id);
        }

        public PurchaseOrder DeleteOrder(PurchaseOrder p_order)
        {
            return _repo.DeleteOrder(p_order);
        }

        
    }
}
