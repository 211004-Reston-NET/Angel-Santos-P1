using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StoreModels
{
    public class StoreFront
    {   
        private string _storeName;
        private string _address;
        private string _city;
        private string _state;
        public List<PurchaseOrder> Orders { get; set; }
        public int StoreId { get; set; }
        public string StoreName 
        {
            get { return _storeName; }
            set 
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {       
                    throw new Exception("   State must contain only letters.    ");
                }
                _storeName = value;
            }
        }
        public string Address
        {
            get { return _address; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {       
                    throw new Exception
                    (
                        "   Street Address cannot be left empty.     "
                    );
                }
                _address = value;    
            } 
        }
        public string City
        {
            get { return _city; }
            set 
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$" ))
                {       
                    throw new Exception("   City must contain only letters.    ");
                }
                _city = value;
            }
        }
        public string State 
        {
            get { return _state; }
            set 
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {       
                    throw new Exception("   State must contain only letters.    ");
                }
                _state = value;
            }
        }

        

        public override string ToString()
        {
            return $"Name: {StoreName}\nStreet Address: {Address}\nCity: {City}\nState: {State}";
        }

    }
}
