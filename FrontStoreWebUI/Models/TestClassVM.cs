using StoreModels;
using System.Collections.Generic;

namespace FrontStoreWebUI.Models
{
    public class TestClassVM
    {
        public TestClassVM()
        {

        }

        public TestClassVM(TestClass p_inv)
        {
           // this.InvId = p_inv.InvId;
            this.StoreId = p_inv.StoreId;
            this.ProdId = p_inv.ProductId;
            this.Quantity = p_inv.Quantity;

        }

        //public List<TestClass> TestClass { get; set; }

        public int InvId { get; set; }
        public int StoreId { get; set; }
        public int ProdId { get; set; }
        public int Quantity { get; set; }

    }
}
