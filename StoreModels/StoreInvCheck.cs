using System;
using System.Collections.Generic;


namespace StoreModels
{
    public class StoreInvCheck
    {   
        
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        
    }    
}

