using System;
using System.Collections.Generic;


namespace StoreModels
{
    public class TestClass
    {   
        public TestClass()
        {

        }

        //public Product Products { get; set; }
       // public PurchaseOrder Orders { get; set; }
       // public StoreFront Locations { get; set; }
       // public Inventory Inventories { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public string ItemName { get; set; }
        public string Category { get;set; } 
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public virtual IEnumerable<Product> Product { get; set; }
        public virtual IEnumerable<StoreFront> StoreFront { get; set; }

    }    
}

