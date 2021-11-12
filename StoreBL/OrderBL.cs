using System;
using StoreDL;
using StoreModels;
using System.Linq;
using System.Collections.Generic;

namespace StoreBL
{
    public class OrderBL : IOrderBL
    {
        private IRepository _repo;
        
        public OrderBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public PurchaseOrder Checkout(PurchaseOrder p_purc)
            {
            return _repo.Checkout(p_purc);
            }

        /*public void Sale (PurchaseOrder p_sale)
        {
            DBp0Context _context = new DBp0Context();
            IEnumerable<PurchaseOrder> result = ExecuteQuery<PurchaseOrder>
          
               var _sale = 
               (@"WITH order AS (
                        SELECT Customer_Id
                        FROM Customer 
                        UNION
                        SELECT * 
                        FROM Line_Item --items selected by customer
                        UNION
                        SELECT Product_Id, Price --product and price 
                        FROM Product 
                        UNION
                        SELECT Store_Id
                        FROM Store_Front
                        UNION
                        SELECT *
                        FROM Purchase_Order
                        ),
                        WITH sale AS (select Line_Item.Quantity * Product.Price
                        FROM order),
                        UPDATE Purchase_Order 
                        SET Store_Id.Purchase_Order == Store_Front.Store_Id,
                        Customer_Id.Purchase_Order == Customer_Id.Customer,
                        Purchase_Order.Total_Price == sale") 
        }
        */

        

        //(from c in _context.Customers.Union(
        //    from _context.LineItems)

        /*(with order as (
                    select Customer_Id
                    from Customer 
                    union
                    select * 
                    from Line_Item --items selected by customer
                    union
                    select Product_Id, Price --product and price 
                    from Product 
                    union
                    select Store_Id
                    from Store_Front
                    union
                    select *
                    from Purchase_Order
                    ),
                    with sale AS (select Line_Item.Quantity * Product.Price
                    from order),
                    update Purchase_Order 
                    set Store_Id.Purchase_Order == Store_Front.Store_Id,
                    Customer_Id.Purchase_Order == Customer_Id.Customer,
                    Purchase_Order.Total_Price == sale
                    )();
        }        
    /*
        with order AS (
        select Customer_Id
        from Customer 
        union
        select * 
        from Line_Item --items selected by customer
        union
        select Product_Id, Price --product and price 
        from Product 
        union
        select Store_Id
        from Store_Front
        union
        select *
        from Purchase_Order
        ),
        with sale AS (select Line_Item.Quantity * Product.Price
        from order),
        update Purchase_Order 
        set Store_Id.Purchase_Order == Store_Front.Store_Id,
        Customer_Id.Purchase_Order == Customer_Id.Customer,
        Purchase_Order.Total_Price == sale;




    public PurchaseOrder QuantityById(PurchaseOrder p_inv, int p_howMuchAdded)
    {
        p_inv.Quantity += p_howMuchAdded;

        return _repo.ReplenishInv(p_inv);
    }
    */



    
    }
}
