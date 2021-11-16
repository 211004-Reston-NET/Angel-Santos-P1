
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StoreModels

{
    public class PurchaseOrder
    {

        public List<LineItem> LineItem { get; set; }
        
        public int OrderId { get; set;}
        public int ProductId { get; set; }
        public int StoreFrontId {get; set;}
        public int CustomerId {get; set; }
        public string ItemName { get;set; } 
        public decimal TotalPrice { get; set; }

        
         
    }
}
