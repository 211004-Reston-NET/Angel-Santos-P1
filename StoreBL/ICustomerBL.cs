using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface ICustomerBL
    {
        Customer CustomerSignUp(Customer p_customer);
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int p_id);
        List<Customer> GetCustomerByFirstName(string p_cust);
        List<Customer> GetCustomerByLastName(string p_cust);
        //List<Customer> GetCustomerByNames(string p_cust, string p_cust1);
    }
}