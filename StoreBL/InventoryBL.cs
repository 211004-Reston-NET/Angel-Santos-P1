using StoreDL;
using StoreModels;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace StoreBL
{
    public class InventoryBL : IInventoryBL
    {
        private IRepository _repo;
        public InventoryBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
    
        public Inventory GetItemById(int p_id)
        {
           return _repo.GetItemById(p_id);
        }

        public Inventory DecreaseInventory(Inventory p_inv, int p_update)
        {
           
            p_inv.Quantity -= p_update;

            return _repo.DecreaseInventory(p_inv);
        }

        //public Inventory Checkout(Inventory p_inv, int p_update)
        //{
            /*
            var joins = from quantity in lineitems
                        join  in db_materials on material.Number equals db_material.Number
                        select new { material = material, db = db_material};

            foreach (var join in joins)
            {
                join.material.Value  = join.db.ValueColumn;
            }
            */
            /*
            Update Inventory
            SET LineItem.Quantity -= Inventory.Quantity
            FROM Inventory
            JOIN Line_Item l ON i.Prod_Id=l.Prod_Id;
            */
        //}
        
    }
}

/*public Inventory ReplenishLineById(Inventory p_inv, int p_howMuchAdded)
        {
            p_inv.Quantity += p_howMuchAdded;

            return _repo.ReplenishInv(p_inv);
        }
       */