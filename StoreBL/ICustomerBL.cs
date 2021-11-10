using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface ICustomerBL
    {
        Customer CustomerSignUp(Customer p_customer);
        List<Customer> GetAllCustomers();
        List<Customer> GetCustomerName(string p_customerfname);
    }
}