using System.Collections.Generic;

namespace StoreModels
{
    public class LineItem
    {   
        public List<PurchaseOrder> Orders { get; set; }
        public Product Product { get; set; }
        public int LineId    { get; set; }
        public int ProductId { get; set; }
        public int Quantity    { get; set; }

           
       
    }    
}

