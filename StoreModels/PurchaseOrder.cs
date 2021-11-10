
using System;
using System.Text.RegularExpressions;

namespace StoreModels

{
    public class PurchaseOrder
    {
        private int _orderId;
        private int _locationId;
        private int _customerId;
        private decimal _price;
        
        public int OrderId { get; set;}
        public int StoreId {get; set;}
        public int CustomerId {get; set; }
        public decimal TotalPrice { get; set; }

        public virtual StoreFront StoreOrder {get; set;}
        public virtual LineItem LineOrder {get; set;}
        public virtual Customer CustOrder {get; set;}
         
    }
}
