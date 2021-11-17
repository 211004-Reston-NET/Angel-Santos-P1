using StoreModels;
using System;
using System.Collections.Generic;

namespace FrontStoreWebUI.Models
{
    public class PurchaseOrderVM
    {
        public PurchaseOrderVM()
        {

        }

        public PurchaseOrderVM(PurchaseOrder p_pur)                               
        {
            OrderId = p_pur.OrderId;
            StoreId = p_pur.StoreFrontId;
            CustomerId = p_pur.CustomerId;
            TotalPrice = p_pur.TotalPrice;
            PurchaseDate = p_pur.PurchaseDate;

            
        }

        public IEnumerable<PurchaseOrderVM> Products { get; set; }
        
        public IEnumerable<Inventory> Inventories { get; set; }
        public IEnumerable<StoreFront> StoreFronts { get; set; }

        public int OrderId { get; set; }
        public int StoreFrontId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int StoreId { get; private set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }

        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ItemName { get; set; }
        public string StoreName { get; set; }

        public int Quantity { get; set; }
    }
}
