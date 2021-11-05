
using System;
using System.Text.RegularExpressions;

namespace StoreModels

{
    public class PurchaseOrder
    {
        private int _orderId;
        private int _locationId;
        private int _customerId;
        private string _itemName;
        private decimal _price;
        public int OrderId 
        { get; set;}
        
        public int LocationId {get; set;}

        public int CustomerId {get; set; }
        public string ItemName 
        { 
        get { return _itemName; }
        set
            {
            //Regex.IsMatch() Method - checks the regular expression to match with input string
            //Exception is thrown when Field is set with a number
            if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {       
                    throw new Exception("   First Name must contain only letters.  ");
                }
                _itemName = value;
            } 
        }

        public decimal TotalPrice { get; set; }

         public override string ToString()
        {
            return $"OrderId: {OrderId}\nLocationId: {LocationId}\nCustomerId: {CustomerId}\nItemName: {ItemName}\nPrice: {TotalPrice}";
        }
    }
}
