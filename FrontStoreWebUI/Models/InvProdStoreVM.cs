using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontStoreWebUI.Models
{
    public class InvProdStoreVM
    {
        public InvProdStoreVM()
        {

        }

        public IEnumerable<Inventory> Inventories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<StoreFront> StoreFronts { get; set; }
    }
}
