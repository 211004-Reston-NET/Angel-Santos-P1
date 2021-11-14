namespace StoreModels
{
    public class Inventory
    {   
        public Product Product { get; set; }
        public StoreFront StoreFront { get; set; }
        public int InvId    { get; set; }
        public int StoreId {get; set;}
        public int ProductId { get; set; }
        public int Quantity    { get; set; }

        
        
    }    
}

