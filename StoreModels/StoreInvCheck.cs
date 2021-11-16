using System;
using System.Collections.Generic;


namespace StoreModels
{
    public class StoreInvCheck
    {   
        
        public StoreInvCheck() 
        {

        }
        
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public  Product Product { get; set; }
        public  Inventory Inventory { get; set; }
        public  StoreFront StoreFront { get; set; }

    }    
}

