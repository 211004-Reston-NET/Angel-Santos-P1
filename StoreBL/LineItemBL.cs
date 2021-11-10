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

        //public LineItem Checkout(LineItem p_lin, Inventory p_inv)
        //{
            
        //}
        //{
            /*

            var checkout = from quantity in lineitems
                        join  in Inventory on Inventory.Prod_Id equals LineItems.Prod_Id
                        select new { quantity = quantity, _context = Inventories};

            foreach (var quantity in checkout)
            {
                LineItems.quantity("value")  = Inventory.Inventories.quantity;
            }

            */
            /*
            
            Update Inventory
            SET LineItem.Quantity -= Inventory.Quantity
            FROM Inventory
            JOIN Line_Item l ON i.Prod_Id=l.Prod_Id;

            */
        //}

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
