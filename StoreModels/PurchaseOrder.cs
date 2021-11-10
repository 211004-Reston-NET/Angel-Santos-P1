
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StoreModels

{
    public class PurchaseOrder
    {
        private int _orderId;
        private int _locationId;
        private int _customerId;
        private decimal _price;
        public List<LineItem> LineItem { get; set; }
        
        public int OrderId { get; set;}
        public int StoreFrontId {get; set;}
        public int CustomerId {get; set; }
        public decimal TotalPrice { get; set; }

        
         
    }
}
