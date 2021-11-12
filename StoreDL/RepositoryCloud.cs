
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreModels;
using System.Text;
using System.Threading.Tasks;

namespace StoreDL
{
    public class RepositoryCloud : IRepository
    {
        //Depedency Injection
        private StoreDL.DBp0Context _context;
        public RepositoryCloud(DBp0Context p_context)
        {
            _context = p_context;
        }
    

        public void Sale()
        {
            using (DBp0Context _context = new DBp0Context())
           {    
            var q = 
            (@"
                        SELECT *
                        FROM Customer
                        WHERE Customer_Id = 1"); 
            //_context.DBp0Context _context = new DBp0Context();
            //IEnumerable<PurchaseOrder> result = _context.ExecuteQuery<DBp0Context>
            var result = _context.Customers.FromSqlRaw(q);
            
            }
        }

        public PurchaseOrder Checkout(PurchaseOrder p_purc)
        {
            _context.PurchaseOrders.Add(p_purc);

            //Save changes to DB
            _context.SaveChanges();
            return p_purc;
        }

        public Product AddProduct(Product p_product)
        {
            _context.Products.Add(p_product);

            //Save changes to DB
            _context.SaveChanges();

            return p_product;
        }


        public Customer AddCustomer(Customer p_customer)
        {
            _context.Customers.Add(p_customer);

            //Save changes to DB
            _context.SaveChanges();
            return p_customer;
        }

        public Customer GetCustomerById(int p_id)
        {
            return _context.Customers
                        .AsNoTracking() //This makes it so it stops tracking the entity once it finds the review
                        .FirstOrDefault(cus => cus.CustomerId == p_id);
        }

        public List<Customer> GetCustomerByFirstName(string p_cust)
        {
            return _context.Customers
                    .Where(cust => cust.FirstName
                    .ToLower()
                    .Contains(p_cust.ToLower()))
                    .ToList();
    
        }

        public List<Customer> GetCustomerByLastName(string p_cust)
        {
            return _context.Customers
                    .Where(cust => cust.LastName
                    .ToLower().Contains(p_cust.ToLower()))
                    .ToList();
        }

        public Customer DeleteCustomer(Customer p_customer)
        {
            _context.Customers.Remove(p_customer);
            _context.SaveChanges();
            return p_customer;
        }

        public LineItem AddQuantityById(LineItem p_lin)
        {
           
            //Updates the Entity Review based on the current Id it has
            //Checks other properties of entity to see if they changed
            //If they changed it will update it
            _context.LineItems.Update(p_lin);

            //Save the changes of the review
            _context.SaveChanges();

            return p_lin;
        }

        public Inventory DecreaseInventory(Inventory p_inv)
        {
           
            _context.Inventories.Update(p_inv);

            _context.SaveChanges();

            return p_inv;
        }


        public Product GetProductById(int p_id)
        {
            return _context.Products
            .AsNoTracking() //Stop tracking entity once found
            .FirstOrDefault(prod => prod.ProductId == p_id);
            
        }
 
        public Inventory GetItemById(int p_id)
        {
            return _context.Inventories
            .AsNoTracking() //Stop tracking entity once found
            .FirstOrDefault(inv => inv.InvId == p_id);
            
        }


        public List<StoreModels.Customer> GetAllCustomer(Customer p_cust)
        {
            return _context.Customers.ToList();
        }

        public List<StoreModels.Product> GetAllProduct()
        {
            
            //1. Method Syntax - LINQ
            return _context.Products.ToList();

            //2. Query Syntax
            // var result = (from prod in _context.Products
            //             select prod);

            // List<Model.Product> listOfProd = new List<Model.Product>();
            // foreach (var rest in result)
            // {
            //     listOfProd.Add(new Model.Product(){
            //         ProductId = prod.ProductId,
            //         Name = prod.Name,
            //         Category = prod.Category,
            //         Price = prod.Price,
            //         Description = prod.Description
            //     });
            // }

            // return listOfProd;
        }

        public List<StoreModels.StoreFront> GetAllStore()
        {
            return _context.StoreFronts.ToList();
        }

        public StoreFront AddStore(StoreFront p_store)
        {
            _context.StoreFronts.Add(p_store);
            _context.SaveChanges();
            
            return p_store;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

    }
}

