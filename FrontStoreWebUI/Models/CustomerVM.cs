using StoreModels;

namespace FrontStoreWebUI.Models
{
    public class CustomerVM
    {
        public CustomerVM(Customer p_cust)
        {
            this.CustomerId = p_cust.CustomerId;
            this.FirstName = p_cust.FirstName;
            this.LastName = p_cust.LastName;
            this.StreetAddress = p_cust.StreetAddress;
            this.Email = p_cust.Email;
            this.Phone = p_cust.Phone;
        }


        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}
