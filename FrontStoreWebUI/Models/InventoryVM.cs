using StoreModels;
using System.Collections.Generic;

namespace FrontStoreWebUI.Models
{
    public class InventoryVM
    {
        
        public InventoryVM()
        {

        }

        public InventoryVM(Inventory p_inv)
        {
           
                this.InvId = p_inv.InvId;
                this.StoreId = p_inv.StoreFront.StoreId;
                this.ProdId = p_inv.Product.ProductId;
                this.Quantity = p_inv.Quantity;
                
            
        }

        

        /*
         *public InventoryVM( p_inv)
            {
                new Inventory
                {
                    this.InvId = p_inv.InvId;
                    this.StoreId = p_inv.StoreId;
                    this.ProdId = p_inv.ProductId;
                    this.Quantity = p_inv.Quantity;
                }
            }

         */

        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<StoreFront> StoreFronts { get; set; }

        public int InvId { get; set; }
        public int StoreId { get; set; }
        public int ProdId { get; set; }
        public int Quantity { get; set; }
        
    }
}
