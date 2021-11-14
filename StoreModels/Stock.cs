using System.Collections.Generic;

namespace StoreModels
{
    public class Stock
    {   
        public Product Products { get; set; }
        public PurchaseOrder Orders { get; set; }
        public StoreFront Locations { get; set; }
        public Inventory Inventories { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

    }    
}

