using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace StoreModels
{
    public class Product
    {
        
        public int ProductId { get; set; }
        public string ItemName { get;set; } 
        public string Category { get;set; } 
        public decimal Price { get;set; } 
        public string Description { get;set; }

        public StoreFront StoreFront { get;set; }
        
        
    }
}



