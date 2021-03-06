
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
    
        
        public StoreFront StoreById(int p_id)
        {
            return _context.StoreFronts.Find(p_id);
        }

        public List<Inventory> InventoryByStoreId(int p_id)
        {
            return _context.Inventories
            .Where(inv => inv.StoreId == p_id)
            .ToList();
        }

        


        public Product GetProductById(int p_id)
        {
            return _context.Products
                            .AsNoTracking()
                            .FirstOrDefault(pro => pro.ProductId == p_id);
        }

        public Product AddProduct(Product p_product)
        {
            _context.Products.Add(p_product);
            _context.SaveChanges();
            return p_product;
        }


        public Customer AddCustomer(Customer p_customer)
        {
            _context.Customers.Add(p_customer);
            _context.SaveChanges();
            return p_customer;
        }


        public PurchaseOrder PlaceOrder(PurchaseOrder p_order)
        {
            _context.PurchaseOrders.Add(p_order);
            _context.SaveChanges();
            return p_order;
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

        public List<Customer> GetCustomerByNames(string p_cust)
        {
            //List<Customer> result = new List<Customer>();
    
            return _context.Customers
                    .Where(customer => (customer.FirstName.Trim() + " " 
                                        + customer.LastName.Trim() + " ")
                                        .Trim().Contains(p_cust.ToLower())
                                        ).ToList();
                    
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

                

 
        public Inventory GetItemById(int p_id)
        {
            return _context.Inventories
            .AsNoTracking() //Stop tracking entity once found
            .FirstOrDefault(inv => inv.InvId == p_id);
            
        }


        public List<Customer> GetAllCustomer(Customer p_cust)
        {
            return _context.Customers.ToList();
        }

        public List<Product> GetAllProducts()
        {
            
            return _context.Products.ToList();

        }

        public List<StoreModels.StoreFront> GetAllStore()
        {
            return _context.StoreFronts.ToList();
        }

        public List<StoreModels.PurchaseOrder> ShowOrders()
        {
            return _context.PurchaseOrders.ToList();
        }

        public StoreFront AddStore(StoreFront p_store)
        {
            _context.StoreFronts.Add(p_store);
            _context.SaveChanges();
            
            return p_store;
        }

        public List<Inventory> ShowInventory()
        {
            return _context.Inventories.ToList();
        }
        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }


        public Inventory Replenish(Inventory update)
        {

            _context.Inventories.Update(update);
            _context.SaveChanges();
            return update;
        }
    

        public List<StoreInvCheck> AllItemStoreInfo(int p_id)
        {
            
            
            var result = (
                        from i in _context.Inventories
                        join p in _context.Products
                        on i.ProductId equals p.ProductId 
                        where i.StoreId == p_id
                        select new StoreInvCheck  {
                            
                            StoreId = i.StoreId,
                            ItemName = p.ItemName,
                            ProductId = p.ProductId,
                            Price = p.Price,
                            Quantity = i.Quantity

                        }).ToList();

            return result;
            
        }

        public PurchaseOrder GetOrderById(int p_id)
        {
            return _context.PurchaseOrders
            .AsNoTracking() //Stop tracking entity once found
            .FirstOrDefault(ord => ord.OrderId == p_id);

        }

        public PurchaseOrder DeleteOrder(PurchaseOrder p_order)
        {
            _context.PurchaseOrders.Remove(p_order);
            _context.SaveChanges();
            return p_order;
        }

    }
}


/*
                        let t2 = t1.Inventories.Product
                        on new { A = t1.ProductId, B = t1.Description } equals new { A = t2.}
                                
/*public
List<Customer> listOfCustomer = _repo.GetAllCustomers();
            return listOfCustomer.Where(cust => cust.FirstName.
                                                    ToLower().
                                                    Contains(p_cust.ToLower()) 
                                            && cust.LastName.
                                                    ToLower().
                                                    Contains(p_cust.ToLower())).
                                                    ToList();

*/
            // List<Model.Restaurant> listOfRest = new List<Model.Restaurant>();
            // foreach (var rest in result)
            // {
            //     listOfRest.Add(new Model.Restaurant(){
            //         Name = rest.RestName,
            //         State = rest.RestState,
            //         City = rest.RestCity,
            //         Id = rest.RestId
            //     });
            // }

            // return listOfRest;
            /*
            return _context.Inventories
                    .Where(item => item.ProductId == p_id)
        */
