using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace StoreModels
{
    public class Customer
    {
        
        private string _firstName;
        private string _lastName;
        private string _streetAddress;
        //private string _email;
        public List<PurchaseOrder> Orders { get; set; }
        public int CustomerId { get; set; }
        public string FirstName 
        { 
        get { return _firstName; }
        set
            {
            //Regex.IsMatch() Method - checks the regular expression to match with input string
            //Exception is thrown when Field is set with a number
            if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {       
                    throw new Exception("   First Name must contain only letters.  ");
                }
                _firstName = value;
            } 
        }
        public string LastName 
        { 
        get { return _lastName; }
        set
            {
            if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {       
                    throw new Exception("   Last Name must contain only letters.    ");
                }
                _lastName = value;
            }
        }
        public string StreetAddress
        {
            get { return _streetAddress; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {       
                    throw new Exception
                    (
                        "   Street Address cannot be left empty.     "
                    );
                }
                _streetAddress = value;    
            } 
        }
       
        public string Email 
        { get ; set;}
        public int Phone 
        { get ; set;}
        
        
            
        //public override string ToString()
        //{
        //    return $"First Name: {FirstName}\nLast Name:{LastName}\nStreet Address: {StreetAddress}\nEmail: {Email}";
        //}
    }
}
