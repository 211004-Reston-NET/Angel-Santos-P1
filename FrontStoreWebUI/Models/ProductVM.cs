using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreDL;
using StoreModels;

namespace FrontStoreWebUI.Models
{
    public class ProductVM
    {
        public ProductVM()
        {

        }
        public ProductVM(Product p_prod)
        {
            this.ProductId = p_prod.ProductId;
            this.ItemName = p_prod.ItemName;
            this.Category = p_prod.Category;
            this.Price = p_prod.Price;
            this.Description = p_prod.Description;
        }
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
