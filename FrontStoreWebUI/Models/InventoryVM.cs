using StoreModels;
using System.Collections.Generic;

namespace FrontStoreWebUI.Models
{
    public class InventoryVM
    {
        

        public InventoryVM(Inventory p_inv)
        {   
            this.InvId = p_inv.InvId;
            this.StoreId = p_inv.StoreId;
            this.ProductId = p_inv.ProductId;
            this.Quantity = p_inv.Quantity;
            
        }

       public IEnumerator<Inventory> Inventories { get; set; }
        
        public int InvId { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        
    }
}
