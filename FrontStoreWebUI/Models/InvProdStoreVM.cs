using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontStoreWebUI.Models
{
    public class StoreInvCheckVM
    {
        public StoreInvCheckVM()
        {

        }

        public StoreInvCheckVM(Inventory p_inv)
        {
            InvId = p_inv.InvId;
            StoreId = p_inv.StoreId;
            ProductId = p_inv.ProductId;
            Quantity = p_inv.Quantity;
        }

        public StoreInvCheckVM(Inventory p_inv, StoreFront p_store, Product p_prod)
        {
            InvId = p_inv.InvId;
            StoreId = p_inv.StoreId;
            ProductId = p_inv.ProductId;
            Quantity = p_inv.Quantity;


            StoreId = p_store.StoreId;
            StoreName = p_store.StoreName;

            ProductId = p_prod.ProductId;
            ItemName = p_prod.ItemName;


        }

       

        public IEnumerable<Inventory> Inventories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<StoreFront> StoreFronts { get; set; }

        public int InvId { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string StoreName { get; set; }
        public string ItemName { get; set; }
    }
}
