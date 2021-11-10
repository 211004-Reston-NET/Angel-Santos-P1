using System;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class LineItemBL : ILineItemBL 
    {
        private IRepository _repo;
        
        public LineItemBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public LineItem AddQuantityById(LineItem p_lin, int p_howMuchAdded)
        {
            p_lin.Quantity += p_howMuchAdded;

            return _repo.AddQuantityById(p_lin);
        }

        /*public PurchaseOrder AddPurchaseOrder(PurchaseOrder p_purch)
        {
            throw
            {
                Console.WriteLine("Not Implemented");
            }

        }
        */
        
    }
}
