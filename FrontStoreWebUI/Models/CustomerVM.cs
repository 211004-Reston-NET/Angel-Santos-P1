using StoreModels;
using System.ComponentModel.DataAnnotations;

namespace FrontStoreWebUI.Models
{
    public class CustomerVM
    {
        public CustomerVM()
        {

        }
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
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Required]
        public int Phone { get; set; }
    }
}
