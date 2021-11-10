using System;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class OrderBL : IOrderBL
    {
        private IRepository _repo;
        
        public OrderBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public PurchaseOrder Checkout(PurchaseOrder p_purc)
            {
            return _repo.Checkout(p_purc);
            }
        /*
        public PurchaseOrder QuantityById(PurchaseOrder p_inv, int p_howMuchAdded)
        {
            p_inv.Quantity += p_howMuchAdded;

            return _repo.ReplenishInv(p_inv);
        }
        */

        
    }
}
