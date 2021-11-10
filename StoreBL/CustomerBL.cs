using System.Collections.Generic;
using System.Linq;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class CustomerBL:ICustomerBL
    {
        private IRepository _repo;
        
        public CustomerBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Customer CustomerSignUp(Customer p_customer)
            {
            return _repo.AddCustomer(p_customer);
            }
        public List<Customer> GetAllCustomers()
        {
            
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            for (int i = 0; i < listOfCustomer.Count; i++)
            {
                listOfCustomer[i].FirstName = listOfCustomer[i].FirstName.ToUpper(); 
            }

            return listOfCustomer;
        
        }
        public List<Customer> GetCustomerName(string p_customerfname)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            return listOfCustomer.Where(cust => cust.FirstName.ToLower().Contains(p_customerfname.ToLower())).ToList();
        }  

    }
}
