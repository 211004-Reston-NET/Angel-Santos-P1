using StoreModels;
using StoreDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontStoreWebUI.Models
{
    public class StoreVM
    {
        public StoreVM(StoreFront p_store)
        {
            this.StoreId = p_store.StoreId;
            this.StoreName = p_store.StoreName;
            this.Address = p_store.Address;
            this.City = p_store.City;
            this.State = p_store.State;
        }

        public int StoreId { get; set;  }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}
